using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_EventsLib
{
    public class Conversies
    {
        public static double MijlNaarKm(double mijl)
        {
            return mijl * 1.609344;
        }

        public static double CelciusNaarKelvin(double celcius)
        {
            return celcius + 274.15;
        }
    }
}
