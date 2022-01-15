using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace LayerLogicData
{
    public class configServices
    {
        public ServiceReference.serviceitSoapClient Set()
        {
            BasicHttpBinding binding = new BasicHttpBinding();
            binding.Name = "serviceAIC";
            binding.CloseTimeout = new TimeSpan(00, 02, 02);
            binding.OpenTimeout = new TimeSpan(00, 02, 02);
            binding.ReceiveTimeout = new TimeSpan(00, 02, 02);
            binding.SendTimeout = new TimeSpan(00, 02, 02);
            binding.AllowCookies = false;
            binding.BypassProxyOnLocal = false;
            binding.HostNameComparisonMode = HostNameComparisonMode.StrongWildcard;
            binding.MaxBufferSize = 2147483647;
            binding.MaxBufferPoolSize = 2147483647;
            binding.MessageEncoding = WSMessageEncoding.Text;
            binding.TextEncoding = System.Text.Encoding.UTF8;
            binding.TransferMode = TransferMode.Buffered;
            binding.MaxReceivedMessageSize = 2147483647;
            binding.UseDefaultWebProxy = true;
            binding.ReaderQuotas.MaxDepth = 32;
            binding.ReaderQuotas.MaxStringContentLength = 8192;
            binding.ReaderQuotas.MaxArrayLength = 16384;
            binding.ReaderQuotas.MaxBytesPerRead = 4096;
            binding.ReaderQuotas.MaxNameTableCharCount = 16384;
            EndpointAddress endpoint = new EndpointAddress("http://localhost:88/serviceit.asmx?WSDL");
            ServiceReference.serviceitSoapClient service = new ServiceReference.serviceitSoapClient(binding, endpoint);
            return service;
        }
    }
}
