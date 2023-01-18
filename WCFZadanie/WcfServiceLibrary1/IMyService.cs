using System.ServiceModel;

namespace WcfServiceLibrary1
{
    [ServiceContract]
    public interface IMyService
    {
        [OperationContract]
        string Echo(string message);

        [OperationContract]
        string Date();

        [OperationContract]
        string Uppercase(string message);

        [OperationContract]
        string Lowercase(string message);
    }
}
