using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Savings : Account
    {
        public Savings(string name, int id, double balance,int monthly) : base(name, id, balance,monthly)
        {

        }
        public override void withdrawing(int withdraw)
        {
            if (withdraw >= 500)
                {
                    if (withdraw <= Balance)
                    {
                        Balance = Balance - withdraw;
                        Console.WriteLine("Withdraw done");
                        Console.WriteLine("New Balance " + Balance);
                    }
                    else
                    {
                        Console.WriteLine("Balace is Less then " + withdraw);
                    }
                }
            else
                {
                    Console.WriteLine("Its less then 500");
                }
        }
    }
}