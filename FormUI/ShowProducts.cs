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

    public partial class ShowProducts : Form
    {
        private SampleDBOperations db = SampleDBOperations.GetInstace();
        private ListViewColumnSorter lvwColumnSorter;

        List<Product> products = null;

        private InvoiceItem theItem = null;

        public ShowProducts()
        {
            InitializeComponent();
            lvwColumnSorter = new ListViewColumnSorter();
            this.listView1.ListViewItemSorter = lvwColumnSorter;

            products = db.ProductsGetAll();

            UpdateListView();
        }

        public ShowProducts(InvoiceItem currentItem) :this()
        {
            theItem = currentItem;
        }

        private void UpdateListView()
        {
            products = db.ProductsGetAllInner();
            listView1.Items.Clear();

            foreach (var item in products)
            {
                ListViewItem lvi = new ListViewItem(new string[]{
                    item.Name,
                    item.Jm,
                    item.Vat + "%",
                    String.Format("{0:0.00}", item.Price),

                }); ;
                lvi.Tag = item;
                listView1.Items.Add(lvi);
            }
        }

        private void SortingListView(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.listView1.Sort();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (theItem == null) showProductDetails();
            else
            {
                Product p = (Product)listView1.SelectedItems[0].Tag;
                theItem.ProductID= p.ID;
                theItem.VatRate = p.Vat;
                this.Close();
            }
        }

        private void showProductDetails()
        {
            Product selected =(Product) listView1.SelectedItems[0].Tag;
            DetailsProductForm form = new DetailsProductForm(selected.ID);
            form.FormClosed += newFormClosed;
            form.ShowDialog();
        }

        private void newFormClosed(object sender, FormClosedEventArgs e)
        {
            products = db.ProductsGetAll();
            UpdateListView();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            DetailsProductForm form = new DetailsProductForm(0);
            form.FormClosed += newFormClosed;
            form.ShowDialog();
        }

        private void RTSearch_KeyUp(object sender, KeyEventArgs e)
        {
            products = db.ProductsGetByName(RTSearch.Text);
            UpdateListView();
        }

        private void RTSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowDetails_Click(object sender, EventArgs e)
        {
            try
            {
                Product selected = (Product)listView1.SelectedItems[0].Tag;
                DetailsProductForm form = new DetailsProductForm(selected.ID);
                form.FormClosed += newFormClosed;
                form.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Najpierw Wybierz produkt", "Wybierz Produkt", MessageBoxButtons.OK);
            }
        }
    }
}
