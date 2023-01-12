using System.ServiceProcess;
using UslugaOdZera;

namespace MojaPierwszaUsluga
{
    static class Program
    {
        static void Main()
        {
            //ServiceBase[] ServicesToRun;
            //ServicesToRun = new ServiceBase[]
            //{
            // new MojaUsluga()
            //};
            //ServiceBase.Run(ServicesToRun);
            ServiceBase.Run(new MojaUsluga());
        }
    }
}
