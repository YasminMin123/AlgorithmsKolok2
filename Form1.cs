namespace Algor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Coctail coctail = new Coctail();
            coctail.Show();
        }

        private void gnomebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gnome gnome = new Gnome();
            gnome.Show();
        }

        private void cyclicbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cyclic cyclic = new Cyclic();
            cyclic.Show();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}