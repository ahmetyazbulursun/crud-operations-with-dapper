using DapperCRUD.Models.StoreProcedure;
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
    public partial class UpdateProduct : Form
    {
        int productId;
        public UpdateProduct(int product_id)
        {
            productId = product_id;
            InitializeComponent();
        }

        void GetBrands()
        {
            using (BrandRepository brandRepository = new BrandRepository())
            {
                cmb_brands.DisplayMember = "brand_name";
                cmb_brands.ValueMember = "brand_id";
                cmb_brands.DataSource = brandRepository.GetAllData();
            }
        }

        void GetCategories()
        {
            using (CategoryRepository categoryRepository = new CategoryRepository())
            {
                cmb_categories.DisplayMember = "category_name";
                cmb_categories.ValueMember = "category_id";
                cmb_categories.DataSource = categoryRepository.GetAllData();
            }
        }

        void GetProductById()
        {
            using (ProductRepository productRepository = new ProductRepository())
            {
                var dataItem = productRepository.GetDataById(productId);
                txt_product_name.Text = dataItem.product_name.ToString();
                txt_model_year.Text = dataItem.model_year.ToString();
                txt_list_price.Text = dataItem.list_price.ToString();
                cmb_brands.SelectedValue = dataItem.brand_id;
                cmb_categories.SelectedValue = dataItem.category_id;
            }
        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            GetBrands();
            GetCategories();
            GetProductById();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            using (ProductRepository productRepository = new ProductRepository())
            {
                UpdateProductSP dataItem = new UpdateProductSP();
                dataItem.product_id = productId;
                dataItem.product_name = txt_product_name.Text;
                dataItem.brand_id = (int)cmb_brands.SelectedValue;
                dataItem.category_id = (int)cmb_categories.SelectedValue;
                dataItem.model_year = int.Parse(txt_model_year.Text);
                dataItem.list_price = decimal.Parse(txt_list_price.Text);
                int returnValue = productRepository.UpdateData(dataItem);
                if (returnValue == 0) MessageBox.Show("Ürün Güncellenemedi", "Bilgi");
                else MessageBox.Show("Ürün Güncellendi", "Bilgi");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            using (ProductRepository productRepository = new ProductRepository())
            {
                int returnValue = productRepository.DeleteData(new UpdateProductSP() { product_id = productId });
                if (returnValue > 0) this.Close();
            }
        }
    }
}
