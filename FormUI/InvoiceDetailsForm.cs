using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FormUI
{
    public partial class InvoiceDetailsForm : Form
    {
        private SampleDBOperations db = SampleDBOperations.GetInstace();
        List<Control> componentsED = new List<Control>();

        Company company;
        Invoice invoice;

        List<InvoiceItem> invoiceItems = new List<InvoiceItem>();
        Dictionary<int, int> vatrates;
        Dictionary<int, string> PaymentMethodsDict;


        public InvoiceItem currentItem;
        public InvoiceDetailsForm(Invoice invoice)
        {
            InitializeComponent();

            componentsED.Add(BrtAmountTextBox);
            componentsED.Add(NetAmountTextBox);
            componentsED.Add(TaxAmountTextBox);
            componentsED.Add(listView1);
            componentsED.Add(PaymentMethodComboBox);
            componentsED.Add(TermTextBox);
            componentsED.Add(DateTermTextBox);
            componentsED.Add(DateTextBox);
            componentsED.Add(SaveInvoiceButton);
            componentsED.Add(AddProduct);
            componentsED.Add(EditProductButton);
            componentsED.Add(DeleteProduct);
            componentsED.Add(DateTermTextBox);
            componentsED.Add(InvoiceNumberTextBox);

            vatrates = db.VatRatesDictionary();
            PaymentMethodsDict = db.PaymentMethodsGetDictionary();

            foreach (var item in PaymentMethodsDict)
            {
                PaymentMethodComboBox.Items.Add(item.Value);
            }

            this.company = db.CompaniesGetByID(
                invoice.CompanyID
                );

            CName.Text = this.company.Name;
            CAddress1.Text = this.company.Street;
            CAddress2.Text = this.company.ZipCode + this.company.City;
            CNip.Text = "NIP:" + this.company.NIP;



            this.invoice = invoice;

            if (invoice.Id == 0)
            {
                InvoiceNumberTextBox.Text = "FV/"+ db.InvoicesGetNumber() + "/" + DateTime.Now.Year;
                DateTextBox.Text = DateTime.Now.ToString("dd-MM-yyyy");
                PaymentMethodComboBox.SelectedIndex = 0;
                TermTextBox.Text = "0";

                EditInvoiceButton.Visible = false;
                InfoLabel.Visible = false;
                PrintInvoiceButton.Visible = false;
            }
            else
            {
                SetDataFromDB();

                EditInvoiceButton.Visible = true;
                InfoLabel.Visible = true;
                if(invoice.State == 2)
                {
                    InfoLabel.ForeColor = Color.Red;
                    InfoLabel.Text = "Faktura została usunięta";
                    EditInvoiceButton.Enabled = false;
                }
                DisableChanges();
            }

            UpdateMyInfo();
            UpdateListView();
        }

        private void UpdateMyInfo()
        {
            Dictionary<string,string> myInfo = SettingsForm.GetCompanyInfo();

            MyName.Text = myInfo["[MyName]"];
            MyAdres1.Text = myInfo["[MyStreet]"];
            MyAdres2.Text = myInfo["[MyZipCode]"] + " " + myInfo["[MyCity]"];
            MyNip.Text = "NIP:"+myInfo["[MyNip]"];
        }

        private void SetDataFromDB()
        {
            InvoiceNumberTextBox.Text = invoice.Name;
            DateTextBox.Text = invoice.Date.ToString("dd-MM-yyyy");
                PaymentMethodComboBox.SelectedIndex = invoice.PaymentMethodID - 1;
                DateTermTextBox.Text = invoice.Term.ToString("dd-MM-yyyy");
                TermTextBox.Text = (invoice.Term.Subtract(invoice.Date)).Days.ToString();

                invoiceItems = db.InvoiceItemsGetByInvoiceID(invoice.Id);
        }

        private void DisableChanges()
        {
            foreach (var item in componentsED)
            {
                item.Enabled = false;
            }
            PrintInvoiceButton.Enabled = true;
            PrintInvoiceButton.Visible = true;
            EditInvoiceButton.Visible = true;
            InfoLabel.Visible = true;
            InfoLabel.Text = "Faktura została zapisana";
            EditInvoiceButton.Text = "Edytuj fakturę";
        }

        private void EnabledChanges()
        {
            foreach (var item in componentsED)
            {
                item.Enabled = true;
            }
            PrintInvoiceButton.Enabled = false;
            InfoLabel.Text = "Edycja Faktury";
            EditInvoiceButton.Text = "Zakończ bez zmian";
        }

        private void UpdateDateTermTexBox()
        {
            DateTime term = Convert.ToDateTime(DateTextBox.Text);
            var a = double.Parse(TermTextBox.Text);
            DateTermTextBox.Text = term.AddDays(a).ToString("dd-MM-yyyy");
        }

        private void PrintPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintPreviewInvoice();
        }

        private void PrintPreviewInvoice()
        {
            DVPrintPreviewDialog.Document = DVPprintDocument;
            DVPrintPreviewDialog.ShowDialog();
        }
        private void DVPprintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(CName.Text,new Font("Arial",12,FontStyle.Regular),Brushes.Black,new Point(25,100));
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            currentItem = new InvoiceItem();
            currentItem.ProductID = 0;
            ShowProducts form = new ShowProducts(currentItem);
            form.FormClosed += ShowProductFormClosed;
            form.ShowDialog();
        }

        private void ShowProductFormClosed(object sender, FormClosedEventArgs e)
        {
            if(currentItem.ProductID != 0)
            {
                currentItem.Quantity = 0;
                AddProductToInvoiceForm form = new AddProductToInvoiceForm(currentItem);
                form.FormClosed += AddProductToInviceFormClosed;
                form.ShowDialog();
            }
        }

        private void AddProductToInviceFormClosed(object sender, FormClosedEventArgs e)
        {
            if(currentItem.Quantity != 0)
            {
                UpdateCurrentItem();

                invoiceItems.Add(currentItem);

                UpdateListView();
            }
        }
        private void UpdateCurrentItem()
        {

            currentItem.NetAmount = decimal.Round(currentItem.NetPrice * currentItem.Quantity, 2);
            currentItem.VatAmount = decimal.Round(currentItem.NetAmount * 0.01m * currentItem.VatRate, 2);
            currentItem.BrtAmount = currentItem.NetAmount + currentItem.VatAmount;
        }

        private void UpdateListView()
        {
           
            listView1.Items.Clear();
            Dictionary<int, Tuple<string,int>> jm = db.JMGetDictionaryAll();
            invoice.TotalBrtAmount = 0;
            invoice.TotalNetAmount = 0;
            invoice.TotalTaxAmount = 0;


            int lp = 1;
            foreach (var ii in invoiceItems)
            {
                Product product = db.ProductsGetByID(ii.ProductID);
                string jmstr = jm[product.Jm].Item1;

                string format = Helper.MakeDecimalFormat(jm[product.Jm].Item2);

                ListViewItem item = new ListViewItem(new string[] {
                    (lp++).ToString() ,
                    db.ProductsGetByID(ii.ProductID).Name,
                    String.Format(format,ii.Quantity),
                    jmstr,
                    String.Format("{0:0.00}",ii.NetPrice),
                    String.Format("{0:0.00}",ii.NetAmount),
                    ii.VatRate.ToString() + "%",
                    String.Format("{0:0.00}",ii.VatAmount),
                    String.Format("{0:0.00}",ii.BrtAmount)
                }); ; ;

                item.Tag = ii;
                listView1.Items.Add(item);

                invoice.TotalNetAmount += ii.NetAmount;
                invoice.TotalTaxAmount += ii.VatAmount;
                invoice.TotalBrtAmount += ii.BrtAmount;
            }

            NetAmountTextBox.Text = String.Format("{0:0.00}", invoice.TotalNetAmount);
            TaxAmountTextBox.Text = String.Format("{0:0.00}", invoice.TotalTaxAmount);
            BrtAmountTextBox.Text = String.Format("{0:0.00}", invoice.TotalBrtAmount);
        }

        private void EditProduct_Click(object sender, EventArgs e)
        {
            EditProduct();
        }

        private void EditProduct()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                currentItem = (InvoiceItem)listView1.SelectedItems[0].Tag;

                AddProductToInvoiceForm form = new AddProductToInvoiceForm(currentItem);
                form.FormClosed += EditFormClosed;
                form.ShowDialog();
            }
        }
        private void EditFormClosed(object sender, FormClosedEventArgs e)
        {
            if (currentItem.Quantity != 0)
            {
                UpdateCurrentItem();

                UpdateListView();
            }
        }

        private void Delete_product_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                var tag = (InvoiceItem)listView1.SelectedItems[0].Tag;

                foreach(var item in invoiceItems)
                {
                    if (item == tag)
                    {
                        invoice.TotalNetAmount -= item.NetAmount;
                        invoice.TotalTaxAmount -= item.VatAmount;
                        invoice.TotalBrtAmount -= item.BrtAmount;
                        invoiceItems.Remove(tag);
                        break;
                    }
                }
                UpdateListView();
            }
        }

        private void DateTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                DateTextBox.Text = Convert.ToDateTime(DateTextBox.Text).ToString("dd-MM-yyyy");

            }
            catch (Exception)
            {
                DateTextBox.Text = DateTime.Now.ToString("dd-MM-yyyy");
            }
            finally
            {
                UpdateDateTermTexBox();
            }
        }

        private void TermTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                TermTextBox.Text = int.Parse(TermTextBox.Text).ToString();
            }
            catch (Exception)
            {
                TermTextBox.Text = "0";
            }
            finally
            {
                UpdateDateTermTexBox();
            }
        }

        private void SaveInvoiceButton_Click(object sender, EventArgs e)
        {
            SaveInvoice();
        }

        private void SaveInvoice()
        {
            if (invoiceItems.Count == 0)
            {
                MessageBox.Show("Najpierw dodaj jakieś produkty", "Brak prodóktów", MessageBoxButtons.OK);
                return;
            }

            string messege = $"Całkowita wartość brutto wynosi{String.Format("{0:0.00}", invoice.TotalBrtAmount)}zł.\n" +
                $"Termin płatności do {DateTermTextBox.Text}. Metoda płatności to {PaymentMethodComboBox.SelectedItem}\n" +
                $"Czy zapisać?";

            string caption = invoice.Id == 0 ? "Nowa Faktura VAT" : "Zmiany w Fakturze VAT";

            var result = MessageBox.Show(messege, caption, MessageBoxButtons.YesNoCancel);


            if (result == DialogResult.Yes)
            {
                if (invoice.Id != 0)
                    db.InvoiceItemDeleteByInvoiceID(invoice.Id);
                invoice.State = 1;
                invoice.Name = InvoiceNumberTextBox.Text;
                invoice.Date = Convert.ToDateTime(DateTextBox.Text);
                invoice.PaymentMethodID = PaymentMethodComboBox.SelectedIndex + 1;
                invoice.Term = Convert.ToDateTime(DateTermTextBox.Text);

                if (invoice.Id == 0) invoice.Id = db.InvoicesInsert(invoice);
                else db.InvoicesUpdate(invoice);
                foreach (var item in invoiceItems)
                {
                    Product prod = db.ProductsGetByID(item.ProductID);
                    prod.Price = item.NetPrice;
                    db.ProductsUpdateByID(prod);

                    item.InvoiceId = invoice.Id;
                    db.InvoiceItemsInsert(item);
                }
                DisableChanges();
            }
            if (result == DialogResult.No)
            {
                Close();
            }
        }

        private void EditInvoiceButton_Click(object sender, EventArgs e)
        {
            if(InvoiceNumberTextBox.Enabled == false)
            {
                EnabledChanges();
            }
            else
            {
                DialogResult result;
                result = MessageBox.Show("Wyjście bez zapisu", "Czy na pewno chcesz wyjść bez zapisu?", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    DisableChanges();
                    SetDataFromDB();
                    UpdateListView();
                }

            }
        }

        private void PrintInvoiceButton_Click(object sender, EventArgs e)
        {

        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveInvoice();
        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            EditProduct();
        }
    }
}
