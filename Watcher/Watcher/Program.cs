using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Watcher
{
    internal class Program
    {
        private readonly string sciezka = ConfigurationManager.AppSettings["Sciezka"];
        private readonly string zrodlo = ConfigurationManager.AppSettings["Zrodlo"];
        private readonly string nazwaDziennika = ConfigurationManager.AppSettings["Dziennik"];
        private EventLog dziennik;
        private TraceSwitch ts;
        private int czasDzialania;

        public Program()
        {
            if (!EventLog.SourceExists(zrodlo, "."))
            {
                EventLog.CreateEventSource(zrodlo, nazwaDziennika);
            }

            dziennik = new EventLog(nazwaDziennika, ".", zrodlo);
            ts = new TraceSwitch("Logowanie", "przelacznik kontrolujacy rodzaj danych zapisywanych do dziennika", "Verbose");
        }

        public void Ustawienia()
        {
            czasDzialania = 30;
            int.TryParse(ConfigurationManager.AppSettings["Czas"], out czasDzialania);

            FileSystemWatcher fsw = new FileSystemWatcher(sciezka);
            fsw.IncludeSubdirectories = true;

            fsw.NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.LastWrite;

            if (ts.TraceInfo)
            {
                fsw.Changed += Fsw_ChangedCreatedDeleted;
            }
            if (ts.TraceWarning)
            {
                fsw.Renamed += Fsw_Renamed;
            }
            if (ts.TraceError)
            {
                fsw.Created += Fsw_ChangedCreatedDeleted;
                fsw.Deleted += Fsw_ChangedCreatedDeleted;
            }

            fsw.EnableRaisingEvents = true;
        }

        private void Fsw_Renamed(object sender, RenamedEventArgs e)
        {
            //Console.WriteLine("\"{0}\" was renamed - new name is {1}", e.OldName, e.Name);
            string wpis = $"{e.OldName} was renamed - new name is {e.Name}";
            dziennik.WriteEntry(wpis);
        }

        private void Fsw_ChangedCreatedDeleted(object sender, FileSystemEventArgs e)
        {
            //Console.WriteLine("\"{0}\" was {1} ", e.Name, e.ChangeType.ToString().ToLower());
            string wpis = $"{e.Name} was {e.ChangeType.ToString().ToLower()}";
            dziennik.WriteEntry(wpis);
        }

        private void Start()
        {
            DateTime startProgramu = DateTime.Now;
            Ustawienia();
            while ((DateTime.Now - startProgramu).TotalSeconds < czasDzialania)
            {
                Console.WriteLine($"Remain {Math.Ceiling(czasDzialania - (DateTime.Now - startProgramu).TotalSeconds)} seconds to end program");
                Thread.Sleep(10000);
            }
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Starting program...");
            program.Start();
            Console.WriteLine("Program has ended. Press any key to quit.");
            Console.ReadKey();
        }  
    }
}
