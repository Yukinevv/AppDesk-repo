using System.ComponentModel;
using System.Configuration.Install;
using System.ServiceProcess;

namespace UslugaOdZera
{
    [RunInstaller(true)]
    public class ProjectInstaller : Installer
    {
        public ProjectInstaller()
        {
            ServiceProcessInstaller serviceProcessInstaller = new ServiceProcessInstaller();
            ServiceInstaller serviceInstaller = new ServiceInstaller();

            //serviceProcessInstaller.Account = ServiceAccount.LocalService;
            //serviceProcessInstaller.Account = ServiceAccount.User;

            serviceProcessInstaller.Account = ServiceAccount.LocalSystem;

            serviceInstaller.ServiceName = MojaUsluga.NazwaUslugi;
            serviceInstaller.StartType = ServiceStartMode.Manual;
            serviceInstaller.DisplayName = "Mój Pierwszy Serwis";
            serviceInstaller.Description = "Usluga tworzona na zajeciach";

            this.Installers.Add(serviceProcessInstaller);
            this.Installers.Add(serviceInstaller);
        }
    }
}