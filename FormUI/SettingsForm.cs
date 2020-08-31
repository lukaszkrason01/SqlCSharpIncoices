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
    public partial class SettingsForm : Form
    {
        private SampleDBOperations db = SampleDBOperations.GetInstace();

        bool isEdit = false;
        string oldValue;

        List<VatRates> vatrates;
        HashSet<int> VATRateHashSet = new HashSet<int>();

        List<JM> JMS;
        public SettingsForm()
        {
            InitializeComponent();
            vatrates = db.VatRatesGetAll();

            UpdateVatRateListView();
            UpdateJMSListView();
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
                    MessageBox.Show("Błąd", "Podana wartośc już istnieje");
                    return;
                }
                var change = (VatRates) VatRatesListView.SelectedItems[0].Tag;
                change.Rate = newValue;
                db.VatRateExecute(change);
            }
            catch (FormatException)
            {
                MessageBox.Show("Błąd", "Wprowadź poprawną wartośc");
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
                var toDelete = (VatRates)VatRatesListView.SelectedItems[0].Tag;
                db.VatRateDelete(toDelete.ID);
                UpdateVatRateListView();
            }
        }
    }
}
