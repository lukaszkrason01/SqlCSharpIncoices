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
}
