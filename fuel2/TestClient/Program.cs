using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestClient
{
    [ServiceContract]
    public interface IMyInterface
    {

        [OperationContract]
        string Get();

    }
    class Program
    {
       
        static void Main()
        {
            try
            {
                ChannelFactory<IMyInterface> factory = new ChannelFactory<IMyInterface>(
                    new WSHttpBinding(),
                    new EndpointAddress("http://localhost/MyClass/Ep1")
                    );
                IMyInterface channel = factory.CreateChannel();
                Console.WriteLine(channel.Get());
                
                Console.WriteLine("Для завершения нажмите <ENTER>\n");
                Console.ReadLine();
                factory.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
               
            }
        }
    }
}
