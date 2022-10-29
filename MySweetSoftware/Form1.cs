using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySweetSoftware
{
    public partial class Form1 : Form
    {
        List<Product> products;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Are you want to open software ?");
            this.products = new List<Product>()
            {
                new Product{ProductId=1, ProductName="Rice", Price=85, Avaiable=true},
                new Product{ProductId=2, ProductName="Mango", Price=120, Avaiable=false},
                new Product{ProductId=3, ProductName="Banana", Price=30, Avaiable=true},
                new Product{ProductId=4, ProductName="Orange", Price=90, Avaiable=false},
                new Product{ProductId=5, ProductName="Apple", Price=240, Avaiable=true},
            };
            this.dataGridView1.DataSource = this.products;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var result = from p in products
                         where p.Price > 50
                         select p;
            this.dataGridView1.DataSource = result.ToList();


            //var result1 = products.Where(p =>p.Price>50).Select(p => p);
            //this.dataGridView1.DataSource = result1.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = products;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result = from p in products
                         where p.Avaiable
                         select p;

            // var result1 = products.Where(p => p.Avaiable).Select(p => p);
            // 
            this.dataGridView1.DataSource = result.ToList();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int count = products.Count();
            MessageBox.Show($"Product Count :{count}");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            //int count = (from p in products
            //             where p.Avaiable
            //             select p).Count();

           // int count = (products.Where(p => p.Avaiable).Select(p => p)).Count();
           
            int cout =products.Count( p =>p.Avaiable);
             
            MessageBox.Show($"Available Product Count :{cout}");

        }
    }
}
