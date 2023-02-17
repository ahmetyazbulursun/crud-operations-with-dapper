namespace DapperCRUD.Forms
{
    partial class InsertProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_new_record = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_categories = new System.Windows.Forms.ComboBox();
            this.cmb_brands = new System.Windows.Forms.ComboBox();
            this.txt_list_price = new System.Windows.Forms.TextBox();
            this.txt_model_year = new System.Windows.Forms.TextBox();
            this.txt_product_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_new_record
            // 
            this.btn_new_record.Location = new System.Drawing.Point(81, 194);
            this.btn_new_record.Name = "btn_new_record";
            this.btn_new_record.Size = new System.Drawing.Size(139, 23);
            this.btn_new_record.TabIndex = 18;
            this.btn_new_record.Text = "Yeni Ürün";
            this.btn_new_record.UseVisualStyleBackColor = true;
            this.btn_new_record.Click += new System.EventHandler(this.btn_new_record_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Model Yılı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Kategori";
            // 
            // cmb_categories
            // 
            this.cmb_categories.FormattingEnabled = true;
            this.cmb_categories.Location = new System.Drawing.Point(81, 55);
            this.cmb_categories.Name = "cmb_categories";
            this.cmb_categories.Size = new System.Drawing.Size(139, 21);
            this.cmb_categories.TabIndex = 12;
            // 
            // cmb_brands
            // 
            this.cmb_brands.FormattingEnabled = true;
            this.cmb_brands.Location = new System.Drawing.Point(81, 21);
            this.cmb_brands.Name = "cmb_brands";
            this.cmb_brands.Size = new System.Drawing.Size(139, 21);
            this.cmb_brands.TabIndex = 11;
            // 
            // txt_list_price
            // 
            this.txt_list_price.Location = new System.Drawing.Point(81, 155);
            this.txt_list_price.Name = "txt_list_price";
            this.txt_list_price.Size = new System.Drawing.Size(139, 20);
            this.txt_list_price.TabIndex = 8;
            // 
            // txt_model_year
            // 
            this.txt_model_year.Location = new System.Drawing.Point(81, 122);
            this.txt_model_year.Name = "txt_model_year";
            this.txt_model_year.Size = new System.Drawing.Size(139, 20);
            this.txt_model_year.TabIndex = 9;
            // 
            // txt_product_name
            // 
            this.txt_product_name.Location = new System.Drawing.Point(81, 89);
            this.txt_product_name.Name = "txt_product_name";
            this.txt_product_name.Size = new System.Drawing.Size(139, 20);
            this.txt_product_name.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Marka";
            // 
            // InsertProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 239);
            this.Controls.Add(this.btn_new_record);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_categories);
            this.Controls.Add(this.cmb_brands);
            this.Controls.Add(this.txt_list_price);
            this.Controls.Add(this.txt_model_year);
            this.Controls.Add(this.txt_product_name);
            this.Controls.Add(this.label1);
            this.Name = "InsertProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Ürün";
            this.Load += new System.EventHandler(this.InsertProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_new_record;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_categories;
        private System.Windows.Forms.ComboBox cmb_brands;
        private System.Windows.Forms.TextBox txt_list_price;
        private System.Windows.Forms.TextBox txt_model_year;
        private System.Windows.Forms.TextBox txt_product_name;
        private System.Windows.Forms.Label label1;
    }
}