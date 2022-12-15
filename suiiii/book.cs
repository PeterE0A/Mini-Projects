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

        public int _price;
        public string _title;

        // Set and get methods for the price
        public void SetPrice(int price)
        {
            _price = price;
        }

        public int GetPrice()
        {
            return _price;
        }

        // Set and get methods for the title
        public void SetTitle(string title)
        {
            _title = title;
        }

        public string GetTitle()
        {
            return _title;
        }

        // Method to determine if we have enough money to buy the book
        public bool CanAffordBook(int money)
        {
            return money >= _price;
        }


        public Book(int price, string title )
        {
            this._title = title;
            this._price = price;
          
        }

        public void Reading()
        {
            Console.WriteLine("you are reading " + _title + " and it costs " + _price);
        }




    }
}
