namespace FormUI
{
    partial class EditJMForm
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NameUnitTextBox = new System.Windows.Forms.TextBox();
            this.PrecisionComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(99, 125);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Zapisz";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa";
            // 
            // NameUnitTextBox
            // 
            this.NameUnitTextBox.Location = new System.Drawing.Point(89, 23);
            this.NameUnitTextBox.Name = "NameUnitTextBox";
            this.NameUnitTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameUnitTextBox.TabIndex = 2;
            // 
            // PrecisionComboBox
            // 
            this.PrecisionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PrecisionComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PrecisionComboBox.FormattingEnabled = true;
            this.PrecisionComboBox.Location = new System.Drawing.Point(89, 60);
            this.PrecisionComboBox.Name = "PrecisionComboBox";
            this.PrecisionComboBox.Size = new System.Drawing.Size(121, 21);
            this.PrecisionComboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Precyzja";
            // 
            // EditJMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 172);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PrecisionComboBox);
            this.Controls.Add(this.NameUnitTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveButton);
            this.Name = "EditJMForm";
            this.Text = "EditJMForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameUnitTextBox;
        private System.Windows.Forms.ComboBox PrecisionComboBox;
        private System.Windows.Forms.Label label3;
    }
}