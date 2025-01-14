﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AplikacjaKonsolowa.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IMyService")]
    public interface IMyService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/Echo", ReplyAction="http://tempuri.org/IMyService/EchoResponse")]
        string Echo(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/Echo", ReplyAction="http://tempuri.org/IMyService/EchoResponse")]
        System.Threading.Tasks.Task<string> EchoAsync(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/Date", ReplyAction="http://tempuri.org/IMyService/DateResponse")]
        string Date();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/Date", ReplyAction="http://tempuri.org/IMyService/DateResponse")]
        System.Threading.Tasks.Task<string> DateAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/Uppercase", ReplyAction="http://tempuri.org/IMyService/UppercaseResponse")]
        string Uppercase(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/Uppercase", ReplyAction="http://tempuri.org/IMyService/UppercaseResponse")]
        System.Threading.Tasks.Task<string> UppercaseAsync(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/Lowercase", ReplyAction="http://tempuri.org/IMyService/LowercaseResponse")]
        string Lowercase(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/Lowercase", ReplyAction="http://tempuri.org/IMyService/LowercaseResponse")]
        System.Threading.Tasks.Task<string> LowercaseAsync(string message);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMyServiceChannel : AplikacjaKonsolowa.ServiceReference1.IMyService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MyServiceClient : System.ServiceModel.ClientBase<AplikacjaKonsolowa.ServiceReference1.IMyService>, AplikacjaKonsolowa.ServiceReference1.IMyService {
        
        public MyServiceClient() {
        }
        
        public MyServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MyServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Echo(string message) {
            return base.Channel.Echo(message);
        }
        
        public System.Threading.Tasks.Task<string> EchoAsync(string message) {
            return base.Channel.EchoAsync(message);
        }
        
        public string Date() {
            return base.Channel.Date();
        }
        
        public System.Threading.Tasks.Task<string> DateAsync() {
            return base.Channel.DateAsync();
        }
        
        public string Uppercase(string message) {
            return base.Channel.Uppercase(message);
        }
        
        public System.Threading.Tasks.Task<string> UppercaseAsync(string message) {
            return base.Channel.UppercaseAsync(message);
        }
        
        public string Lowercase(string message) {
            return base.Channel.Lowercase(message);
        }
        
        public System.Threading.Tasks.Task<string> LowercaseAsync(string message) {
            return base.Channel.LowercaseAsync(message);
        }
    }
}
