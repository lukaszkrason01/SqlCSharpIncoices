using System;
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

namespace FormUI
{
    public partial class DashBoard : Form
    {
        List<People> people = new List<People>();
        int columnToSearch = 0;

        public DashBoard()
        {
            InitializeComponent();

            DataAccess db = new DataAccess();

            people = db.GetPeople();
            update();
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
            if (people == null) return;

            foreach (var item in people)
            {
                ListViewItem lvi = new ListViewItem(item.data());
                lvi.Tag = item;
                listView1.Items.Add(lvi);

            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            people = db.GetPeople(lasnNameTextBox.Text, columnToSearch);
            update();
        }

        private void insertRecordButton_Click(object sender, EventArgs e)
        {

        }

        private void RTTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            DataAccess db = new DataAccess();
            if (RTTextBox.Text == "") people = db.GetPeople();
            else people = db.GetPeople(RTTextBox.Text, columnToSearch);
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
            DataAccess db = new DataAccess();
            people = db.GetPeople();
            update();
        }

        private void SortingListView(object sender, ColumnClickEventArgs e)
        {
            columnToSearch = e.Column;
            RTTextBox.Text = "";
            DataAccess db = new DataAccess();
            people = db.GetPeople();
            update();
            this.Text = e.Column.ToString();
            /// <summary>
            /// code from http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/ListViewSorter.htm
            /// </summary>
            ListViewItemComparer sorter = listView1.ListViewItemSorter as ListViewItemComparer;

            if (sorter == null)
            {
                sorter = new ListViewItemComparer(e.Column);
                listView1.ListViewItemSorter = sorter;
            }
            else
            {
                sorter.Column = e.Column;
            }

            listView1.Sort();
        }

        private void ShowContractorButton_Click(object sender, EventArgs e)
        {
            showContractorForm();
        }

        private void showContractorForm()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                People var3 = (People)listView1.SelectedItems[0].Tag;
                ShowContractor form = new ShowContractor(var3.ID);
                form.FormClosed += NewProjectForm_FormClosed;
                form.Show();
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            showContractorForm();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void showMyData_Click(object sender, EventArgs e)
        {
            ShowContractor form = new ShowContractor(1);
            form.FormClosed += NewProjectForm_FormClosed;
            form.Show();
        }

        private void IssueInvoice_Click(object sender, EventArgs e)
        {

        }
    }

    /// <summary>
    /// code from http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/ListViewSorter.htm
    /// </summary>
    public class ListViewItemComparer : IComparer
    {
        private int column;
        private bool numeric = false;

        public int Column
        {
            get { return column; }
            set { column = value; }
        }

        public bool Numeric
        {
            get { return numeric; }
            set { numeric = value; }
        }

        public ListViewItemComparer(int columnIndex)
        {
            Column = columnIndex;
        }

        public int Compare(object x, object y)
        {
            ListViewItem itemX = x as ListViewItem;
            ListViewItem itemY = y as ListViewItem;

            if (itemX == null && itemY == null)
                return 0;
            else if (itemX == null)
                return -1;
            else if (itemY == null)
                return 1;

            if (itemX == itemY) return 0;

            if (Numeric)
            {
                decimal itemXVal, itemYVal;

                if (!Decimal.TryParse(itemX.SubItems[Column].Text, out itemXVal))
                {
                    itemXVal = 0;
                }
                if (!Decimal.TryParse(itemY.SubItems[Column].Text, out itemYVal))
                {
                    itemYVal = 0;
                }

                return Decimal.Compare(itemXVal, itemYVal);
            }
            else
            {
                string itemXText = itemX.SubItems[Column].Text;
                string itemYText = itemY.SubItems[Column].Text;

                return String.Compare(itemXText, itemYText);
            }
        }
    }
}
