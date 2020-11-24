using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class OverDraft : Account
    {
        public OverDraft(string name, int id, double balance,int monthly) : base(name, id, balance,monthly)
        {

        }
        public override void withdrawing(int withdraw)
        {
            if (withdraw>Balance)
            {
                double overdraft = Balance * 0.15;
                Balance = Balance + overdraft;

                if (withdraw<=Balance)
                {
                  Balance = Balance - withdraw;
                    Console.WriteLine("Transaction Executed!!!");
                    Console.WriteLine(Name+" has a due of "+overdraft+" Taka");
                }
                else
                    Console.WriteLine("Sorry transaction can't be completed because its exceed the limits of loan");
            }
            else
            Balance = Balance - withdraw;
            Console.WriteLine("New Balance : "+Balance);
        }

    }
}