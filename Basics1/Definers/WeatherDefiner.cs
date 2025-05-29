using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Basics1.Definers
{
    internal class WeatherDefiner
    {

        public static string define(double val)
        {
            if (val<=0.1)
            {
                return "No Weather";
            }
            else if(val<=2.5)
            {
                return "Lil' Rain";
            }
            else if (val<=17)
            {
                return "Big Rain";
            }
            else
            {
                return "Mega Rain";
            }

        }
    }
}
