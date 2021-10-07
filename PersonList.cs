using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;

namespace Dflat
{
    public class PersonList
    {
        List<User> userList = new List<User>
        {

        };

        public void SaveUser()
        {
            userList.Add(new User());
        }
    }
}
