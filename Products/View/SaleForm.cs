using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace View
{
    public partial class SaleForm : Form
    {
        private SaleController _saleController;

        public SaleForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            _saleController = new SaleController();

            base.OnLoad(e);
        }

        private void search_Click(object sender, EventArgs e)
        {
            var date = dpSale.Value;
            dataSaleBindingSource.DataSource = _saleController.GetAllByDate(date);
        }
    }
}
