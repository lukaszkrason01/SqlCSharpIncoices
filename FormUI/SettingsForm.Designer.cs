namespace FormUI
{
    partial class SettingsForm
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
            this.VatRatesListView = new System.Windows.Forms.ListView();
            this.VatRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.JMSListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.PaymentMethodsListView = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ZipCodeTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NIPTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VatRatesListView
            // 
            this.VatRatesListView.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.VatRatesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.VatRate});
            this.VatRatesListView.FullRowSelect = true;
            this.VatRatesListView.GridLines = true;
            this.VatRatesListView.HideSelection = false;
            this.VatRatesListView.LabelEdit = true;
            this.VatRatesListView.Location = new System.Drawing.Point(22, 35);
            this.VatRatesListView.MultiSelect = false;
            this.VatRatesListView.Name = "VatRatesListView";
            this.VatRatesListView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.VatRatesListView.RightToLeftLayout = true;
            this.VatRatesListView.Size = new System.Drawing.Size(103, 158);
            this.VatRatesListView.TabIndex = 0;
            this.VatRatesListView.UseCompatibleStateImageBehavior = false;
            this.VatRatesListView.View = System.Windows.Forms.View.Details;
            this.VatRatesListView.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.VatRatesListView_AfterLabelEdit);
            this.VatRatesListView.DoubleClick += new System.EventHandler(this.VatRatesListView_DoubleClick);
            this.VatRatesListView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.VatRatesListView_KeyUp);
            // 
            // VatRate
            // 
            this.VatRate.Text = "StawkaVAT";
            this.VatRate.Width = 97;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stawki Vat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jednostki miary";
            // 
            // JMSListView
            // 
            this.JMSListView.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.JMSListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.JMSListView.FullRowSelect = true;
            this.JMSListView.GridLines = true;
            this.JMSListView.HideSelection = false;
            this.JMSListView.LabelEdit = true;
            this.JMSListView.Location = new System.Drawing.Point(161, 35);
            this.JMSListView.MultiSelect = false;
            this.JMSListView.Name = "JMSListView";
            this.JMSListView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.JMSListView.RightToLeftLayout = true;
            this.JMSListView.Size = new System.Drawing.Size(166, 158);
            this.JMSListView.TabIndex = 2;
            this.JMSListView.UseCompatibleStateImageBehavior = false;
            this.JMSListView.View = System.Windows.Forms.View.Details;
            this.JMSListView.DoubleClick += new System.EventHandler(this.JMSListView_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 1;
            this.columnHeader1.Text = "Nazwa";
            this.columnHeader1.Width = 97;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 0;
            this.columnHeader2.Text = "Precyzja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sposób płatności";
            // 
            // PaymentMethodsListView
            // 
            this.PaymentMethodsListView.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.PaymentMethodsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.PaymentMethodsListView.FullRowSelect = true;
            this.PaymentMethodsListView.GridLines = true;
            this.PaymentMethodsListView.HideSelection = false;
            this.PaymentMethodsListView.LabelEdit = true;
            this.PaymentMethodsListView.Location = new System.Drawing.Point(22, 254);
            this.PaymentMethodsListView.MultiSelect = false;
            this.PaymentMethodsListView.Name = "PaymentMethodsListView";
            this.PaymentMethodsListView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PaymentMethodsListView.RightToLeftLayout = true;
            this.PaymentMethodsListView.Size = new System.Drawing.Size(103, 158);
            this.PaymentMethodsListView.TabIndex = 4;
            this.PaymentMethodsListView.UseCompatibleStateImageBehavior = false;
            this.PaymentMethodsListView.View = System.Windows.Forms.View.Details;
            this.PaymentMethodsListView.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.PaymentMethodsListView_AfterLabelEdit);
            this.PaymentMethodsListView.DoubleClick += new System.EventHandler(this.PaymentMethodsListView_DoubleClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "StawkaVAT";
            this.columnHeader3.Width = 97;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nazwa";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(264, 271);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(142, 20);
            this.NameTextBox.TabIndex = 7;
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Location = new System.Drawing.Point(264, 297);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(142, 20);
            this.StreetTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ulica";
            // 
            // ZipCodeTextBox
            // 
            this.ZipCodeTextBox.Location = new System.Drawing.Point(264, 325);
            this.ZipCodeTextBox.Name = "ZipCodeTextBox";
            this.ZipCodeTextBox.Size = new System.Drawing.Size(76, 20);
            this.ZipCodeTextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kod pocztowy";
            // 
            // NIPTextBox
            // 
            this.NIPTextBox.Location = new System.Drawing.Point(264, 375);
            this.NIPTextBox.Name = "NIPTextBox";
            this.NIPTextBox.Size = new System.Drawing.Size(100, 20);
            this.NIPTextBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "NIP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(240, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Dane Firmy";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(264, 349);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(142, 20);
            this.CityTextBox.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(188, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Miasto";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(243, 427);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 17;
            this.Save.Text = "Zapisz";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 462);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NIPTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ZipCodeTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.StreetTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PaymentMethodsListView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.JMSListView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VatRatesListView);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView VatRatesListView;
        private System.Windows.Forms.ColumnHeader VatRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView JMSListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView PaymentMethodsListView;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ZipCodeTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NIPTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Save;
    }
}