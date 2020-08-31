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
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.JMSListView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VatRatesListView);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
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
    }
}