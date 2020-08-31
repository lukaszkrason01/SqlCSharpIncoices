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
    public partial class MainFom : Form
    {
        public MainFom()
        {
            InitializeComponent();
        }

        private void ShowInvoicesButton_Click(object sender, EventArgs e)
        {
            InvoiceForm form = new InvoiceForm();
            form.ShowDialog();
        }

        private void ShowProduccts_Click(object sender, EventArgs e)
        {
            ShowProducts form = new ShowProducts();
            form.ShowDialog();
        }

        private void ShowCompaniesButton_Click(object sender, EventArgs e)
        {
            CompaniesForm form = new CompaniesForm();
            form.ShowDialog();
        }

        private void AddNewInvoice_Click(object sender, EventArgs e)
        {
            InvoiceForm form = new InvoiceForm();
            form.AddInvoice();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm form = new SettingsForm();
            form.Show();
        }
    }
}
