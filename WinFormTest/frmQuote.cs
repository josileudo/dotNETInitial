using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTest
{
    public partial class frmQuote : Form
    {
        public frmQuote()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Cliquei em Search";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
