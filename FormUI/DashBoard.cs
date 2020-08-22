﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FormUI
{
    public partial class DashBoard : Form
    {
        private ListViewColumnSorter lvwColumnSorter;
        List<Company> Companies { get; set; }
        int column = 1;
        Invoice theInvoice = null;

        public DashBoard()
        {

            InitializeComponent();

            lvwColumnSorter = new ListViewColumnSorter();
            this.listView1.ListViewItemSorter = lvwColumnSorter;

            Companies = new DBAccesCompanies().GetAll();
            update();
            this.listView1.Sort();
        }
        public DashBoard(Invoice invoice) : this()
        {
            this.theInvoice = invoice;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = Helper.ConVal("SampleDB");
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            MessageBox.Show("Connection Open  !");
            cnn.Close();
        }

        private void update()
        {
            listView1.Items.Clear();
            if (Companies == null) return;

            foreach (var item in Companies)
            {
                ListViewItem lvi = new ListViewItem(item.GetData());
                lvi.Tag = item;
                listView1.Items.Add(lvi);

            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            Companies = DataAccessGetCompanies.selectByColumnNumber(column,  lasnNameTextBox.Text);
            update();
        }

        private void insertRecordButton_Click(object sender, EventArgs e)
        {

        }

        private void RTTextBox_KeyUp(object sender, KeyEventArgs e)
        {

            if (RTTextBox.Text == "") Companies = new DBAccesCompanies().GetAll();
            else Companies = DataAccessGetCompanies.selectByColumnNumber(column, RTTextBox.Text);
            update();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddContractor form = new AddContractor();
            form.FormClosed += NewProjectForm_FormClosed;
            form.Show();
        }

        private void NewProjectForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            ////will run when new form is closed
            Companies = new DBAccesCompanies().GetAll();
            update();
        }

        private void SortingListView(object sender, ColumnClickEventArgs e)
        {
            
            column = e.Column + 1;
            /*            RTTextBox.Text = "";
                      DataAccess db = new DataAccess();
                       Companies = db.getCompanies();
                       update();
                       this.Text = e.Column.ToString();*/

            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order ==System.Windows.Forms.SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = System.Windows.Forms.SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = System.Windows.Forms.SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = System.Windows.Forms.SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.listView1.Sort();
        }

        private void ShowContractorButton_Click(object sender, EventArgs e)
        {
            showContractorForm();
        }

        private void showContractorForm()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Company var3 = (Company)listView1.SelectedItems[0].Tag;
                ShowContractor form = new ShowContractor(var3.ID);
                form.FormClosed += NewProjectForm_FormClosed;
                form.Show();
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            theInvoice.CompanyID = ((Company)listView1.SelectedItems[0].Tag).ID;
            this.Close();
        }

        private void showMyData_Click(object sender, EventArgs e)
        {
            ShowContractor form = new ShowContractor(1);
            form.FormClosed += NewProjectForm_FormClosed;
            form.Show();
        }

        private void IssueInvoice_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Company var3 = (Company)listView1.SelectedItems[0].Tag;
                InvoiceDetailsForm form = new InvoiceDetailsForm(null,var3);
                form.Show();
            }
        }

        private void AddCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AddProductToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DetailsProductForm form = new DetailsProductForm(0);
            form.FormClosed += NewProjectForm_FormClosed;
            form.Show();
        }

        private void przegladajToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowProducts form = new ShowProducts();
            form.Show();
        }

        private void showIvnoice_Click(object sender, EventArgs e)
        {

        }
    }
}
