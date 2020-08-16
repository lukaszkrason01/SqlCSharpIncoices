using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace FormUI
{
    class DataAccess
    {
        public List<People> GetPeople(string lastName)
        {
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConVal("SampleDB")))
            {
                connection.Open();
                var result = connection.Query<People>("dbo.People_getByLastName @LastName" , new { LastName = lastName }).ToList();

                return result;  
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
