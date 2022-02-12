using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarLibrary;

namespace SharedCarLibClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Shared Assembly Client *****");

            SportCar sportCar = new SportCar("Viper", 240, 50);
            sportCar.TurboBust();
            sportCar.TurnOnRadio(true, MusicMedia.musicWiFI);

            Console.ReadLine();
        }
    }
}
