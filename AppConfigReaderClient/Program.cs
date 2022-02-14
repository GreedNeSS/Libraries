using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AppConfigReaderClient
{
    class Program
    {
        static void Main(string[] args)
        {
            AppSettingsReader ar = new AppSettingsReader();
            int numberOfTime = (int)ar.GetValue("RepeatCount", typeof(int));
            string color = (string)ar.GetValue("TextColor", typeof(string));

            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color);

            for (int i = 0; i < numberOfTime; i++)
            {
                Console.WriteLine("Hello World!");
            }

            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
