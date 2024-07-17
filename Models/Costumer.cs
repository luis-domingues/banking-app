using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApp.Models
{
    public class Costumer
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private long DocumentNumber { get; set; }
        private DateTime DateOfBirth { get; set; }

        public string FullName(string fname, string lname)
        {
            this.FirstName = fname;
            this.LastName = lname;
            return fname + " " + lname;
        }

        public long GetDocNumber(long docNumber)
        {
            this.DocumentNumber = docNumber;
            return docNumber;
        }

        public DateTime GetDateOfBirth(DateTime dateTime)
        {
            this.DateOfBirth = dateTime;
            return this.DateOfBirth;
        }
    }
}