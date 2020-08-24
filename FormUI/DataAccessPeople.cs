using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace FormUI
{

    enum INVOICETABLE
    {
        GetAll = -1,
        GetByID = 0
    }

    enum TABLES
    {
        Company,
        Product
    }

    //zrób osobną przestrzeń nazw osobno wszystkie klasy a później managera klas

    abstract class DBAccess
    {
        protected enum TABLE
        {
            Company,
            Product,
            Vatrate,
            JM,
            Invoice
        }

        private readonly static string database = Helper.ConVal("SampleDB");

        protected ICollection GetData (TABLE t, string procedure)
        {
            string[] ad = null;
            return GetData(t, procedure, ad);
        }

        protected ICollection GetData(TABLE t, string procedure, string condition)
        {

            return GetData(t,procedure, new string[] { condition });
        }

        protected ICollection GetData(TABLE t,string procedure, string[] conditions)
        {
            string sql = procedure;
            if(conditions != null)
                foreach (var item in conditions)
                {
                    sql = sql + " '" + item + "'";
                }

            using (SqlConnection connection = new SqlConnection(database))
            {
                connection.Open();

                switch (t)
                {
                    case TABLE.Company:
                        return connection.Query<Company>(sql).ToList();
                    case TABLE.Product:
                        return connection.Query<Product>(sql).ToList();
                    case TABLE.Vatrate:
                        return MakeDictionaryVint(connection, sql);
                    case TABLE.JM:
                        return MakeDictionaryVstring(connection, sql);
                    case TABLE.Invoice:
                        return connection.Query<Invoice>(sql).ToList();
                    default:
                        break;
                }
                return null;
            }
        }

        private IDictionary MakeDictionaryVint(SqlConnection connection,string procedure)
        {
            using (SqlCommand command = new SqlCommand(procedure, connection))
            {
                Dictionary<int, int> result = new Dictionary<int, int>();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(reader.GetInt32(0), reader.GetInt32(1));
                    }
                }
                return result;
            }
        }

        private IDictionary MakeDictionaryVstring(SqlConnection connection, string procedure)
        {
            using (SqlCommand command = new SqlCommand(procedure, connection))
            {
                Dictionary<int, string> result = new Dictionary<int, string>();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(reader.GetInt32(0), reader.GetString(1)); 
                    }
                }
                return result;
            }
        }
        protected void ExecuteOnData(string procedure)
        {
            using (SqlConnection connection = new SqlConnection(database))
            {
                connection.Open();
                connection.Execute(procedure);
            }
        }

    }
    class DBAccessVatRates: DBAccess
    {
        private readonly TABLE table = TABLE.Vatrate;

        private Dictionary<int,int> GetVatrates(string procedure)
        {
            return (Dictionary<int,int>)GetData(table, procedure);
        }
        public Dictionary<int,int> GetAll()
        {
            return GetVatrates("dbo.vatrate_getAll");
        }
    }

    class DbAccessJM : DBAccess
    {
        private readonly TABLE table = TABLE.JM;

        private Dictionary<int,string> GetJMS(string procedure)
        {
            return (Dictionary<int, string>)GetData(table, procedure);
        }
        public Dictionary<int,string> GetAll(){
            return GetJMS("dbo.jm_getAll");
        }
    }

    class DBAccessInvoice : DBAccess
    {
        private readonly TABLE table = TABLE.Invoice;

        private List<Invoice> GetInvoices(string procedure)
        {
            return (List<Invoice>)GetData(table, procedure);
        }
        private List<Invoice> GetInvoices(string procedure,string condition)
        {
            return (List<Invoice>)GetData(table, procedure,condition);
        }

        private List<Invoice> GetInvoices(string procedure, string[] conditions)
        {
            return (List<Invoice>)GetData(table, procedure, conditions);
        }
        public int GetInvoiceNumber()
        {
            using (SqlConnection connection = new SqlConnection(Helper.database))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("dbo.Invoices_getInvoiceNumber", connection))
                {
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public List<Invoice> GetAll()
        {
            return GetInvoices("dbo.Invoices_getAll");
        }
        public List<Invoice> GetByID(int id)
        {
            return GetByID(id.ToString());
        }

        public List<Invoice> GetByID(string id)
        {
            return GetInvoices("dbo.Invoices_getByID", id);
        }
    }
    class DBAccesCompanies : DBAccess
    {
        private readonly TABLE table = TABLE.Company;
        private enum GETMETHOD
        {
            ByID = 0,
            ByName = 1,
            ByStreet = 2,
            ByZipCode = 3,
            ByCity = 4,
            ByNip = 5
        }

        private List<Company> GetCompanies(string procedure)
        {
            return (List<Company>)GetData(table,procedure);
        }

        private List<Company> GetCompanies(string procedure, string condition)
        {
            return (List<Company>)GetData(table, procedure, condition);
        }
        private List<Company> GetCompanies(string procedure, string[] conditions)
        {
            return (List<Company>)GetData(table, procedure, conditions);
        }

        public void UpdateCompany(Company company)
        {
            string procedure = $"dbo.Companies_updateByID {company.ID},'{company.Name}', " +
               $"'{company.Street}', '{company.ZipCode}', '{company.City}', '{company.NIP}'";
            ExecuteOnData(procedure);
        }

        public void InsertCompany(Company newCompany)
        {
            string procedure = $"dbo.Companies_insert '{newCompany.Name}', " +
                $"'{newCompany.Street}', '{newCompany.ZipCode}', '{newCompany.City}', '{newCompany.NIP}'";
                           
            ExecuteOnData(procedure);
        }

        public List<Company> GetAll()
        {
            return GetCompanies("dbo.Companies_getAll"); 
        }
        public Company GetByID(string id)
        {
            return GetCompanies("dbo.Companies_getByID", id)[0];
        }

        public Company GetByID(int id)
        {
            return GetByID(id.ToString());
        }

        public List<Company> GetByName(string name)
        {
            return GetCompanies("dbo.Companies_getByName", name);
        }

        public List<Company> GetByStreet(string street)
        {
            return GetCompanies("dbo.Companies_getByStreet", street);
        }

        public List<Company> GetByCity(string city)
        {
            return GetCompanies("dbo.Companies_getByCity", city);
        }
        public List<Company> GetByZipCode(string zipcode)
        {
            return GetCompanies("dbo.Companies_getByZipCode", zipcode);
        }
        public List<Company> GetByNip(string nip)
        {
            return GetCompanies("dbo.Companies_getByNip", nip);
        }

        public List<Company> GetByColumnNumber(int column, string condition)
        {
            GETMETHOD t = (GETMETHOD)column;
            List<Company> result = null;

            switch (t)
            {
                case GETMETHOD.ByID:
                    result = new List<Company>();
                    result.Add(GetByID(condition));
                    break;
                case GETMETHOD.ByName:
                    result = GetByName(condition);
                    break;
                case GETMETHOD.ByStreet:
                    result = GetByStreet(condition);
                    break;
                case GETMETHOD.ByZipCode:
                    result = GetByZipCode(condition);
                    break;
                case GETMETHOD.ByCity:
                    result = GetByCity(condition);
                    break;
                case GETMETHOD.ByNip:
                    result = GetByNip(condition);
                    break;
                default:
                    break;
            }
            return result;
        }
    }

    class DBAccessProduct :DBAccess
    {
        private readonly TABLE table = TABLE.Product;
        private enum GETMETHOD
        {
            ByID = 0,
            ByName = 1,
        }

        private List<Product> GetProducts(string procedure)
        {
            return (List<Product>)GetData(table, procedure);
        }

        private List<Product> GetProducts(string procedure, string condition)
        {
            return (List<Product>)GetData(table, procedure, condition);
        }

        public void UpdateProduct(Product product)
        {
            string procedure = $"dbo.Products_updateByID {product.ID},'{product.Name}'," +
                $"{product.Jm},{product.Vat},{product.Price.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("en-GB"))}";
            ExecuteOnData(procedure);
        }   

        public void InsertProduct(Product newProduct)
        {
            string procedure = $"dbo.Products_insert '{newProduct.Name}',{newProduct.Jm},{newProduct.Vat}" +
                $",'{newProduct.Price}'";
            ExecuteOnData(procedure);
        }
        public List<Product> GetAll()
        {
            return GetProducts("dbo.Products_getAll");
        }

        public Product GetByID(string id)
        {
            return GetProducts("dbo.Products_getByID", id)[0];
        }

        public Product GetByID(int id)
        {
            return GetByID(id.ToString());
        }
        public List<Product> GetByName(string name)
        {
            return GetProducts("dbo.Products_getByName", name);
        }
    }




    static class DataAccessGetSmallTables
    {
        public static Dictionary<int, string> GetPaymentMethodS()
        {
            using (SqlConnection connection = new SqlConnection(Helper.ConVal("SAmpleDB")))
            {
                Dictionary<int, string> result = new Dictionary<int, string>();
                connection.Open();
                using (SqlCommand command = new SqlCommand("dbo.PaymentMethod_getAll", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(reader.GetInt32(0), reader.GetString(1));
                        }
                    }
                }
                return result;
            }
        }
        
    }



    class DataAccesss
    {
        public List<People> GetPeople(string lastName,int c)
        {
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConVal("SampleDB")))
            {
                List<People> result =null;
                connection.Open();
                switch (c)
                {
                    case 0:
                        result = connection.Query<People>("dbo.People_getByFirstName @FirstName", new { FirstName = lastName }).ToList();
                        break;
                    case 1:
                        result = connection.Query<People>("dbo.People_getByLastName @LastName", new { LastName = lastName }).ToList();
                        break;
                    case 3:
                        result = connection.Query<People>("dbo.People_getByID @ID", new { ID = lastName }).ToList();
                        break;
                    default:
                        break;
                }

                return result;  
            }
        }

        public void UpdateByID(People up)
        {
            using(SqlConnection connection = new SqlConnection(Helper.ConVal("SampleDB")))
            {
                connection.Open();
                connection.Execute("dbo.People_updateByID @ID,@FirstName, @LastName, @Email,@Phone", up);
            }
        }

        public List<People> GetPeople()
        {
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConVal("SampleDB")))
            {
                connection.Open();
                var result = connection.Query<People>("dbo.People_getAll").ToList();

                return result;
            }
        }

        public void insertPerson(string strFirstName, string strLastName, string strEmail, string strPhone)
        {
            using ( IDbConnection connection = new SqlConnection(Helper.ConVal("SampleDB")))
            {
                connection.Open();
                People newPerson = new People
                {
                    FirstName = strFirstName,
                    LastName = strLastName,
                    Email = strEmail,
                    Phone = strPhone
                };
                List < People > people = new List<People>();
                people.Add(newPerson);

                connection.Execute("dbo.People_insert @FirstName, @LastName, @Email,@Phone", people); 
            }
        }
    }
}
