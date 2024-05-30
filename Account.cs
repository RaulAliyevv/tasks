using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB201Task1
{
    public class Account
    {
        
       
    internal interface IAccount
        {
            public bool PasswordChecker(string password);

            public void ShowInfo();
        }
    }
}
