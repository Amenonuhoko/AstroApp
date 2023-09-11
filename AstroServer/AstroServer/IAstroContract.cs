using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using AstroMath;

namespace IAstroContract
{
    [ServiceContract]
    internal interface IAstroContract
    {
        [OperationContract]
        double StarVelocity(double oWavelength, double rWavelength);

        [OperationContract]
        double StarDistance(double angle);

        [OperationContract]
        double TempInKelvin(double celcius);

        [OperationContract]
        double EventHorizon(double mass);

    }
}
