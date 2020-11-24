using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Fixed : Account
    {
        public int year=DateTime.Now.Year;

        public Fixed(string name, int id, double balance,int created,int tenure) : base(name, id, balance,created,tenure)
        {

        }
         public override void withdrawing(int withdraw)
         {
            if(year-Created>=Tenure)
                {
            if (withdraw <= Balance)
                    {
                        Balance = Balance - withdraw;
                        Console.WriteLine("Withdraw done");
                        Console.WriteLine("New Balance " + Balance);
                    }
            else
            {
                Console.WriteLine("Balance is Less then " + withdraw);
            }
            }
            else
            {
                Console.WriteLine("Account is not mature");
            }
         }
    }
}