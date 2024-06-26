﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MC.WebWCF
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ServiceResponseBase", Namespace="http://schemas.datacontract.org/2004/07/MC.Infrastructure.Messaging")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MC.WebWCF.GetGenresResponse))]
    public partial class ServiceResponseBase : object
    {
        
        private MC.WebWCF.BusinessStatusCodeEnum StatusCodeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MC.WebWCF.BusinessStatusCodeEnum StatusCode
        {
            get
            {
                return this.StatusCodeField;
            }
            set
            {
                this.StatusCodeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetGenresResponse", Namespace="http://schemas.datacontract.org/2004/07/MC.Infrastructure.Messaging.Responses.Gen" +
        "res")]
    public partial class GetGenresResponse : MC.WebWCF.ServiceResponseBase
    {
        
        private MC.WebWCF.GenreViewModel[] GenresField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MC.WebWCF.GenreViewModel[] Genres
        {
            get
            {
                return this.GenresField;
            }
            set
            {
                this.GenresField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BusinessStatusCodeEnum", Namespace="http://schemas.datacontract.org/2004/07/MC.Infrastructure.Messaging")]
    public enum BusinessStatusCodeEnum : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Success = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        InternalServerError = 1,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GenreViewModel", Namespace="http://schemas.datacontract.org/2004/07/MC.Infrastructure.Messaging.Responses.Gen" +
        "res")]
    public partial class GenreViewModel : object
    {
        
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MC.WebWCF.IGenresService")]
    public interface IGenresService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenresService/GetGenres", ReplyAction="http://tempuri.org/IGenresService/GetGenresResponse")]
        System.Threading.Tasks.Task<MC.WebWCF.GetGenresResponse> GetGenresAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface IGenresServiceChannel : MC.WebWCF.IGenresService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class GenresServiceClient : System.ServiceModel.ClientBase<MC.WebWCF.IGenresService>, MC.WebWCF.IGenresService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public GenresServiceClient() : 
                base(GenresServiceClient.GetDefaultBinding(), GenresServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IGenresService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public GenresServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(GenresServiceClient.GetBindingForEndpoint(endpointConfiguration), GenresServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public GenresServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(GenresServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public GenresServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(GenresServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public GenresServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<MC.WebWCF.GetGenresResponse> GetGenresAsync()
        {
            return base.Channel.GetGenresAsync();
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IGenresService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IGenresService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:5036/GenresService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return GenresServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IGenresService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return GenresServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IGenresService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IGenresService,
        }
    }
}
