using System.ServiceModel;
using System.ServiceProcess;
using WcfServiceLibrary1;

namespace Usluga
{
    public partial class Service1 : ServiceBase
    {
        private ServiceHost serviceHost = null;

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            serviceHost?.Close();
            serviceHost = new ServiceHost(typeof(MyService));
            serviceHost.Open();
        }

        protected override void OnStop()
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
                serviceHost = null;
            }
        }
    }
}
