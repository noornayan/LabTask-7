using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public abstract class  Account
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public double Balance { get; set; }
        public int  Tenure{ get; set; }
        public int  Created{ get; set; }
        public int  Monthly{ get; set; }

        public Account(string name, int id, double balance,int monthly)
        {
            Name = name;
            Id = id;
            Balance = balance;
            Monthly=monthly;
        }

        public Account(string name, int id, double balance,int created,int tenure)
        {
            Name = name;
            Id = id;
            Balance = balance;
            Created=created;
            Tenure=tenure;
        }

        public void Showinfo()
        {
            Console.WriteLine("Name = " + Name);
            Console.WriteLine("ID = " + Id);
        }
        public abstract void withdrawing(int withdraw);
    }
}