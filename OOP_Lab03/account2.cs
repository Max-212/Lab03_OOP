using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab03
{
    partial class Account
    {
        // конструкторы
        public Account(string log, string password)
        {
            this.log = log;
            this.password = password;
        }

        public Account()
        {
            log = "None";
            password = Default_password;
        }

        static Account()
        {
            Default_password = getRandomPassword();

        }

        public Account(Account acc)
        {
            log = acc.log;
            password = acc.password;
        }

        // деструктор
        ~Account()
        {
            Console.WriteLine("Объект уничтожен c логином {0} уничтожен", log);
        }
    }
}
