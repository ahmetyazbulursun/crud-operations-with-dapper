using DapperCRUD.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperCRUD.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void GetAllProducts()
        {
            using (ProductRepository productRepository = new ProductRepository())
            {
                grd_products.DataSource = productRepository.GetAllDataList();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GetAllProducts();
        }

        private void grd_products_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int product_id = (int)grd_products.SelectedRows[0].Cells[0].Value;
            Forms.UpdateProduct updateProduct = new Forms.UpdateProduct(product_id);
            updateProduct.ShowDialog(this);
        }

        private void btn_new_record_Click(object sender, EventArgs e)
        {
            InsertProduct insertProduct = new InsertProduct();
            insertProduct.ShowDialog(this);
        }
    }
}
