using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Manager
{
    class Account
    {
        public string AccountNo { get; set; }
        public string AccountName { get; set; }
        public string Address { get; set; }
        public double Balance { get; set; }

        public Account() { }
        public Account(string accountno, string accountname, string address, double balance)
        {
            AccountNo = accountno;
            AccountName = accountname;
            Address = address;
            Balance = balance;
        }
    }
}
