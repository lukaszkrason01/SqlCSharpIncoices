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
            this.RTTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.ShowContractorButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Resultlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lasnNameTextBox
            // 
            this.lasnNameTextBox.Location = new System.Drawing.Point(622, 164);
            this.lasnNameTextBox.Name = "lasnNameTextBox";
            this.lasnNameTextBox.Size = new System.Drawing.Size(153, 20);
            this.lasnNameTextBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(628, 66);
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
            this.label1.Location = new System.Drawing.Point(558, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last Name";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 325);
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
            this.Emial});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(31, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(509, 479);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.SortingListView);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
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
            this.RTTextBox.Location = new System.Drawing.Point(145, 497);
            this.RTTextBox.Name = "RTTextBox";
            this.RTTextBox.Size = new System.Drawing.Size(395, 20);
            this.RTTextBox.TabIndex = 15;
            this.RTTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RTTextBox_KeyUp);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(31, 526);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 30);
            this.button3.TabIndex = 16;
            this.button3.Text = "Dodaj Kontrahenta";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ShowContractorButton
            // 
            this.ShowContractorButton.Location = new System.Drawing.Point(210, 526);
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
            this.label2.Location = new System.Drawing.Point(86, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Wyszukaj";
            // 
            // Resultlabel
            // 
            this.Resultlabel.AutoSize = true;
            this.Resultlabel.Location = new System.Drawing.Point(580, 247);
            this.Resultlabel.Name = "Resultlabel";
            this.Resultlabel.Size = new System.Drawing.Size(35, 13);
            this.Resultlabel.TabIndex = 19;
            this.Resultlabel.Text = "label3";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 575);
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
            this.Name = "DashBoard";
            this.Text = "SQLDataAccess";
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
    }
}

