namespace FormUI
{
    partial class ShowProducts
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Names = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.JM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VATrate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RTSearch = new System.Windows.Forms.TextBox();
            this.ShowDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Names,
            this.JM,
            this.VATrate,
            this.LastPrice});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 132);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(439, 265);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.SortingListView);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // Names
            // 
            this.Names.Text = "Nazwa";
            this.Names.Width = 192;
            // 
            // JM
            // 
            this.JM.Text = "J.m";
            this.JM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.JM.Width = 50;
            // 
            // VATrate
            // 
            this.VATrate.Text = "Stawka Vat";
            this.VATrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.VATrate.Width = 70;
            // 
            // LastPrice
            // 
            this.LastPrice.Text = "Cena netto";
            this.LastPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.LastPrice.Width = 93;
            // 
            // AddProduct
            // 
            this.AddProduct.Location = new System.Drawing.Point(25, 35);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(179, 38);
            this.AddProduct.TabIndex = 1;
            this.AddProduct.Text = "Dodaj Nowy Produkt";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wyszukaj";
            // 
            // RTSearch
            // 
            this.RTSearch.Location = new System.Drawing.Point(86, 408);
            this.RTSearch.Name = "RTSearch";
            this.RTSearch.Size = new System.Drawing.Size(365, 20);
            this.RTSearch.TabIndex = 3;
            this.RTSearch.TextChanged += new System.EventHandler(this.RTSearch_TextChanged);
            this.RTSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RTSearch_KeyUp);
            // 
            // ShowDetails
            // 
            this.ShowDetails.Location = new System.Drawing.Point(241, 35);
            this.ShowDetails.Name = "ShowDetails";
            this.ShowDetails.Size = new System.Drawing.Size(193, 38);
            this.ShowDetails.TabIndex = 4;
            this.ShowDetails.Text = "Wyświetl Produkt";
            this.ShowDetails.UseVisualStyleBackColor = true;
            this.ShowDetails.Click += new System.EventHandler(this.ShowDetails_Click);
            // 
            // ShowProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 450);
            this.Controls.Add(this.ShowDetails);
            this.Controls.Add(this.RTSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.listView1);
            this.Name = "ShowProducts";
            this.Text = "Produkty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Names;
        private System.Windows.Forms.ColumnHeader JM;
        private System.Windows.Forms.ColumnHeader VATrate;
        private System.Windows.Forms.ColumnHeader LastPrice;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RTSearch;
        private System.Windows.Forms.Button ShowDetails;
    }
}