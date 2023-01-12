using System;
using System.Diagnostics;
using System.ServiceProcess;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace ZarzadzanieUslugami
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ServiceController usluga;
        private ServiceControllerStatus stanUslugiController;
        public const string NazwaUslugi = "MojSerwis";

        private static EventLog dziennik;
        public const string NazwaDziennika = "LogB";
        public const string NazwaZrodla = "ZrodloB";

        private readonly DispatcherTimer dt;

        public MainWindow()
        {
            InitializeComponent();

            try
            {
                usluga = new ServiceController("MojSerwis");
                stanUslugiController = usluga.Status;

                NazwaUslugiTextBox.Text = usluga.DisplayName;
                StanUslugi.Text = stanUslugiController.ToString();

                // Dostepnosc przyciskow w zaleznosci od stanu uslugi
                if (stanUslugiController == ServiceControllerStatus.Running)
                {
                    ZatrzymanieUslugi.IsEnabled = true;
                    UruchomUsluge.IsEnabled = false;
                }
                if (stanUslugiController == ServiceControllerStatus.Stopped)
                {
                    UruchomUsluge.IsEnabled = true;
                    ZatrzymanieUslugi.IsEnabled = false;
                }

                dt = new DispatcherTimer
                {
                    Interval = new TimeSpan(0, 0, 0, 0, 500)
                };
                dt.Tick += Dt_Tick;
                dt.Start();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            dziennik = new EventLog(NazwaDziennika);
        }

        private void Dt_Tick(object sender, EventArgs e)
        {
            usluga.Refresh();
            ServiceControllerStatus nowyStatus = usluga.Status;

            if (nowyStatus != stanUslugiController)
            {
                stanUslugiController = nowyStatus;
                StanUslugi.Text = nowyStatus.ToString();

                UruchomUsluge.IsEnabled = nowyStatus == ServiceControllerStatus.Stopped;
                ZatrzymanieUslugi.IsEnabled = nowyStatus == ServiceControllerStatus.Running;
            }
        }

        async private void UruchomUsluge_Click(object sender, RoutedEventArgs e)
        {
            UruchomUsluge.IsEnabled = false;
            usluga.Start();
            await Task.Factory.StartNew(() =>
            {
                usluga.WaitForStatus(ServiceControllerStatus.Running);
            });

            StanUslugi.Text = usluga.Status.ToString();
            ZatrzymanieUslugi.IsEnabled = true;
        }

        async private void ZatrzymanieUslugi_Click(object sender, RoutedEventArgs e)
        {
            ZatrzymanieUslugi.IsEnabled = false;
            usluga.Stop();
            await Task.Factory.StartNew(() =>
            {
                usluga.WaitForStatus(ServiceControllerStatus.Stopped);
            });

            StanUslugi.Text = usluga.Status.ToString();
            UruchomUsluge.IsEnabled = true;
        }

        private void WczytajButton_Click(object sender, RoutedEventArgs e)
        {
            WpisyDziennika.Items.Clear();

            foreach (EventLogEntry wpis in dziennik.Entries)
            {
                Wpis wpisDziennika = new Wpis()
                {
                    Tytul = wpis.Message,
                    Czas = wpis.TimeWritten
                };
                WpisyDziennika.Items.Add(wpisDziennika);
            }
        }

        private void WyczyscButton_Click(object sender, RoutedEventArgs e)
        {
            WpisyDziennika.Items.Clear();
        }
    }
}
