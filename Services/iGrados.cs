using System;
using System.ServiceModel;

namespace grados
{
    [ServiceContract]
    public interface iGrados{
        [OperationContract]
        float CelciusFharenheit(int celcius);
        [OperationContract]
        float FharenheitCelcius(int fharenheit);
    }
}