using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace FormUI
{
    enum SortingBy
    {
        FirstName = 0,
        Lastname = 1,
    }
    class DataAccess
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
