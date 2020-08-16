using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    interface IDataAccess
    {
        IList getData(string lastName);
        IList getData();

        void insert(string[] str);
    }
}
