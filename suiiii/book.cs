using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suiiii
{
    public class Book
    {
        public void PrintInfo()
        {
            Console.WriteLine("Jeg er en bog");
    
        }


        public bool HarRåd(int price, int money)
        {
            return price <= money;
        }


    }
}
