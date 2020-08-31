using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class SettingsForm : Form
    {
        private SampleDBOperations db = SampleDBOperations.GetInstace();

        bool isEdit = false;
        string oldValue;

        List<VatRates> vatrates;
        HashSet<int> VATRateHashSet = new HashSet<int>();

        List<JM> JMS;

        List<PaymentMethod> paymentMethods;

        Dictionary<string, string> CompanyInfo;
        static string directory = Directory.GetCurrentDirectory();
        static string path = directory + "\\settings\\settings.ini";

        public SettingsForm()
        {
            InitializeComponent();

            UpdateVatRateListView();
            UpdateJMSListView();
            UpdatePaymetMethodListView();
        }

        private void UpdatePaymetMethodListView()
        {
            paymentMethods = db.PaymentMethodsGetAll();

            PaymentMethod newPaymentMethod = new PaymentMethod();

            ListViewItem lvi;

            foreach (var item in paymentMethods)
            {
                lvi = new ListViewItem(item.Name);
                lvi.Tag = item;
                PaymentMethodsListView.Items.Add(lvi);
            }
            lvi = new ListViewItem("");
            lvi.Tag = newPaymentMethod;
            PaymentMethodsListView.Items.Add(lvi);
        }

        private void UpdateJMSListView()
        {
            JMS = db.JMGetAll();

            JMSListView.Items.Clear();

            JM newJM = new JM();

            ListViewItem lvi;

            foreach (var item in JMS)
            {
                lvi = new ListViewItem(new string[]
                {
                    item.Name,
                    Helper.MekePracision(item.Precision)
                });;
                lvi.Tag = item;
                JMSListView.Items.Add(lvi);
            }
            lvi = new ListViewItem("");
            lvi.Tag = newJM;
            JMSListView.Items.Add(lvi);
        }

        private void UpdateVatRateListView()
        {
            vatrates = db.VatRatesGetAll();

            VatRatesListView.Items.Clear();

            VatRates newVat = new VatRates();
            ListViewItem lvi;
            foreach (var item in vatrates)
            {
                lvi = new ListViewItem(item.Rate.ToString());
                lvi.Tag = item;
                VatRatesListView.Items.Add(lvi);
                VATRateHashSet.Add(item.Rate);
            }
            lvi = new ListViewItem("");
            lvi.Tag = newVat;
            VatRatesListView.Items.Add(lvi);
        }

        private void VatRatesListView_DoubleClick(object sender, EventArgs e)
        {
            oldValue = ((VatRates)VatRatesListView.SelectedItems[0].Tag).Rate.ToString();
            isEdit = true;
            VatRatesListView.SelectedItems[0].BeginEdit();
        }

        private void VatRatesListView_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            try
            {
                if (e.Label == null) return;
                int newValue = int.Parse(e.Label);
                if (VATRateHashSet.Contains(newValue))
                {
                    MessageBox.Show("Podana wartośc już istnieje", "Błąd");
                    return;
                }
                var change = (VatRates) VatRatesListView.SelectedItems[0].Tag;
                change.Rate = newValue;
                db.VatRateExecute(change);
            }
            catch (FormatException)
            {
                MessageBox.Show( "Wprowadź poprawną wartośc","Błąd");
                e.CancelEdit = true;
            }
            finally
            {
                UpdateVatRateListView();
                isEdit = false;
            }
        }

        private void VatRatesListView_KeyUp(object sender, KeyEventArgs e)
        {
            if (isEdit == false && e.KeyCode == Keys.Delete) 
            {
                try
                {
                    var toDelete = (VatRates)VatRatesListView.SelectedItems[0].Tag;
                    db.VatRateDelete(toDelete.ID);
                    UpdateVatRateListView();
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show( "Nie możesz usunąć rekordu z którego korzystałeś", "Błąd");
                }
            }
        }

        private void JMSListView_DoubleClick(object sender, EventArgs e)
        {
            JM theUnit = (JM)JMSListView.SelectedItems[0].Tag;
            EditJMForm form = new EditJMForm(theUnit);
            form.FormClosed += ClosedEditJMForm;
            form.ShowDialog();
        }

        private void ClosedEditJMForm(object sender, FormClosedEventArgs e)
        {
            UpdateJMSListView();
        }

        private void PaymentMethodsListView_DoubleClick(object sender, EventArgs e)
        {
            isEdit = true;
            PaymentMethodsListView.SelectedItems[0].BeginEdit();
        }

        private void PaymentMethodsListView_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            try
            {
                if (e.Label == null) return;
                var change = (PaymentMethod)PaymentMethodsListView.SelectedItems[0].Tag;
                change.Name = e.Label;
                db.PaymentMethodsPutItem(change);
            }
            finally
            {
                UpdateVatRateListView();
                isEdit = false;
            }
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            CompanyInfo = GetCompanyInfo();


            NameTextBox.Text = CompanyInfo["[MyName]"];
            StreetTextBox.Text = CompanyInfo["[MyStreet]"];
            ZipCodeTextBox.Text = CompanyInfo["[MyZipCode]"];
            CityTextBox.Text = CompanyInfo["[MyCity]"];
            NIPTextBox.Text = CompanyInfo["[MyNip]"];
        }

        public static Dictionary<string,string> GetCompanyInfo()
        {
            List<string> result = new List<string>();
            Dictionary<string, string> res = new Dictionary<string, string>();
            if (!File.Exists(path))
            {
                // Create a file to write to.

                File.Create(path);
            }
            string line;
            // Open the text file using a stream reader.
            using (var sr = new StreamReader(path))
            {
                // Read the stream as a string, and write the string to the console.
                while ((line = sr.ReadLine()) != null)
                {
                    res.Add(line.Split('=')[0],line.Split('=')[1]);
                }
            }
            return res;
        }

        public void SaveCompanyInfo()
        {
            using (var wr = new StreamWriter(path))
            {
                foreach(var item in CompanyInfo)
                {
                    string line = item.Key + "=" + item.Value;
                    wr.WriteLine(line);
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            CompanyInfo["[MyName]"] = NameTextBox.Text;
            CompanyInfo["[MyStreet]"] = StreetTextBox.Text;
            CompanyInfo["[MyZipCode]"] = ZipCodeTextBox.Text;
            CompanyInfo["[MyCity]"] = CityTextBox.Text;
            CompanyInfo["[MyNip]"] = NIPTextBox.Text;

            SaveCompanyInfo();
            MessageBox.Show("Zapisano", "Zapisano");
        }
    }
}
