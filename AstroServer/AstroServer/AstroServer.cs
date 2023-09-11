using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using AstroMath._4._7._2;

namespace IAstroContract
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    internal class AstroServer : IAstroContract
    {
        public double StarVelocity(double oWavelength, double rWavelength)
        {
            return Calculate.StarVelocity(oWavelength, rWavelength);
        }
        public double StarDistance(double angle)
        {
            return Calculate.StarDistance(angle);
        }

        public double TempInKelvin(double celcius)
        {
            return Calculate.TempInKelvin(celcius);
        }

        public double EventHorizon(double mass)
        {
            return Calculate.EventHorizon(mass);
        }

        public int add()
        {
            return 2 + 2;
        }
    }
}
