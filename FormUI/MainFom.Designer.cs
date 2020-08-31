namespace FormUI
{
    partial class MainFom
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
            this.ShowInvoicesButton = new System.Windows.Forms.Button();
            this.ShowProductsButton = new System.Windows.Forms.Button();
            this.ShowCompaniesButton = new System.Windows.Forms.Button();
            this.AddNewInvoice = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowInvoicesButton
            // 
            this.ShowInvoicesButton.Location = new System.Drawing.Point(161, 85);
            this.ShowInvoicesButton.Name = "ShowInvoicesButton";
            this.ShowInvoicesButton.Size = new System.Drawing.Size(112, 37);
            this.ShowInvoicesButton.TabIndex = 0;
            this.ShowInvoicesButton.Text = "Przeglądaj Faktury";
            this.ShowInvoicesButton.UseVisualStyleBackColor = true;
            this.ShowInvoicesButton.Click += new System.EventHandler(this.ShowInvoicesButton_Click);
            // 
            // ShowProductsButton
            // 
            this.ShowProductsButton.Location = new System.Drawing.Point(161, 182);
            this.ShowProductsButton.Name = "ShowProductsButton";
            this.ShowProductsButton.Size = new System.Drawing.Size(112, 34);
            this.ShowProductsButton.TabIndex = 1;
            this.ShowProductsButton.Text = "Pokaż produkty";
            this.ShowProductsButton.UseVisualStyleBackColor = true;
            this.ShowProductsButton.Click += new System.EventHandler(this.ShowProduccts_Click);
            // 
            // ShowCompaniesButton
            // 
            this.ShowCompaniesButton.Location = new System.Drawing.Point(161, 247);
            this.ShowCompaniesButton.Name = "ShowCompaniesButton";
            this.ShowCompaniesButton.Size = new System.Drawing.Size(112, 38);
            this.ShowCompaniesButton.TabIndex = 2;
            this.ShowCompaniesButton.Text = "Pokaż Firmy";
            this.ShowCompaniesButton.UseVisualStyleBackColor = true;
            this.ShowCompaniesButton.Click += new System.EventHandler(this.ShowCompaniesButton_Click);
            // 
            // AddNewInvoice
            // 
            this.AddNewInvoice.Location = new System.Drawing.Point(161, 129);
            this.AddNewInvoice.Name = "AddNewInvoice";
            this.AddNewInvoice.Size = new System.Drawing.Size(112, 35);
            this.AddNewInvoice.TabIndex = 3;
            this.AddNewInvoice.Text = "Nowa Faktura";
            this.AddNewInvoice.UseVisualStyleBackColor = true;
            this.AddNewInvoice.Click += new System.EventHandler(this.AddNewInvoice_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(546, 139);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(112, 43);
            this.SettingsButton.TabIndex = 4;
            this.SettingsButton.Text = "Ustawienia";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // MainFom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.AddNewInvoice);
            this.Controls.Add(this.ShowCompaniesButton);
            this.Controls.Add(this.ShowProductsButton);
            this.Controls.Add(this.ShowInvoicesButton);
            this.Name = "MainFom";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowInvoicesButton;
        private System.Windows.Forms.Button ShowProductsButton;
        private System.Windows.Forms.Button ShowCompaniesButton;
        private System.Windows.Forms.Button AddNewInvoice;
        private System.Windows.Forms.Button SettingsButton;
    }
}