using ConsoleApp2.net.azurewebsites.wsdlservice20190617081427;
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsOnSlae;
            int Amount;
            decimal Price;
            decimal wynik=0;


            WebService1 Discount = new WebService1();
            Console.WriteLine("Aplikacja kliencka do obliczania  wysokości rabatu");
            Console.WriteLine("Czy przedmiot jest na wyprzedaży wpisz 'true' 'false' ");
            IsOnSlae = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Podaj ilość");
             Amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj cene w zł");
             Price = Convert.ToDecimal(Console.ReadLine());
            try
            {
                 wynik = Discount.MaxDiscount(Amount, IsOnSlae, Price);
            }
            catch { }

            Console.WriteLine("Wysokość rabatu to : {0:C} zł",wynik);
            Console.ReadLine();


        }
    }
}
    