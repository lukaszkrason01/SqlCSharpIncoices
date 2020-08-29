using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Management.Instrumentation;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
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
    interface IDBAccessDataToList<T> where T:IEntyty
    {
        List<T> GetData(string procedure);
        List<T> GetData(string procedure, string condition);
    }

    class DBAACess<T> where T : IEntyty
    {
        private readonly string database;

        public DBAACess(string DB) => database = DB;

        public List<T> GetList(string procedure, object param = null)
        {

            using (SqlConnection connection = new SqlConnection(database))
            {
                connection.Open();
                return connection.Query<T>(procedure,param).ToList();

            }
        }

        public T GetItem(string procedure, object param)
        {
            using(SqlConnection connection = new SqlConnection(database))
            {

                return connection.QuerySingle<T>(procedure, param);
            }
        }

        public void PutItem(string procedure , T item)
        {
            using(SqlConnection connection = new SqlConnection(database))
            {
                connection.Open();
                connection.Execute(procedure,item);
            }
        }

        public void DeleteItems(string procedure, object param)
        {
            using(SqlConnection connection = new SqlConnection(database))
            {
                connection.Open();
                connection.Execute(procedure,param);
            }
        }

        public int ExecuteScalar(string procedure)
        {
            using (SqlConnection connection = new SqlConnection(database))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(procedure, connection))
                {
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public int PutItemAndGetID(string procedure,T item)
        {
            using (SqlConnection connection = new SqlConnection(database))
            {
                connection.Open();
                return connection.QuerySingle<int>(procedure, item);
            }
        }
    }

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
