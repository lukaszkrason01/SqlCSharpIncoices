namespace FormUI
{
    partial class InvoiceForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ShowInvoice = new System.Windows.Forms.Button();
            this.AddInvoiceButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.InviceNr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CompanyNames = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Term = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PaymentMethod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalNetAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalVatAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalBrtAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatesComboBox = new System.Windows.Forms.ComboBox();
            this.DeleteInvoiceButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DeleteInvoiceButton);
            this.panel1.Controls.Add(this.StatesComboBox);
            this.panel1.Controls.Add(this.ShowInvoice);
            this.panel1.Controls.Add(this.AddInvoiceButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 416);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 52);
            this.panel1.TabIndex = 0;
            // 
            // ShowInvoice
            // 
            this.ShowInvoice.Location = new System.Drawing.Point(136, 7);
            this.ShowInvoice.Name = "ShowInvoice";
            this.ShowInvoice.Size = new System.Drawing.Size(132, 33);
            this.ShowInvoice.TabIndex = 1;
            this.ShowInvoice.Text = "Przeglądaj Fakturę";
            this.ShowInvoice.UseVisualStyleBackColor = true;
            this.ShowInvoice.Click += new System.EventHandler(this.ShowInvoice_Click);
            // 
            // AddInvoiceButton
            // 
            this.AddInvoiceButton.Location = new System.Drawing.Point(12, 7);
            this.AddInvoiceButton.Name = "AddInvoiceButton";
            this.AddInvoiceButton.Size = new System.Drawing.Size(100, 33);
            this.AddInvoiceButton.TabIndex = 0;
            this.AddInvoiceButton.Text = "Dodaj Fakture";
            this.AddInvoiceButton.UseVisualStyleBackColor = true;
            this.AddInvoiceButton.Click += new System.EventHandler(this.AddInvoiceButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(868, 416);
            this.panel2.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.InviceNr,
            this.CompanyNames,
            this.Date,
            this.Term,
            this.PaymentMethod,
            this.TotalNetAmount,
            this.TotalVatAmount,
            this.TotalBrtAmount});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(868, 416);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // InviceNr
            // 
            this.InviceNr.Text = "Nr Faktury";
            this.InviceNr.Width = 120;
            // 
            // CompanyNames
            // 
            this.CompanyNames.Text = "Firma";
            this.CompanyNames.Width = 120;
            // 
            // Date
            // 
            this.Date.Text = "Data wystawienia";
            this.Date.Width = 100;
            // 
            // Term
            // 
            this.Term.Text = "Termin do";
            this.Term.Width = 100;
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.Text = "Sposób Platności";
            this.PaymentMethod.Width = 120;
            // 
            // TotalNetAmount
            // 
            this.TotalNetAmount.Text = "Wartość Netto";
            this.TotalNetAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TotalNetAmount.Width = 100;
            // 
            // TotalVatAmount
            // 
            this.TotalVatAmount.Text = "Wartość VAT";
            this.TotalVatAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TotalVatAmount.Width = 100;
            // 
            // TotalBrtAmount
            // 
            this.TotalBrtAmount.Text = "Wartośc Brutto";
            this.TotalBrtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TotalBrtAmount.Width = 100;
            // 
            // StatesComboBox
            // 
            this.StatesComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.StatesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatesComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StatesComboBox.FormattingEnabled = true;
            this.StatesComboBox.Location = new System.Drawing.Point(702, 14);
            this.StatesComboBox.Name = "StatesComboBox";
            this.StatesComboBox.Size = new System.Drawing.Size(121, 21);
            this.StatesComboBox.TabIndex = 2;
            this.StatesComboBox.SelectedIndexChanged += new System.EventHandler(this.StatesComboBox_SelectedIndexChanged);
            // 
            // DeleteInvoiceButton
            // 
            this.DeleteInvoiceButton.Location = new System.Drawing.Point(293, 7);
            this.DeleteInvoiceButton.Name = "DeleteInvoiceButton";
            this.DeleteInvoiceButton.Size = new System.Drawing.Size(112, 33);
            this.DeleteInvoiceButton.TabIndex = 3;
            this.DeleteInvoiceButton.Text = "Usuń Fakturę";
            this.DeleteInvoiceButton.UseVisualStyleBackColor = true;
            this.DeleteInvoiceButton.Click += new System.EventHandler(this.DeleteInvoiceButton_Click);
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 468);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "InvoiceForm";
            this.Text = "InvoiceForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader InviceNr;
        private System.Windows.Forms.ColumnHeader CompanyNames;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Term;
        private System.Windows.Forms.ColumnHeader PaymentMethod;
        private System.Windows.Forms.ColumnHeader TotalNetAmount;
        private System.Windows.Forms.ColumnHeader TotalVatAmount;
        private System.Windows.Forms.ColumnHeader TotalBrtAmount;
        private System.Windows.Forms.Button ShowInvoice;
        private System.Windows.Forms.Button AddInvoiceButton;
        private System.Windows.Forms.ComboBox StatesComboBox;
        private System.Windows.Forms.Button DeleteInvoiceButton;
    }
}