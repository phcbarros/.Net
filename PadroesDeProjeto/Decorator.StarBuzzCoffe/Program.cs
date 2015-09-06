using Decorator.StarBuzzCoffe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.StarBuzzCoffe
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Expresso();
            Console.WriteLine(beverage.GetDescription() + " R$" + beverage.Cost());
            Console.WriteLine();

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.GetDescription() + " R$" + beverage2.Cost());
            Console.WriteLine();

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.GetDescription() + " R$" + beverage3.Cost());
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
