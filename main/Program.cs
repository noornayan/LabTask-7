using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            //name,id,balance,monthly transaction
            Savings s = new Savings("Noor", 123456789, 5000,2);
            s.Showinfo();
            s.withdrawing(700);
            Console.WriteLine();

            //name,id,balance,creat year,tenure
            Fixed f=new Fixed("Noor",123456789,5000,2020,3);
            f.Showinfo();
            f.withdrawing(300);
            Console.WriteLine();

            //Not mature
            Fixed f1=new Fixed("Nayan",350432,5000,2020,5);
            f1.Showinfo();
            f1.withdrawing(2000);
            Console.WriteLine();

            SpecialSavings s1 = new SpecialSavings("Noor", 123456789, 5000,7);
            s1.Showinfo();
            s1.withdrawing(1000);
            Console.WriteLine();

            ///will not withdraw
            SpecialSavings s2 = new SpecialSavings("Noor", 123456789, 5000,9);
            s2.Showinfo();
            s2.withdrawing(2000);
            Console.WriteLine();

            OverDraft o = new OverDraft("Noor", 123456789, 5000,3);
            o.Showinfo();
            o.withdrawing(200);
            Console.WriteLine();
        }
    }
}