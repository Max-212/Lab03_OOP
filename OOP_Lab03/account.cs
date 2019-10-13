using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab03
{
    partial class Account
    {
        // поля
        private readonly string log;
        public string Log
        {
            get
            {
                return log;
            }
        }
        private string password;
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (value.Length >= 8)
                {
                    password = value;
                }
            }
        }
        public static string Default_password;

        // методы
        public static string getRandomPassword()
        {
            
            Random rnd = new Random((int)DateTime.Now.Ticks);
            string letters = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm1234567890";
            int len = 10;
            string pass = "";
            for(int i =0; i<len; i++)
            {
                pass += letters[rnd.Next(letters.Length)];
            }

            return pass;
        }
        // переопределение базовых методов 
        public override string ToString()
        {
            return "Логин: " + log + "\nПароль: " + password +"\n";
        }
        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;
            Account m = obj as Account;
            if (m as Account == null)
                return false;
            return m.log == this.log && m.password == this.password;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        
    }
}
