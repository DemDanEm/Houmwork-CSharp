using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Basics1.Definers;

namespace Basics1.Presentation
{
    internal class DefinerMenu
    {
        public static void begin()
        {
            Console.WriteLine("Select an Action:\n1.Define Weather\n2.Define Temperature\n 3.Exit");
            while (true)
            {
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();

                if (consoleKeyInfo.KeyChar != '1' || consoleKeyInfo.KeyChar != '2' || consoleKeyInfo.KeyChar != '3')
                    switch (consoleKeyInfo.KeyChar)
                    {
                        case '1':

                            Console.Write("Enter Weather: ");
                            string str = Console.ReadLine();
                            Console.WriteLine("Weather is " + WeatherDefiner.define(double.Parse(str)));
                            break;

                        case '2':
                            {
                                Console.Write("Enter Temperature: ");
                                str = Console.ReadLine();
                                Console.WriteLine("Temperature is " + TeperatureDefiner.define(double.Parse(str)));
                                break;
                            }
                        case '3':
                            {
                                System.Environment.Exit(1);
                                break;
                            }
                    }

            }
        }
    }
}
