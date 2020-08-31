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
    public partial class AddContractor : Form
    {
        private SampleDBOperations db = SampleDBOperations.GetInstace();
        public AddContractor()
        {
            InitializeComponent();
        }

        private void insertRecordButton_Click(object sender, EventArgs e)
        {
            string message;
            string caption;
            MessageBoxButtons buttons;
            DialogResult result;

            string nip = NipTextBox.Text;
            nip = Helper.makeGoodNIP(nip);

            bool isName = NameTextbox.Text.Length != 0;
            bool isNip = (NipTextBox.Text.Length == 0) || Helper.IsValidNIP(nip);
            bool isZipCode = (ZipCodeTextBox.Text.Length == 0) || Helper.IsValidZipCode(ZipCodeTextBox.Text);

            if (isName && isNip && isZipCode)
            {
                message = "Czy dodać kontrahenta?";
                caption = "Dodawanie kontrahenta";
                buttons = MessageBoxButtons.YesNo;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                    Company newCompany = new Company
                    {
                        Name = NameTextbox.Text,
                        Street = StreetTextBox.Text,
                        ZipCode = ZipCodeTextBox.Text,
                        City = CityTextBox.Text,
                        NIP = nip,
                    };

                    db.CompaniesInsert(newCompany);
                    // Closes the parent form.
                    this.Close();
                }
            }
                
            if (!isName)
            {
                message = "Wypełnij co najmniej nazwę kontrahenta";
                caption = "Brak danych";
                buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
            else if(!isNip)
            {
                message = "Wpisany Nip jest nieprawidłowy";
                caption = "Błędny NIP";
                buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
            else if (!isZipCode)
            {
                message = "Wpisany kod pocztowy jest nieprawidłowy";
                caption = "Błędny kod pocztowy";
                buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
        }
    }
}
