using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    class People
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public string FullInfo
        {
            get { return $"{FirstName} {LastName} ({Email})"; }
        }

        public string[] data()
        {
            return new string[] { FirstName, LastName, Email, Phone };
        }
    }
}
