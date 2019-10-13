using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab03
{

    


    class Collection
    {
        private static Collection item = null;

        private List<Account> collection { get; set; }
        public void Add(Account account)
        {
            collection.Add(account);
        }
        public void Remove(int index)
        {
            collection.RemoveAt(index);
        }
        public int Count
        {
            get
            {
                return collection.Count();
            }
        }
        private Account acc_default = new Account("None", "None");
        // индексатор
        public Account this[int index]
        {
            get
            {
                if(index < Count)
                    return collection[index];
                return acc_default;
            }
            set
            {
                if(index < Count)
                    collection[index] = value;
            }
        }
         
        private Collection()
        {
            collection = new List<Account>();
        }
        public static Collection Initialyze()
        {
            if (item == null)
                item = new Collection();
            return item;
        }
    }



}
