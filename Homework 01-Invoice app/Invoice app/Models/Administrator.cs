using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Administrator : Human
    {
        public string Company { get; set; }


        public Administrator(string username, string password, string company) : base(username, password, true)
        {
            Company = company;
        }


    }
}
