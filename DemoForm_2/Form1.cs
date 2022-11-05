namespace DemoForm_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = (sender as Button).Text;
            listBox1.Items.Add(title);
        }
    }
}