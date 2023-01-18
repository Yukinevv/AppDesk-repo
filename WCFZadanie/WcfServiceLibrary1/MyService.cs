using System;

namespace WcfServiceLibrary1
{
    public class MyService : IMyService
    {
        public string Echo(string message)
        {
            return message;
        }

        public string Date()
        {
            return DateTime.Now.ToString();
        }

        public string Uppercase(string message)
        {
            return message.ToUpper();
        }

        public string Lowercase(string message)
        {
            return message.ToLower();
        }
    }
}
