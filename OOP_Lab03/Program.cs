using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab03
{

 


    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Account Max = new Account("Maxim", Account.Default_password);
            Account Petr = new Account("Petr", "753951");
            
            var Styr = new { log = "Styr", password = Account.getRandomPassword()};

            Collection collection = Collection.Initialyze();
            collection.Add(Max);
            collection.Add(Petr);

            account_out.Out(collection[0]);
            account_out.Out(collection[1]);
            account_out.Out(collection[2]);






        }
    }
}
