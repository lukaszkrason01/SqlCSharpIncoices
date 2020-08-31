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
    public partial class DetailsProductForm : Form
    {
        private SampleDBOperations db = SampleDBOperations.GetInstace();

        Product productToShow;
        Dictionary<int, string> jms;
        Dictionary<int, int> vatrates;

        public DetailsProductForm(int ProductID)
        {
            InitializeComponent();

            jms = db.JMGetDictionary();
            vatrates = db.VatRatesDictionary();

            foreach (var item in jms)
            {
                JMComboBox.Items.Add(item.Value);
            }
            
            foreach (var item in vatrates)
            {
                VATComboBox.Items.Add(item.Value);
            }
            
            if (ProductID != 0)
            {
                productToShow = db.ProductsGetByID(ProductID);
                NameTextBox.Text = productToShow.Name;

                JMComboBox.SelectedIndex = productToShow.Jm - 1;

                VATComboBox.SelectedIndex = productToShow.Vat - 1;

                PriceTextBox.Text = String.Format("{0:0.00}", productToShow.Price);
            }
            else
            {
                JMComboBox.SelectedIndex = 0;

                VATComboBox.SelectedIndex = 0;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            bool isName = true;
            if (NameTextBox.Text.Length == 0) isName = false;

            string message;
            string caption;
            MessageBoxButtons buttons;
            DialogResult result;
            if (isName)
            {
                message = "Czy na pewno zapisać?";
                caption = "Zapis";
                buttons = MessageBoxButtons.YesNoCancel;

                result = MessageBox.Show(message, caption, buttons);

                if (result == DialogResult.Yes)
                {
                    decimal price;
                    if (PriceTextBox.Text.Length == 0) price = 0;
                    else price = decimal.Round(decimal.Parse(PriceTextBox.Text),2);
                    Product newProduct = new Product
                    {
                        ID = productToShow == null ? 0 : productToShow.ID,
                        Name = NameTextBox.Text,
                        Jm = JMComboBox.SelectedIndex + 1,
                        Vat = VATComboBox.SelectedIndex + 1,
                        Price = price
                    };
                    if (newProduct.ID == 0) db.ProductsInsert(newProduct);
                    else db.ProductsUpdateByID(newProduct);
                    this.Close();
                }
                if (result == DialogResult.No)
                {
                    this.Close();
                }
            }
            else
            {
                message = "Wpisz nazwę produktu";
                caption = "Brak nazwy";
                buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }

        }

        private void PriceTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                PriceTextBox.Text = Helper.PriceValidate(PriceTextBox.Text);
            }
            catch( Exception )
            {
                PriceTextBox.Text = Helper.PriceValidate("0");
            }
        }
    }
}
