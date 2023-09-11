using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ClientAstroApp
{
    [ServiceContract]
    public interface IAstroContract
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
