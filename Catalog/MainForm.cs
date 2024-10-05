using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
using CatalogBase;
using System.Diagnostics;

namespace Catalog
{
    public partial class MainForm : Form
    {
        private List<Product> filteredProducts;
        private int currentPage = 1;
        private int productsPerPage = 3;
        public MainForm()
        {
            InitializeComponent(); 
        }
        private void Main_Load(object sender, EventArgs e)
        {
            using (var context = new MyDbContext())
            {
                context.Database.EnsureCreated();
                var products = context.Products.Include(p => p.Manufacturer).ToList();

                foreach (var product in products)
                {
                    var productCard = new ProductCard(product);
                    flowLayoutPanel.Controls.Add(productCard);
                }
                filterComboBox.Items.Clear();
                filterComboBox.Items.Add("Все производители");
                filterComboBox.SelectedIndex = 0;
                foreach (var manufacturer in context.Manufacturers)
                {
                    filterComboBox.Items.Add($"{manufacturer.Name}");
                }
            }
            sortComboBox.Items.Add("Название");
            sortComboBox.Items.Add("Цена ↑");
            sortComboBox.Items.Add("Цена ↓");
            sortComboBox.Items.Add("Количество ↑");
            sortComboBox.Items.Add("Количество ↓");
            sortComboBox.Items.Add("Производитель ↑");
        }
        private void LoadProducts()
        {
            using (var context = new MyDbContext())
            {
                var query = context.Products.Include(p => p.Manufacturer).AsQueryable();

                if (filterComboBox.SelectedIndex > 0)
                {
                    string selectedManufacturer = filterComboBox.SelectedItem.ToString();
                    query = query.Where(p => p.Manufacturer.Name == selectedManufacturer);
                }

                string searchTerm = searchTextBox.Text.Trim();
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    query = query.Where(p => p.Name.ToLower().Contains(searchTerm.ToLower()) || p.Manufacturer.Name.ToLower().Contains(searchTerm.ToLower()));
                }

                string sortField = sortComboBox.SelectedItem?.ToString();
                switch (sortField)
                {
                    case "Название ↑":
                        query = query.OrderBy(p => p.Name);
                        break;
                    case "Цена ↑":
                        query = query.OrderBy(p => p.Price);
                        break;
                    case "Цена ↓":
                        query = query.OrderByDescending(p => p.Price);
                        break;
                    case "Количество ↑":
                        query = query.OrderBy(p => p.Quantity);
                        break;
                    case "Количество ↓":
                        query = query.OrderByDescending(p => p.Quantity);
                        break;
                    case "Производитель ↑":
                        query = query.OrderBy(p => p.Manufacturer.Name);
                        break;
                    default:
                        query = query.OrderBy(p => p.Name);
                        break;
                }

                int skipAmount = (currentPage - 1) * productsPerPage;
                query = query.Skip(skipAmount).Take(productsPerPage);

                filteredProducts = query.ToList();

                flowLayoutPanel.Controls.Clear();
                foreach (var product in filteredProducts)
                {
                    var productControl = new ProductCard(product);
                    flowLayoutPanel.Controls.Add(productControl);
                }
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Update_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            AddForm addingForm = new AddForm();
            addingForm.ShowDialog();
            LoadProducts();
            using (var context = new MyDbContext())
            {
                filterComboBox.Items.Clear();
                filterComboBox.Items.Add("Все производители");
                filterComboBox.SelectedIndex = 0;

                foreach (var manufacturer in context.Manufacturers)
                {
                    filterComboBox.Items.Add($"{manufacturer.Name}");
                }
            }
        }
        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadProducts();
            }
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            using (var context = new MyDbContext())
            {
                int maxPage = (int)Math.Ceiling((double)context.Products.Count() / productsPerPage);
                if (currentPage < maxPage)
                {
                    currentPage++;
                    LoadProducts();
                }
            }
        }
    }
}