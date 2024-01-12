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
    public partial class Form2 : Form
    {
        Product prod = new Product();
        public Form2()
        {
            InitializeComponent();
        }
        public void prisv(Product product)
        {
            prod = product;

            product.Name = textBox1.Text;
            product.Description = textBox3.Text;
            product.Characteristic = textBox2.Text;
            double.TryParse(textBox4.Text, out double price);
            product.Price = price;
            product.listStr = $"Название: {product.Name}, Описание: {product.Description}";
           
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text == "" || textBox2.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Введите все значения");
                prisv(prod);
            }
            else
            {
                this.Close();
            }
        }
    }
}
