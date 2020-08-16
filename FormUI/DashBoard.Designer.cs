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
            this.peopleFoindListBox = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.addFirstNameTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addLastNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addEmailTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addPhoneTextBox = new System.Windows.Forms.TextBox();
            this.insertRecordButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Emial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RTTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lasnNameTextBox
            // 
            this.lasnNameTextBox.Location = new System.Drawing.Point(110, 123);
            this.lasnNameTextBox.Name = "lasnNameTextBox";
            this.lasnNameTextBox.Size = new System.Drawing.Size(153, 20);
            this.lasnNameTextBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 149);
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
            this.label1.Location = new System.Drawing.Point(46, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last Name";
            // 
            // peopleFoindListBox
            // 
            this.peopleFoindListBox.FormattingEnabled = true;
            this.peopleFoindListBox.Location = new System.Drawing.Point(49, 189);
            this.peopleFoindListBox.Name = "peopleFoindListBox";
            this.peopleFoindListBox.Size = new System.Drawing.Size(214, 225);
            this.peopleFoindListBox.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(49, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Test Connection";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "First Name";
            // 
            // addFirstNameTextbox
            // 
            this.addFirstNameTextbox.Location = new System.Drawing.Point(437, 30);
            this.addFirstNameTextbox.Name = "addFirstNameTextbox";
            this.addFirstNameTextbox.Size = new System.Drawing.Size(153, 20);
            this.addFirstNameTextbox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last Name";
            // 
            // addLastNameTextBox
            // 
            this.addLastNameTextBox.Location = new System.Drawing.Point(437, 67);
            this.addLastNameTextBox.Name = "addLastNameTextBox";
            this.addLastNameTextBox.Size = new System.Drawing.Size(153, 20);
            this.addLastNameTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email Addres";
            // 
            // addEmailTextBox
            // 
            this.addEmailTextBox.Location = new System.Drawing.Point(437, 101);
            this.addEmailTextBox.Name = "addEmailTextBox";
            this.addEmailTextBox.Size = new System.Drawing.Size(153, 20);
            this.addEmailTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "PhoneNumber";
            // 
            // addPhoneTextBox
            // 
            this.addPhoneTextBox.Location = new System.Drawing.Point(437, 136);
            this.addPhoneTextBox.Name = "addPhoneTextBox";
            this.addPhoneTextBox.Size = new System.Drawing.Size(153, 20);
            this.addPhoneTextBox.TabIndex = 11;
            // 
            // insertRecordButton
            // 
            this.insertRecordButton.Location = new System.Drawing.Point(360, 167);
            this.insertRecordButton.Name = "insertRecordButton";
            this.insertRecordButton.Size = new System.Drawing.Size(230, 34);
            this.insertRecordButton.TabIndex = 13;
            this.insertRecordButton.Text = "Insert";
            this.insertRecordButton.UseVisualStyleBackColor = true;
            this.insertRecordButton.Click += new System.EventHandler(this.insertRecordButton_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FirstName,
            this.LastName,
            this.Emial});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(377, 234);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(398, 151);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // FirstName
            // 
            this.FirstName.Text = "First Name";
            this.FirstName.Width = 111;
            // 
            // LastName
            // 
            this.LastName.Text = "Last Name";
            this.LastName.Width = 120;
            // 
            // Emial
            // 
            this.Emial.Text = "Email";
            this.Emial.Width = 147;
            // 
            // RTTextBox
            // 
            this.RTTextBox.Location = new System.Drawing.Point(689, 101);
            this.RTTextBox.Name = "RTTextBox";
            this.RTTextBox.Size = new System.Drawing.Size(100, 20);
            this.RTTextBox.TabIndex = 15;
            this.RTTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RTTextBox_KeyUp);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RTTextBox);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.insertRecordButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addPhoneTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addEmailTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addLastNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addFirstNameTextbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.peopleFoindListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lasnNameTextBox);
            this.Name = "DashBoard";
            this.Text = "SQLDataAccess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lasnNameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox peopleFoindListBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addFirstNameTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addLastNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addEmailTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addPhoneTextBox;
        private System.Windows.Forms.Button insertRecordButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Emial;
        private System.Windows.Forms.TextBox RTTextBox;
    }
}

