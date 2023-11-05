using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algor
{
    public partial class Cyclic : Form
    {
        public Cyclic()
        {
            InitializeComponent();
        }

        private void prevCoctail_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void nextCyclic_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainAl mainAl = new MainAl();
            mainAl.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
