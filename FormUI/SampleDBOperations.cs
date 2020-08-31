using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    abstract class ADataBaseOperations
    {
        protected  void GetPropertiesToUpdate(ref string sql, IEntyty item)
        {
            sql += $" @{ item.GetType().GetProperties()[0].Name},";

            GetPropertiesToInsert(ref sql, item);
        }
        protected void GetPropertiesToInsert(ref string sql, IEntyty item)
        {
            PropertyInfo[] properrties = item.GetType().GetProperties();

            for (int i = 1; i < properrties.Length; ++i)
            {
                sql += $" @{properrties[i].Name},";
            }
            sql = sql.Remove(sql.Length - 1);
        }
    }
        
    class SampleDBOperations : ADataBaseOperations
    {
        private readonly static string database = Helper.ConVal("SampleDB");

        private DBAACess<Company> daCompanies = new DBAACess<Company>(database);
        private DBAACess<Product> daProducts = new DBAACess<Product>(database);
        private DBAACess<JM> daJMs = new DBAACess<JM>(database);
        private DBAACess<VatRates> daVatRates = new DBAACess<VatRates>(database);
        private DBAACess<Invoice> daInvoices = new DBAACess<Invoice>(database);
        private DBAACess<PaymentMethod> daPaymentMethods = new DBAACess<PaymentMethod>(database);
        private DBAACess<InvoiceItem> daInvoiceItems = new DBAACess<InvoiceItem>(database);
        private DBAACess<State> daState = new DBAACess<State>(database);

        // Singleton
        private static SampleDBOperations _instance;

        private SampleDBOperations()
        {
        }
        
        public static SampleDBOperations GetInstace()
        {
            if (_instance == null)
                _instance = new SampleDBOperations();
            return _instance;
        }

        //   State
        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////////////////////
        
        public List<State> StatesGetAll()
        {
            return daState.GetList("dbo.States_getAll");
        }

        public Dictionary<string,int> StatesGetDictionary()
        {
            return StatesGetAll().ToDictionary(x => x.Name, x => x.ID);
        }

        //     Companies
        ////////////////////////////////////////////////////////////////////////////////////////////////

        public void CompaniesInsert(Company newCompany)
        {
            string sql = "dbo.Companies_insert";
            GetPropertiesToInsert(ref sql,newCompany);

            daCompanies.PutItem(sql, newCompany);
        }

        public void CompaniesUpdateByID(Company company)
        {
            string sql = "dbo.Companies_updateByID";
            GetPropertiesToUpdate(ref sql, company);

            daCompanies.PutItem(sql, company);
        }

        public List<Company> CompaniesGetAll()
        {
            return daCompanies.GetList("dbo.Companies_getAll");
        }

        public Company CompaniesGetByID(string id)
        {
            return CompaniesGetByID(int.Parse(id));
        }

        public Company CompaniesGetByID(int id)
        {
            return daCompanies.GetItem("dbo.Companies_getByID @ID"
                , new { ID = id });
        }

        public List<Company> CompaniesGetByName(string name)
        {
            return daCompanies.GetList("dbo.Companies_getByName @Name"
                , new { Name = name });
        }

        public List<Company> CompaniesGetByStreet(string street)
        {
            return daCompanies.GetList("dbo.Companies_getByStreet @Street"
                , new { Street = street });
        }

        public List<Company> CompaniesGetByCity(string city)
        {
            return daCompanies.GetList("dbo.Companies_getByCity @City"
                , new { City = city });
        }
        public List<Company> CompaniesGetByZipCode(string zipcode)
        {
            return daCompanies.GetList("dbo.Companies_getByZipCode @ZipCode"
                , new { ZipCode = zipcode });
        }
        public List<Company> CompaniesGetByNip(string nip)
        {
            return daCompanies.GetList("dbo.Companies_getByNip @Nip"
                , new { Nip = nip });
        }

        public List<Company> CompaniesGetByColumnNumber(int column, string condition)
        {
            List<Company> result = null;

            switch (column)
            {
                case 1:
                    result = new List<Company>();
                    result.Add(CompaniesGetByID(condition));
                    break;
                case 2:
                    result = CompaniesGetByName(condition);
                    break;
                case 3:
                    result = CompaniesGetByStreet(condition);
                    break;
                case 4:
                    result = CompaniesGetByZipCode(condition);
                    break;
                case 5:
                    result = CompaniesGetByCity(condition);
                    break;
                case 6:
                    result = CompaniesGetByNip(condition);
                    break;
                default:
                    break;
            }
            return result;
        }

        //  Products
        ////////////////////////////////////////////////////////////////////////////////////////////////

        public void ProductsUpdateByID(Product product)
        {
            string sql = $"dbo.Products_updateByID";
            GetPropertiesToUpdate(ref sql, product);

            daProducts.PutItem(sql, product);
        }
 
        public List<Product> ProductsGetAllInner()
        {
            return daProducts.GetList("dbo.Products_getByIDInner @ID"
                , new { ID = 0 });
        }
        public Product ProductsGetByIDInner(int id = 0)
        {
            return daProducts.GetItem("dbo.Products_getByIDInner @ID"
                , new { ID = id });
        }
        public void ProductsInsert(Product newProduct)
        {
            string sql = "dbo.Products_insert";
            GetPropertiesToInsert(ref sql, newProduct);

            daProducts.PutItem(sql, newProduct);
        }
        public List<Product> ProductsGetAll()
        {
            return daProducts.GetList("dbo.Products_getAll");
        }

        public Product ProductsGetByID(string id)
        {
            return ProductsGetByID(int.Parse(id));
        }

        public Product ProductsGetByID(int id)
        {
            return daProducts.GetItem("dbo.Products_getByID @ID"
                ,new { ID = id } );
        }
        public List<Product> ProductsGetByName(string name)
        {
            return daProducts.GetList("dbo.Products_getByName @Name"
                ,new { Name = name });
        }
        //  vatrates
        ///////////////////////////////////////////////////////////////////////////////////////////////////
        
        public List<VatRates> VatRatesGetAll()
        {
            return daVatRates.GetList("dbo.vatrate_getAll");
        }

        public Dictionary<int,int> VatRatesDictionary()
        {
            return VatRatesGetAll().ToDictionary(x => x.ID, x => x.Rate);
        }

        public void VatRateExecute(VatRates vat)
        {
            string procedure = "dbo.vatrate_Execute";
            GetPropertiesToUpdate(ref procedure, vat);
            daVatRates.PutItem(procedure,vat);
        }

        public void VatRateDelete(int id)
        {
            daVatRates.DeleteItems("dbo.vatrate_Delete @ID"
                , new { ID = id });
        }

        //  JMs
        ////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///

        public List<JM> JMGetAll()
        {
            return daJMs.GetList("dbo.jm_getAll");
        }

        public Dictionary<int,string> JMGetDictionary()
        {
            return JMGetAll().ToDictionary(x => x.ID, x => x.Name);
        }

        public Dictionary<int, Tuple<string, int>> JMGetDictionaryAll()
        {
            return JMGetAll().ToDictionary(x => x.ID, x => new Tuple<string, int>(x.Name, x.Precision));
        }

        public JM JMGetByID(int id)
        {
            return daJMs.GetItem("dbo.jm_getByID @ID"
                , new { ID = id });
        }

        public void JMPutItem(JM unit)
        {
            string procedure = ("dbo.jm_putItem");
            GetPropertiesToUpdate(ref procedure, unit);
            daJMs.PutItem(procedure, unit);
        }

        //  Invoices
        ////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///

        public int InvoicesGetNumber()
        {
            return daInvoices.ExecuteScalar("dbo.Invoices_getInvoiceNumber");
        }

        public List<Invoice> InvoicesGetAll(int state)
        {
            return daInvoices.GetList("dbo.Invoices_getAll @STATE"
                , new { STATE = state });
        } 

        public Invoice InvoicesGetByID(int id)
        {
            return daInvoices.GetItem("dbo.Invoices_getByID @ID"
                , new { ID = id });
        }

        public Invoice InvoicesGetByID(string id)
        {
            return InvoicesGetByID(int.Parse(id));
        }

        public int InvoicesInsert(Invoice newInvoice)
        {
            string procedure = "dbo.Invoices_insert";
            GetPropertiesToInsert(ref procedure, newInvoice);
            return daInvoices.PutItemAndGetID(procedure, newInvoice);
        }

        internal void InvoicesUpdate(Invoice invoice)
        {
            string procedure = "dbo.Invoices_update";
            GetPropertiesToUpdate(ref procedure, invoice);
            daInvoices.PutItem(procedure,invoice);
        }

        // PaymentMethods
        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///

        public List<PaymentMethod> PaymentMethodsGetAll()
        {
            return daPaymentMethods.GetList("dbo.PaymentMethod_getAll");
        }

        public Dictionary<int,string> PaymentMethodsGetDictionary()
        {
            return PaymentMethodsGetAll().ToDictionary(x => x.ID, x => x.Name);
        }

        public void PaymentMethodsPutItem(PaymentMethod pm)
        {
            string procedure = "dbo.paymentmethod_put";
            GetPropertiesToUpdate(ref procedure, pm);
            daPaymentMethods.PutItem(procedure, pm);
        }

        //  Invoice Items
        ////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///

        public List<InvoiceItem> InvoiceItemsGetByInvoiceID(int id)
        {
            return daInvoiceItems.GetList("dbo.InvoiceItems_GetByCompanyID @ID"
                , new { ID = id });
        }

        public void InvoiceItemsInsert(InvoiceItem newInvoiceItem)
        {
            string procedure = "dbo.InvoiceItems_Insert";
            GetPropertiesToUpdate(ref procedure,newInvoiceItem);
            daInvoiceItems.PutItem(procedure, newInvoiceItem);
        }

        public void InvoiceItemDeleteByInvoiceID(int id)
        {
            daInvoiceItems.DeleteItems("dbo.InvoiceItems_deleteByInvoiceID @ID"
                , new { ID = id });
        }


    }
}
