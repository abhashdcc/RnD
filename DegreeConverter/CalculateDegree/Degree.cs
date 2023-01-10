using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateDegree
{
    public class Degree
    {
        public double ToFahrenheit(double celcius)
        {
            return (celcius * 9 / 5) + 32;
        }

        public double ToCelcius(double fahrenheit)
        {
            return (32 * fahrenheit - 32) * 5 / 9;
        }
    }
}
