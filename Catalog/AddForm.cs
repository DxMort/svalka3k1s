using CatalogBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalog
{
    public partial class AddForm : Form
    {
        private string filePath;
        public AddForm()
        {
            InitializeComponent();
        }
        
        private void textBoxes_MouseDown(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
                nameTextBox.Text = "Введите название";
            if (string.IsNullOrWhiteSpace(manufacturerTextBox.Text))
                manufacturerTextBox.Text = "Введите производителя";
            if (string.IsNullOrWhiteSpace(descriptionTextBox.Text))
                descriptionTextBox.Text = "Введите описание";
            if (string.IsNullOrWhiteSpace(priceTextBox.Text))
                priceTextBox.Text = "Введите цену";
            if (string.IsNullOrWhiteSpace(quantityTextBox.Text))
                quantityTextBox.Text = "Введите количество";
        }
        private void textBoxes_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (textBox.Text == "Введите название" ||
                    textBox.Text == "Введите производителя" ||
                    textBox.Text == "Введите описание" ||
                    textBox.Text == "Введите цену" ||
                    textBox.Text == "Введите количество")
                {
                    textBox.Clear();
                }
            }
        }

        private void AddingButton_Click(object sender, EventArgs e)
        {
            filePath = "";
            
            if (string.IsNullOrEmpty(nameTextBox.Text) ||
                string.IsNullOrEmpty(descriptionTextBox.Text) ||
                string.IsNullOrEmpty(manufacturerTextBox.Text) ||
                string.IsNullOrEmpty(priceTextBox.Text) ||
                string.IsNullOrEmpty(quantityTextBox.Text))
            {
                MessageBox.Show("Заполните все поля.");
                return;
            }
            if  (string.IsNullOrEmpty(filePath))
            {
                filePath = "F:\\HCI\\3kyrs\\1sem\\c#\\Catalog\\pictures\\default.png";
            }
                double price;
            if (!double.TryParse(priceTextBox.Text, out price))
            {
                MessageBox.Show("Неккоректное значение цены.");
                return;
            }

            int quantity;
            if (!int.TryParse(quantityTextBox.Text, out quantity))
            {
                MessageBox.Show("Неккоректное значение количества.");
                return;
            }

            string manufacturerName = manufacturerTextBox.Text;
            Manufacturer manufacturer;
            using (var context = new MyDbContext())
            {
                manufacturer = context.Manufacturers.FirstOrDefault(m => m.Name == manufacturerName);

                if (manufacturer == null)
                {
                    manufacturer = new Manufacturer { Name = manufacturerName };
                    context.Manufacturers.Add(manufacturer);
                }

                string productName = nameTextBox.Text;
                bool productExists = context.Products.Any(p => p.Name == productName);

                if (productExists)
                {
                    MessageBox.Show("Продукт с таким названием уже существует.");
                    return;
                }

                Product product = new Product
                {
                    Name = productName,
                    Description = descriptionTextBox.Text,
                    Path = filePath,
                    Price = price,
                    Manufacturer = manufacturer,
                    Quantity = quantity
                };

                context.Products.Add(product);

                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Продукт добавлен.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
        private void selectPictureButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    var directoryPath = System.IO.Path.GetDirectoryName(filePath);
                    var fileName = System.IO.Path.GetFileName(filePath);
                    MessageBox.Show($"{fileName} загружен.", directoryPath, MessageBoxButtons.OK);
                }
            }
        }
    }
}
