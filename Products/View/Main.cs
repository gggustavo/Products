using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new ProductsForm();
            frm.ShowDialog(this);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new SaleForm();
            frm.ShowDialog(this);
        }
    }
}
