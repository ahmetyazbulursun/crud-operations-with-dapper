﻿namespace DapperCRUD.Forms
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grd_products = new System.Windows.Forms.DataGridView();
            this.btn_new_record = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_products)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grd_products);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürünler";
            // 
            // grd_products
            // 
            this.grd_products.AllowUserToAddRows = false;
            this.grd_products.AllowUserToDeleteRows = false;
            this.grd_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_products.Location = new System.Drawing.Point(3, 16);
            this.grd_products.Name = "grd_products";
            this.grd_products.ReadOnly = true;
            this.grd_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_products.Size = new System.Drawing.Size(702, 407);
            this.grd_products.TabIndex = 1;
            this.grd_products.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_products_CellDoubleClick);
            // 
            // btn_new_record
            // 
            this.btn_new_record.Location = new System.Drawing.Point(15, 444);
            this.btn_new_record.Name = "btn_new_record";
            this.btn_new_record.Size = new System.Drawing.Size(702, 41);
            this.btn_new_record.TabIndex = 2;
            this.btn_new_record.Text = "Yeni Kayıt";
            this.btn_new_record.UseVisualStyleBackColor = true;
            this.btn_new_record.Click += new System.EventHandler(this.btn_new_record_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 493);
            this.Controls.Add(this.btn_new_record);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_products)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grd_products;
        private System.Windows.Forms.Button btn_new_record;
    }
}