using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class ShowContractor : Form
    {
        Company contractor;
        SampleDBOperations db = SampleDBOperations.GetInstace();
        public ShowContractor(int comID)
        {
            InitializeComponent();
            contractor = db.CompaniesGetByID(comID);

            FirstNameTextbox.Text = contractor.Name;
            LastNameTextBox.Text = contractor.Street;
            EmailTextBox.Text = contractor.ZipCode;
            PhoneTextBox.Text = contractor.City;
            NipTextBox.Text = contractor.NIP;
        }

        private void insertRecordButton_Click(object sender, EventArgs e)
        {
            string message;
            string caption;
            MessageBoxButtons buttons;
            DialogResult result;

            message = "Czy zmienić dane kontrahenta?";
            caption = "Zmiana danych kontrahenta";
            buttons = MessageBoxButtons.YesNoCancel;
            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Company newcontractor = new Company
                {
                    ID = contractor.ID,
                    Name = FirstNameTextbox.Text,
                    Street = LastNameTextBox.Text,
                    ZipCode = EmailTextBox.Text,
                    City = PhoneTextBox.Text,
                    NIP = NipTextBox.Text
                };
                db.CompaniesUpdateByID(newcontractor);
                this.Close();
            }
            if(result == DialogResult.No)
            {
                this.Close();
            }
        }
    }
}
