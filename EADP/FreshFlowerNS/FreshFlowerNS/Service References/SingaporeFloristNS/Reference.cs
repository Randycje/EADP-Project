﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FreshFlowerNS.SingaporeFloristNS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SingaporeFloristNS.IWsFreshFlowers")]
    public interface IWsFreshFlowers {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWsFreshFlowers/GetAllAccount", ReplyAction="http://tempuri.org/IWsFreshFlowers/GetAllAccountResponse")]
        System.Data.DataSet GetAllAccount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWsFreshFlowers/GetAllAccount", ReplyAction="http://tempuri.org/IWsFreshFlowers/GetAllAccountResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetAllAccountAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWsFreshFlowers/GetAllPOrders", ReplyAction="http://tempuri.org/IWsFreshFlowers/GetAllPOrdersResponse")]
        System.Data.DataSet GetAllPOrders();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWsFreshFlowers/GetAllPOrders", ReplyAction="http://tempuri.org/IWsFreshFlowers/GetAllPOrdersResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetAllPOrdersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWsFreshFlowers/getALLPayment", ReplyAction="http://tempuri.org/IWsFreshFlowers/getALLPaymentResponse")]
        System.Data.DataSet getALLPayment();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWsFreshFlowers/getALLPayment", ReplyAction="http://tempuri.org/IWsFreshFlowers/getALLPaymentResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> getALLPaymentAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWsFreshFlowers/ViewPayment", ReplyAction="http://tempuri.org/IWsFreshFlowers/ViewPaymentResponse")]
        System.Data.DataSet ViewPayment(int paymentID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWsFreshFlowers/ViewPayment", ReplyAction="http://tempuri.org/IWsFreshFlowers/ViewPaymentResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> ViewPaymentAsync(int paymentID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWsFreshFlowersChannel : FreshFlowerNS.SingaporeFloristNS.IWsFreshFlowers, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WsFreshFlowersClient : System.ServiceModel.ClientBase<FreshFlowerNS.SingaporeFloristNS.IWsFreshFlowers>, FreshFlowerNS.SingaporeFloristNS.IWsFreshFlowers {
        
        public WsFreshFlowersClient() {
        }
        
        public WsFreshFlowersClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WsFreshFlowersClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WsFreshFlowersClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WsFreshFlowersClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet GetAllAccount() {
            return base.Channel.GetAllAccount();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetAllAccountAsync() {
            return base.Channel.GetAllAccountAsync();
        }
        
        public System.Data.DataSet GetAllPOrders() {
            return base.Channel.GetAllPOrders();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetAllPOrdersAsync() {
            return base.Channel.GetAllPOrdersAsync();
        }
        
        public System.Data.DataSet getALLPayment() {
            return base.Channel.getALLPayment();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> getALLPaymentAsync() {
            return base.Channel.getALLPaymentAsync();
        }
        
        public System.Data.DataSet ViewPayment(int paymentID) {
            return base.Channel.ViewPayment(paymentID);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ViewPaymentAsync(int paymentID) {
            return base.Channel.ViewPaymentAsync(paymentID);
        }
    }
}