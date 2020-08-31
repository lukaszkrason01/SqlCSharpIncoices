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
    public partial class InvoiceForm : Form
    {
        private SampleDBOperations db = SampleDBOperations.GetInstace();

        List<Invoice> invoices;
        Dictionary<int, string> paymentMethod;
        List<State> states;

        Invoice newInvoice;

        public InvoiceForm()
        {
            InitializeComponent();

            states = db.StatesGetAll();
            StatesComboBox.Items.Add("Wszystkie");
            foreach (var item in states)
            {
                StatesComboBox.Items.Add(item.Name);
            }

            StatesComboBox.SelectedIndex = 1;

            UpdateView();
        }

        private void UpdateView()
        {
            UpdateListView();
        }

        private void UpdateListView()
        {
            listView1.Items.Clear();

            paymentMethod = db.PaymentMethodsGetDictionary();
            invoices = db.InvoicesGetAll(StatesComboBox.SelectedIndex);

            foreach (var item in invoices)
            {
                ListViewItem lvi = new ListViewItem(new string[] {
                    item.Name,
                    db.CompaniesGetByID(item.CompanyID).Name,
                    item.Date.ToString("dd-MM-yyyy"),
                    item.Term.ToString("dd-MM-yyyy"),
                    paymentMethod[item.PaymentMethodID],
                    String.Format("{0:0.00}", item.TotalNetAmount),
                    String.Format("{0:0.00}", item.TotalTaxAmount),
                    String.Format("{0:0.00}", item.TotalBrtAmount)
                });
                lvi.Tag = item;
                if(item.State == 2 )lvi.ForeColor = Color.Red;
                listView1.Items.Add(lvi);
            }
        }

        private void AddInvoiceButton_Click(object sender, EventArgs e)
        {
            AddInvoice();
        }

        public void AddInvoice()
        {
            newInvoice = new Invoice();
            CompaniesForm form = new CompaniesForm(newInvoice);
            form.FormClosed += ClosedDashBoard;
            form.ShowDialog();
        }

        private void ClosedDashBoard(object sender, FormClosedEventArgs e)
        {
            if (newInvoice.CompanyID != 0)
            {
                InvoiceDetailsForm form = new InvoiceDetailsForm(newInvoice);
                form.FormClosed += ClesedInvoiceDetailsForm;
                form.ShowDialog();
            }
        }

        private void ClesedInvoiceDetailsForm(object sender, FormClosedEventArgs e)
        {
            UpdateListView();
        }

        private void ShowInvoice_Click(object sender, EventArgs e)
        {
            ShowInvoiceDetails();

/*            DBAACess<Company> companies = new DBAACess<Company>();*/
/*
            List<Company> list = companies.GetList("dbo.Companies_getAll");
            SampleDBOperations dam = new SampleDBOperations();

            Company company = dam.CompaniesGetByID(5);
            company.City = "nowe miasto 2508";
            dam.CompaniesUpdateByID(company);

*//*            DBAACess<JM> db = new DBAACess<JM>();
            List<JM> lista = db.GetListData("dbo.JM_getAll");
*//*
             AEntity.getPropertiesName(list[0]);*/
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ShowInvoiceDetails();
        }

        private void ShowInvoiceDetails()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var theInvoice = (Invoice)listView1.SelectedItems[0].Tag;
                InvoiceDetailsForm form = new InvoiceDetailsForm(theInvoice);
                form.FormClosed += ClesedInvoiceDetailsForm;
                form.ShowDialog();
            }
        }

        private void DeleteInvoiceButton_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                var theInoive = (Invoice)listView1.SelectedItems[0].Tag;
                if (theInoive.State == 1)
                    theInoive.State = 2;
                else theInoive.State = 1;
                db.InvoicesUpdate(theInoive);
            }
            UpdateListView();
        }

        private void StatesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListView();
        }
    }
}
