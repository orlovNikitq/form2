using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D3
{
    public partial class Form1 : Form
    {
        private List<Product> products = new List<Product>(); 
        private double totalCost = 0;
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
            Product product = new Product();
            form.prisv(product);
            comboBox1.Items.Add(product.Name);
            products.Add(product);  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                Product selectedProduct = products[comboBox1.SelectedIndex];
                listBox1.Items.Add(selectedProduct.listStr);
                totalCost += selectedProduct.Price;
                label4.Text = $"Общая сумма проданных товаров: {totalCost} руб.";
            }
        }
        private void UpdateTextBox1Value()
        {
            if (comboBox1.SelectedIndex != -1)
            {
                Product selectedProduct = products[comboBox1.SelectedIndex];
                textBox1.Text = selectedProduct.Price.ToString();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTextBox1Value();
        }
    }
}
