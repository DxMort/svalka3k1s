using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Catalog
{
    public partial class ProductCard : UserControl
    {
        public ProductCard(Product product)
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(product.Path);
            nameLabel.Text += product.Name;
            descriptionTextBox.Text = product.Description;
            manufacturerLabel.Text += product.Manufacturer.Name;
            costLabel.Text += product.Price.ToString();
            quantityLabel.Text += product.Quantity.ToString();
            if (product.Quantity > 0)
            {
                this.BackColor = Color.LightSkyBlue;
            }
            else
            {
                this.BackColor = Color.LightGray;
            }
        }
    }
}
