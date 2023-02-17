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
using System.Windows.Forms.VisualStyles;

namespace DapperCRUD.Forms
{
    public partial class InsertProduct : Form
    {
        public InsertProduct()
        {
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

        private void InsertProduct_Load(object sender, EventArgs e)
        {
            GetBrands();
            GetCategories();
        }

        private void btn_new_record_Click(object sender, EventArgs e)
        {
            using (ProductRepository productRepository = new ProductRepository())
            {
                UpdateProductSP dataItem = new UpdateProductSP();
                dataItem.product_name = txt_product_name.Text;
                dataItem.model_year = int.Parse(txt_model_year.Text);
                dataItem.list_price = decimal.Parse(txt_list_price.Text);
                dataItem.brand_id = (int)cmb_brands.SelectedValue;
                dataItem.category_id = (int)cmb_categories.SelectedValue;

                int returnValue = productRepository.InsertData(dataItem);
                if (returnValue > 0) MessageBox.Show("Ürün Eklendi", "Bilgi");
                else MessageBox.Show("Ürün Eklenemedi", "Bilgi");
            }
        }
    }
}
