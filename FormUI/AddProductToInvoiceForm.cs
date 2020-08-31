using Microsoft.SqlServer.Server;
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

namespace FormUI
{
    public partial class AddProductToInvoiceForm : Form
    {
        private SampleDBOperations db = SampleDBOperations.GetInstace();
        InvoiceItem theItem = null;

        Product p;

        public AddProductToInvoiceForm(InvoiceItem currentItem)
        {
            InitializeComponent();

            theItem = currentItem;

            p = db.ProductsGetByID(theItem.ProductID);
            Dictionary<int, int> vatrates = db.VatRatesDictionary();
            Dictionary<int, string> jms = db.JMGetDictionary();

            PnameTextBox.Text = p.Name;
            PJMtextBox.Text = jms[p.Jm];
            PVatTextBox.Text =vatrates[p.Vat].ToString() + "%";
            

            if (currentItem.Quantity != 0)
            {
                QuantityTextBox.Text = currentItem.Quantity.ToString();
                PriceTextBox.Text = String.Format("{0:0.00}", currentItem.NetPrice);
            }
            else
            {
                PriceTextBox.Text = String.Format("{0:0.00}", p.Price);
                QuantityTextBox.Text = "1";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProductToInvoice();
        }

        private void AddProductToInvoice()
        {
            bool isQuantity=true;
            if (decimal.Parse(QuantityTextBox.Text) == 0) 
                isQuantity = false;

            bool isPrice = true;
            if (decimal.Parse(PriceTextBox.Text) == 0)
                isPrice = false;

            if (!isQuantity || !isPrice)
            {
                MessageBox.Show( "Wpisz poprawne wartości", "Nieprawidłowe wartości", MessageBoxButtons.OK); 
            }
            else
            {
                theItem.NetPrice = decimal.Parse(PriceTextBox.Text);
                theItem.Quantity = decimal.Parse(QuantityTextBox.Text);

                this.Close();
            }
        }

        private void CheckQuantity()
        {
            try
            {
                QuantityTextBox.Text = QuantityTextBox.Text.Replace('.', ',');
                QuantityTextBox.Text = (decimal.Round(decimal.Parse(QuantityTextBox.Text)
                    ,db.JMGetByID(p.Jm).Precision)).ToString();
            }
            catch (Exception)
            {

                QuantityTextBox.Text = "1";
            }
        }

        private void QuantitiTexBox_Leave(object sender, EventArgs e)
        {
            CheckQuantity();
        }

        private void PriceTextBox_Leave(object sender, EventArgs e)
        {
            PriceTextBox.Text = Helper.PriceValidate(PriceTextBox.Text);
        }
    }
}
