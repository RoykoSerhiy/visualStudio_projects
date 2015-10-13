using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
   
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<string> GetDirContent(string path);
    }

  
    [DataContract]
    public class CompositeType
    {
        [DataMember]
        List<string> DirContent;
    }
}
