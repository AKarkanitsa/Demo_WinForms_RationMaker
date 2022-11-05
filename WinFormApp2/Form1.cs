using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataObjects;
using BusinessObjects;

namespace WinFormApp2
{
    public partial class Form1 : Form
    {
        Db db;
        CategoryDao categoryDao = new CategoryDao();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           List<Category> list=categoryDao.GetCategories();
            foreach (Category c in list)
            {
                listBox1.Items.Add(c.CategoryName);
            }

        }
    }
}
