namespace FormUI
{
    partial class AddProductToInvoiceForm
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
            this.PnameTextBox = new System.Windows.Forms.TextBox();
            this.PJMtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.PVatTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PnameTextBox
            // 
            this.PnameTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.PnameTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PnameTextBox.Location = new System.Drawing.Point(142, 45);
            this.PnameTextBox.Name = "PnameTextBox";
            this.PnameTextBox.ReadOnly = true;
            this.PnameTextBox.Size = new System.Drawing.Size(227, 20);
            this.PnameTextBox.TabIndex = 0;
            // 
            // PJMtextBox
            // 
            this.PJMtextBox.BackColor = System.Drawing.SystemColors.Info;
            this.PJMtextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PJMtextBox.Location = new System.Drawing.Point(142, 85);
            this.PJMtextBox.Name = "PJMtextBox";
            this.PJMtextBox.ReadOnly = true;
            this.PJMtextBox.Size = new System.Drawing.Size(84, 20);
            this.PJMtextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ilość";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vat";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(142, 231);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.QuantityTextBox.TabIndex = 5;
            this.QuantityTextBox.Leave += new System.EventHandler(this.QuantitiTexBox_Leave);
            // 
            // PVatTextBox
            // 
            this.PVatTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.PVatTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PVatTextBox.Location = new System.Drawing.Point(142, 124);
            this.PVatTextBox.Name = "PVatTextBox";
            this.PVatTextBox.ReadOnly = true;
            this.PVatTextBox.Size = new System.Drawing.Size(84, 20);
            this.PVatTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Jm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nazwa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cena";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(142, 276);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.PriceTextBox.TabIndex = 10;
            this.PriceTextBox.Leave += new System.EventHandler(this.PriceTextBox_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(301, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "Dodaj Do Faktury";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddProductToInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 371);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.PVatTextBox);
            this.Controls.Add(this.PJMtextBox);
            this.Controls.Add(this.PnameTextBox);
            this.Name = "AddProductToInvoiceForm";
            this.Text = "AddProductToInvoiceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PnameTextBox;
        private System.Windows.Forms.TextBox PJMtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.TextBox PVatTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Button button1;
    }
}