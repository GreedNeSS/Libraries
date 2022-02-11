using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarLibrary;

namespace CSharpCarClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***C# CarLibrary Client App ***");

            SportCar viper = new SportCar("Viper", 240, 40);
            viper.TurboBust();

            MiniVan miniVan = new MiniVan();
            miniVan.TurboBust();
        }
    }
}
