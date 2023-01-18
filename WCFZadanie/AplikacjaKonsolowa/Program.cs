using System;
using AplikacjaKonsolowa.ServiceReference1;

namespace AplikacjaKonsolowa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyServiceClient myServiceClient = new MyServiceClient();
            string testEcho = myServiceClient.Echo("Testowa wiadomosc");
            Console.WriteLine(testEcho);

            string dateTime = myServiceClient.Date();
            Console.WriteLine(dateTime);

            string testUppercase = myServiceClient.Uppercase("Test Uppercase");
            Console.WriteLine(testUppercase);

            string testLowerCase = myServiceClient.Lowercase("Test Lowercase");
            Console.WriteLine(testLowerCase);
        }
    }
}
