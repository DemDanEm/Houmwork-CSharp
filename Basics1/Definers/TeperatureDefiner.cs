using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Basics1.Definers
{
    internal class TeperatureDefiner
    {
        public static string define(double val)
        {
            if (val < 10)
            {
                return "Cold";
            }
            else if (val < 25)
            {
                return "Just Right";
            }
            else
            {
                return "Hawt";
            }

            }
        }
    }
