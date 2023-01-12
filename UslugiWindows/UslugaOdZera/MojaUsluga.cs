using System;
using System.Diagnostics;
using System.ServiceProcess;
using System.Threading;

namespace UslugaOdZera
{
    public class MojaUsluga : ServiceBase
    {
        public const string NazwaUslugi = "MojSerwis";

        private static EventLog dziennik;
        public const string NazwaDziennika = "LogB";
        public const string NazwaZrodla = "ZrodloB";

        private Timer t;

        public MojaUsluga()
        {
            this.ServiceName = NazwaUslugi;

            if (!EventLog.SourceExists(NazwaZrodla))
            {
                EventLog.CreateEventSource(NazwaZrodla, NazwaDziennika);
            }

            dziennik = new EventLog(NazwaDziennika, ".", NazwaZrodla);
        }

        protected override void OnStart(string[] args)
        {
            dziennik.WriteEntry("Uruchomienie usługi");
            TimeSpan polMinuty = new TimeSpan(0, 0, 30);
            t = new Timer(o => {
                dziennik.WriteEntry("Minęło (kolejne) pół minuty działania usługi");
            }, null, polMinuty, polMinuty);
        }

        protected override void OnStop()
        {
            dziennik.WriteEntry("Zatrzymanie usługi");
            t.Dispose();
        }
    }
}