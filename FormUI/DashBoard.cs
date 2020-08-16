using System;
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
        public DashBoard()
        {
            InitializeComponent();
            peopleFoindListBox.DataSource = people;
            peopleFoindListBox.DisplayMember = "FullInfo";

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
            peopleFoindListBox.DataSource = people;
            peopleFoindListBox.DisplayMember = "FullInfo";

            listView1.Items.Clear();


            foreach (var item in people)
            {
                ListViewItem lvi = new ListViewItem(item.data());
                listView1.Items.Add(new ListViewItem(item.data()));
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            people = db.GetPeople(lasnNameTextBox.Text);
            update();
        }

        private void insertRecordButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.insertPerson(addFirstNameTextbox.Text,
                addLastNameTextBox.Text, addEmailTextBox.Text, addPhoneTextBox.Text);
            addFirstNameTextbox.Text = "";
            addLastNameTextBox.Text = "";
            addEmailTextBox.Text = "";
            addPhoneTextBox.Text = "";

        }

        private void RTTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            DataAccess db = new DataAccess();

            people = db.GetPeople(RTTextBox.Text);
            update();
        }
    }
}
