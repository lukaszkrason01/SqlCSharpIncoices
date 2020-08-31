namespace FormUI
{
    partial class AddContractor
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
            this.insertRecordButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ZipCodeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NipTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // insertRecordButton
            // 
            this.insertRecordButton.Location = new System.Drawing.Point(51, 215);
            this.insertRecordButton.Name = "insertRecordButton";
            this.insertRecordButton.Size = new System.Drawing.Size(230, 34);
            this.insertRecordButton.TabIndex = 22;
            this.insertRecordButton.Text = "Insert";
            this.insertRecordButton.UseVisualStyleBackColor = true;
            this.insertRecordButton.Click += new System.EventHandler(this.insertRecordButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Miasto";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(128, 144);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(153, 20);
            this.CityTextBox.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Kod pocztowy";
            // 
            // ZipCodeTextBox
            // 
            this.ZipCodeTextBox.Location = new System.Drawing.Point(128, 109);
            this.ZipCodeTextBox.Name = "ZipCodeTextBox";
            this.ZipCodeTextBox.Size = new System.Drawing.Size(153, 20);
            this.ZipCodeTextBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ulica";
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Location = new System.Drawing.Point(128, 75);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(153, 20);
            this.StreetTextBox.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nazwa";
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(128, 38);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(153, 20);
            this.NameTextbox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "NIP";
            // 
            // NipTextBox
            // 
            this.NipTextBox.Location = new System.Drawing.Point(128, 179);
            this.NipTextBox.Name = "NipTextBox";
            this.NipTextBox.Size = new System.Drawing.Size(153, 20);
            this.NipTextBox.TabIndex = 23;
            // 
            // AddContractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 281);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NipTextBox);
            this.Controls.Add(this.insertRecordButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ZipCodeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StreetTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTextbox);
            this.Name = "AddContractor";
            this.Text = "AddContractor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insertRecordButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ZipCodeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NipTextBox;
    }
}