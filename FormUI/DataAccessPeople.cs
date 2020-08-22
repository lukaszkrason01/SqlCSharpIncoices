using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
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
            Product
        }

        private readonly static string database = Helper.ConVal("SampleDB");

        protected IList GetData (TABLE t, string procedure)
        {
            return GetData(t, procedure, new string[] { "" });
        }

        protected IList GetData(TABLE t, string procedure, string condition)
        {

            return GetData(t,procedure, new string[] { condition });
        }

        protected IList GetData(TABLE t,string procedure, string[] conditions)
        {
            string sql = procedure;
            foreach(var item in conditions)
            {
                sql = sql + " " + item;
            }
            using (SqlConnection connection = new SqlConnection(database))
            {
                connection.Open();

                switch (t)
                {
                    case TABLE.Company:
                        List<Company> result = new List<Company>();
                        return connection.Query<Company>(sql).ToList();
                    case TABLE.Product:
                        break;
                    default:
                        break;
                }

                
                return null;
            }
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

        public List<Company> GetAll()
        {
            return GetCompanies("dbo.Companies_getAll"); 
        }
        public Company GetByID(string id)
        {
            return GetCompanies("dbo.Companies_getByID", id)[0];
        }

        public Company SelectByID(int id)
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

    public static class DataAccessGetCompanies
    {
        private enum GETMETHOD
        {
            All = -1,
            ByID = 0,
            ByName = 1,
            ByStreet = 2,
            ByZipCode = 3,
            ByCity = 4,
            ByNip = 5
        }

        public static Company SelectByID(string id)
        {
            return getCompanies(GETMETHOD.ByID, id )[0];
        }

        public static Company SelectByID(int id)
        {
            return SelectByID(id.ToString());
        }

        public static List<Company> SelectByName(string name)
        {
            return getCompanies(GETMETHOD.ByName,  name);
        }

        public static List<Company> SelectByStreet(string street)
        {
            return getCompanies(GETMETHOD.ByStreet, street);
        }

        public static List<Company> SelectByCity(string city)
        {
            return getCompanies(GETMETHOD.ByCity,city );
        }
        public static List<Company> SelectByZipCode(string zipcode)
        {
            return getCompanies(GETMETHOD.ByZipCode,  zipcode );
        }
        public static List<Company> selectByNip(string nip)
        {
            return getCompanies(GETMETHOD.ByNip, nip);
        }

        public static List<Company> selectByColumnNumber(int column,string condition)
        {
            GETMETHOD t = (GETMETHOD)column;
            return getCompanies(t, condition);
        }
        private static List<Company> getCompanies(GETMETHOD t, string condition)
        {
            return getCompanies(t, new string[] { condition });
        }

        private static List<Company> getCompanies(GETMETHOD t, string[] condition)
        {
            using (SqlConnection connection = new SqlConnection(Helper.database))
            {
                List<Company> result = new List<Company>();
                connection.Open();
                switch (t)
                {
                    case GETMETHOD.All:
                        result = connection.Query<Company>("dbo.Companies_getAll").ToList();
                        break;
                    case GETMETHOD.ByID:
                        result = connection.Query<Company>("dbo.Companies_getByID @c"
                            , new { c = condition[0] }).ToList();
                        break;
                    case GETMETHOD.ByName:
                        result = connection.Query<Company>("dbo.Companies_getByName @c"
                            , new { c = condition[0] }).ToList();
                        break;
                    case GETMETHOD.ByStreet:
                        result = connection.Query<Company>("dbo.Companies_getByStreet @c"
                            , new { c = condition[0] }).ToList();
                        break;
                    case GETMETHOD.ByZipCode:
                        result = connection.Query<Company>("dbo.Companies_getByZipCode @c"
                            , new { c = condition[0] }).ToList();
                        break;
                    case GETMETHOD.ByCity:
                        result = connection.Query<Company>("dbo.Companies_getByCity @c"
                            , new { c = condition[0] }).ToList();
                        break;
                    case GETMETHOD.ByNip:
                        result = connection.Query<Company>("dbo.Companies_getByNip @c"
                            , new { c = condition[0] }).ToList();
                        break;
                    default:
                        break;
                }
                return result;
            }
        }
    }

    public static class DataAccessGetProducts
    {
        enum GETMETHOD
        {
            All = -1,
            ByID = 0,
            ByName = 1,
        }
        public static List<Product> SelectAll()
        {
            return GetProducts(GETMETHOD.All, "");
        }

        public static Product SelectByID(string id)
        {
            return GetProducts(GETMETHOD.ByID, id)[0];
        }

        public static Product SelectByID(int id)
        {
            return SelectByID(id.ToString());
        }
        public static List<Product> SelectByName(string name)
        {
            return GetProducts(GETMETHOD.ByName, name);
        }

        private static List<Product> GetProducts(GETMETHOD t, string condition)
        {
            return GetProducts(t, new string[] { condition });
        }
        private static List<Product> GetProducts(GETMETHOD t, string[] condition)
        {
            using (SqlConnection connection = new SqlConnection(Helper.ConVal("SampleDb")))
            {
                connection.Open();
                List<Product> result = null;
                switch (t)
                {
                    case GETMETHOD.All:
                        result = connection.Query<Product>("dbo.Products_getAll").ToList();
                        break;
                    case GETMETHOD.ByID:
                        result = connection.Query<Product>("dbo.Products_getByID @c"
                            , new { c = condition[0] }).ToList();
                        break;
                    case GETMETHOD.ByName:
                        result = connection.Query<Product>("dbo.Products_getByName @c"
                            , new { c = condition[0] }).ToList();
                        break;
                    default:
                        break;
                }
                return result;
            }
        }
    }

    static class DataAccessGetSmallTables
    {

        public static string SelectJMByID(int id)
        {
            return GetDataByID("dbo.jm_get_ByID", id.ToString());
        }

        public static string SelectVatRateByID(int id)
        {
            return GetDataByID("dbo.vatrate_getByID", id.ToString());
        }

        private static dynamic GetDataByID(string procedure,string id)
        {
            string exec = procedure + " " + id;
            using(SqlConnection connection = new SqlConnection(Helper.database))
            {
                connection.Open();


                connection.Query(procedure);
            }
            return null;
        }




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
        public static Dictionary<int, int> GetVatRates()
        {
            using (SqlConnection connection = new SqlConnection(Helper.ConVal("SAmpleDB")))
            {
                Dictionary<int, int> result = new Dictionary<int, int>();
                connection.Open();
                using (SqlCommand command = new SqlCommand("dbo.vatrate_getAll", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(reader.GetInt32(0), reader.GetInt32(1));
                        }
                    }
                }
                return result;
            }
        }
        public static Dictionary<int, string> GetJMs()
        {
            using (SqlConnection connection = new SqlConnection(Helper.ConVal("SAmpleDB")))
            {
                Dictionary<int, string> result = new Dictionary<int, string>();
                connection.Open();
                using (SqlCommand command = new SqlCommand("dbo.jm_getAll", connection))
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



    class DataAccess
    {

        public int GetInvoiceNumber()
        {
            using (SqlConnection connection = new SqlConnection(Helper.database))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("dbo.Invoices_getInvoiceNumber",connection))
                {
                    return (int)command.ExecuteScalar();
                }
            }
        }
        
        public void InsertData(TABLES t,IEntyty c)
        {
            using(SqlConnection connection = new SqlConnection(Helper.ConVal("SampleDB")))
            {
                connection.Open();
                switch (t)
                {
                    case TABLES.Company:
                        connection.Execute("dbo.Companies_insert @Name, @Street, @ZipCode, @City, @NIP", (Company) c);
                        break;
                    case TABLES.Product:
                        connection.Execute("dbo.Products_insert @Name,@Jm,@Vat,@Price"
                            , (Product)c);
                        break;
                    default:
                        break;
                }
            }
        }

        public void UpdateData(TABLES t, IEntyty c)
        {
            using(SqlConnection connection = new SqlConnection(Helper.ConVal("SampleDB")))
            {
                connection.Open();
                switch (t)
                {
                    case TABLES.Company:
                        connection.Execute("dbo.Companies_updateByID @ID,@Name,@Street,@ZipCode,@City,@Nip"
                            ,(Company)c);
                        break;
                    case TABLES.Product:
                        connection.Execute("dbo.Products_updateByID @ID,@Name,@Jm,@Vat,@Price"
                            , (Product)c);
                        break;
                    default:
                        break;
                }
            }
        }
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

        public List<Invoice> GetAllInvoices()
        {
            return GetInvoices(INVOICETABLE.GetAll,"");
        }

        public List<Invoice> GetInvoices(INVOICETABLE t , string condition)
        {
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConVal("SampleDB")))
            {
                List<Invoice> result = null;
                connection.Open();
                switch (t)
                {
                    case INVOICETABLE.GetAll:
                        result = connection.Query<Invoice>("dbo.Invoices_getAll").ToList();
                        break;
                    case INVOICETABLE.GetByID:
                        result = connection.Query<Invoice>("dbo.Invoices_getByID @ID", new { ID = condition }).ToList();
                        break;
                    default:
                        break;
                }
                return result;
            }
        }
    }
}
