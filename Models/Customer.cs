using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Models
{
    internal class Customer
    {
        private string firstName;
        private string lastName;

        public string FullName(string fname, string lname)
        {
            this.firstName = fname;
            this.lastName = lname;           
            return fname + " " + lastName;
        }
    }
}
