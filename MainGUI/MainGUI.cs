using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainGUI
{
    public partial class MainGUI : Form
    {
        public MainGUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            this.textBox1.Text = b.Text;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = e.X + " " + e.Y;
        }
    }
}
