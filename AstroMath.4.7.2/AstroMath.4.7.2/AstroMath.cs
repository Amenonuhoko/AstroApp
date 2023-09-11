using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroMath._4._7._2
{
    public class Calculate
    {
        // TODO MORE ERROR TRAPPINGS

        public static double StarVelocity(double oWavelength, double rWavelength)
        {
            int speedOfLight = 299792458;

            double velocity = ((oWavelength - rWavelength) / rWavelength) * speedOfLight;

            return velocity;
        }

        public static double StarDistance(double angle)
        {
            if (angle == 0)
            {
                throw new ArgumentException("Cannot divide by zero");
            }
            else
            {
                return 1 / angle;
            }

        }

        public static double TempInKelvin(double celcius)
        {
            if (celcius >= -273)
            {
                return celcius + 273;
            }
            else
            {
                throw new ArgumentException("Temperature cannot be below -273degrees Celsius");
            }

        }

        public static double EventHorizon(double mass)
        {
            double g = 6.674e-11;
            double c = 299792458;

            double radius = (2 * g * mass) / (c * c);

            return radius;
        }
    }
}
