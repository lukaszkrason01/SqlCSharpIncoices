namespace FormUI
{
    partial class DashBoard
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
            this.lasnNameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
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
            this.Resultlabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.showMyData = new System.Windows.Forms.Button();
            this.IssueInvoice = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.asdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddInvoide = new System.Windows.Forms.ToolStripMenuItem();
            this.showIvnoice = new System.Windows.Forms.ToolStripMenuItem();
            this.produktyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddProcutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.przegladajToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaVATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jednostkiMiaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lasnNameTextBox
            // 
            this.lasnNameTextBox.Location = new System.Drawing.Point(895, 208);
            this.lasnNameTextBox.Name = "lasnNameTextBox";
            this.lasnNameTextBox.Size = new System.Drawing.Size(153, 20);
            this.lasnNameTextBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(895, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(831, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last Name";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(986, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Test Connection";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // Resultlabel
            // 
            this.Resultlabel.AutoSize = true;
            this.Resultlabel.Location = new System.Drawing.Point(853, 291);
            this.Resultlabel.Name = "Resultlabel";
            this.Resultlabel.Size = new System.Drawing.Size(35, 13);
            this.Resultlabel.TabIndex = 19;
            this.Resultlabel.Text = "label3";
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
            // showMyData
            // 
            this.showMyData.Location = new System.Drawing.Point(796, 307);
            this.showMyData.Name = "showMyData";
            this.showMyData.Size = new System.Drawing.Size(192, 30);
            this.showMyData.TabIndex = 21;
            this.showMyData.Text = "Wyswitl moje dane";
            this.showMyData.UseVisualStyleBackColor = true;
            this.showMyData.Click += new System.EventHandler(this.showMyData_Click);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdToolStripMenuItem,
            this.produktyToolStripMenuItem,
            this.ustawieniaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(992, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // asdToolStripMenuItem
            // 
            this.asdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddInvoide,
            this.showIvnoice});
            this.asdToolStripMenuItem.Name = "asdToolStripMenuItem";
            this.asdToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.asdToolStripMenuItem.Text = "Faktury";
            // 
            // AddInvoide
            // 
            this.AddInvoide.Name = "AddInvoide";
            this.AddInvoide.Size = new System.Drawing.Size(170, 22);
            this.AddInvoide.Text = "Dodaj Fakturę";
            // 
            // showIvnoice
            // 
            this.showIvnoice.Name = "showIvnoice";
            this.showIvnoice.Size = new System.Drawing.Size(170, 22);
            this.showIvnoice.Text = "Przeglądaj Faktury";
            this.showIvnoice.Click += new System.EventHandler(this.showIvnoice_Click);
            // 
            // produktyToolStripMenuItem
            // 
            this.produktyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddProcutToolStripMenuItem1,
            this.przegladajToolStripMenuItem1});
            this.produktyToolStripMenuItem.Name = "produktyToolStripMenuItem";
            this.produktyToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.produktyToolStripMenuItem.Text = "Produkty";
            // 
            // AddProcutToolStripMenuItem1
            // 
            this.AddProcutToolStripMenuItem1.Name = "AddProcutToolStripMenuItem1";
            this.AddProcutToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.AddProcutToolStripMenuItem1.Text = "Dodaj";
            this.AddProcutToolStripMenuItem1.Click += new System.EventHandler(this.AddProductToolStripMenuItem1_Click);
            // 
            // przegladajToolStripMenuItem1
            // 
            this.przegladajToolStripMenuItem1.Name = "przegladajToolStripMenuItem1";
            this.przegladajToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.przegladajToolStripMenuItem1.Text = "Przegladaj";
            this.przegladajToolStripMenuItem1.Click += new System.EventHandler(this.przegladajToolStripMenuItem1_Click);
            // 
            // ustawieniaToolStripMenuItem
            // 
            this.ustawieniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabelaVATToolStripMenuItem,
            this.jednostkiMiaryToolStripMenuItem});
            this.ustawieniaToolStripMenuItem.Name = "ustawieniaToolStripMenuItem";
            this.ustawieniaToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.ustawieniaToolStripMenuItem.Text = "Ustawienia";
            // 
            // tabelaVATToolStripMenuItem
            // 
            this.tabelaVATToolStripMenuItem.Name = "tabelaVATToolStripMenuItem";
            this.tabelaVATToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tabelaVATToolStripMenuItem.Text = "Tabela VAT";
            this.tabelaVATToolStripMenuItem.Click += new System.EventHandler(this.tabelaVATToolStripMenuItem_Click);
            // 
            // jednostkiMiaryToolStripMenuItem
            // 
            this.jednostkiMiaryToolStripMenuItem.Name = "jednostkiMiaryToolStripMenuItem";
            this.jednostkiMiaryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jednostkiMiaryToolStripMenuItem.Text = "Jednostki miary";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 462);
            this.Controls.Add(this.IssueInvoice);
            this.Controls.Add(this.showMyData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Resultlabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ShowContractorButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.RTTextBox);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lasnNameTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashBoard";
            this.Text = "SQLDataAccess";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lasnNameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Emial;
        private System.Windows.Forms.TextBox RTTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ShowContractorButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Resultlabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button showMyData;
        private System.Windows.Forms.Button IssueInvoice;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddInvoide;
        private System.Windows.Forms.ToolStripMenuItem showIvnoice;
        private System.Windows.Forms.ToolStripMenuItem produktyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddProcutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem przegladajToolStripMenuItem1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelaVATToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jednostkiMiaryToolStripMenuItem;
    }
}

