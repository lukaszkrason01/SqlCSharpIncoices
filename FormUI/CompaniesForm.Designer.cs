namespace FormUI
{
    partial class CompaniesForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Emial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RTTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.ShowContractorButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IssueInvoice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FirstName,
            this.LastName,
            this.Emial,
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 43);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(754, 330);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.SortingListView);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // FirstName
            // 
            this.FirstName.Text = "Nazwa";
            this.FirstName.Width = 175;
            // 
            // LastName
            // 
            this.LastName.Text = "Ulica";
            this.LastName.Width = 132;
            // 
            // Emial
            // 
            this.Emial.Text = "Kod Pocztowy";
            this.Emial.Width = 80;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Miasto";
            this.columnHeader1.Width = 211;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NIP";
            this.columnHeader2.Width = 146;
            // 
            // RTTextBox
            // 
            this.RTTextBox.Location = new System.Drawing.Point(149, 390);
            this.RTTextBox.Name = "RTTextBox";
            this.RTTextBox.Size = new System.Drawing.Size(395, 20);
            this.RTTextBox.TabIndex = 15;
            this.RTTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RTTextBox_KeyUp);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(35, 419);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 30);
            this.button3.TabIndex = 16;
            this.button3.Text = "Dodaj Kontrahenta";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ShowContractorButton
            // 
            this.ShowContractorButton.Location = new System.Drawing.Point(214, 419);
            this.ShowContractorButton.Name = "ShowContractorButton";
            this.ShowContractorButton.Size = new System.Drawing.Size(115, 30);
            this.ShowContractorButton.TabIndex = 17;
            this.ShowContractorButton.Text = "Wyświetl";
            this.ShowContractorButton.UseVisualStyleBackColor = true;
            this.ShowContractorButton.Click += new System.EventHandler(this.ShowContractorButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Wyszukaj";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Wybierz Kontrahenta";
            // 
            // IssueInvoice
            // 
            this.IssueInvoice.Location = new System.Drawing.Point(352, 417);
            this.IssueInvoice.Name = "IssueInvoice";
            this.IssueInvoice.Size = new System.Drawing.Size(192, 32);
            this.IssueInvoice.TabIndex = 22;
            this.IssueInvoice.Text = "Wystaw Fakturę";
            this.IssueInvoice.UseVisualStyleBackColor = true;
            this.IssueInvoice.Click += new System.EventHandler(this.IssueInvoice_Click);
            // 
            // CompaniesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 464);
            this.Controls.Add(this.IssueInvoice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ShowContractorButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.RTTextBox);
            this.Controls.Add(this.listView1);
            this.Name = "CompaniesForm";
            this.Text = "SQLDataAccess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Emial;
        private System.Windows.Forms.TextBox RTTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ShowContractorButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button IssueInvoice;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

