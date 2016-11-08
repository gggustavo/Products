using System;
using System.Windows.Forms;
using Controller;
using Model;

namespace View
{
    public partial class ProductsForm : Form
    {
        private ProductController _productController;
        private CategoryController _categoryController; 

        public ProductsForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            _productController = new ProductController();
            _categoryController = new CategoryController();

            categoryBindingSource.DataSource = _categoryController.GetAll();
            productBindingSource.DataSource = _productController.GetAll();

            base.OnLoad(e);
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (categoryBindingSource.Current == null) return;

            var product = new Product
            {
                Name = name.Text,
                Price = Convert.ToDecimal(price.Text),
                IdCategory = ((Category)categoryBindingSource.Current).IdCategory
            };

            _productController.Add(product);
            productBindingSource.DataSource = _productController.GetAll();
        }

        

        private void remove_Click(object sender, EventArgs e)
        {
            if (categoryBindingSource.Current == null) return;

            var item = (Product)productBindingSource.Current;
            _productController.Remove(item.IdProduct);
            productBindingSource.DataSource = _productController.GetAll();
        }
    }
}
