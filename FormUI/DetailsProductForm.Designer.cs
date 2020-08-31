namespace FormUI
{
    partial class DetailsProductForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.JMComboBox = new System.Windows.Forms.ComboBox();
            this.VATComboBox = new System.Windows.Forms.ComboBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(137, 40);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(121, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "JM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Starwkla VAT";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(137, 160);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(121, 20);
            this.PriceTextBox.TabIndex = 7;
            this.PriceTextBox.Leave += new System.EventHandler(this.PriceTextBox_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cena";
            // 
            // JMComboBox
            // 
            this.JMComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JMComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.JMComboBox.FormattingEnabled = true;
            this.JMComboBox.Location = new System.Drawing.Point(137, 81);
            this.JMComboBox.Name = "JMComboBox";
            this.JMComboBox.Size = new System.Drawing.Size(121, 21);
            this.JMComboBox.TabIndex = 10;
            // 
            // VATComboBox
            // 
            this.VATComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.VATComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VATComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VATComboBox.FormattingEnabled = true;
            this.VATComboBox.Location = new System.Drawing.Point(137, 121);
            this.VATComboBox.Name = "VATComboBox";
            this.VATComboBox.Size = new System.Drawing.Size(121, 21);
            this.VATComboBox.TabIndex = 11;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(58, 205);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(200, 32);
            this.UpdateButton.TabIndex = 12;
            this.UpdateButton.Text = "Zapisz";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DetailsProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 264);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.VATComboBox);
            this.Controls.Add(this.JMComboBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "DetailsProductForm";
            this.Text = "DetailsProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox JMComboBox;
        private System.Windows.Forms.ComboBox VATComboBox;
        private System.Windows.Forms.Button UpdateButton;
    }
}