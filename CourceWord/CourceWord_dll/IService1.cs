using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CourceWord_dll
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService1" в коде и файле конфигурации.
    [ServiceContract]
    public interface IServiceEmployeesDataBase
    {
        [OperationContract]
        List<DataEmployees> Get();

        [OperationContract]
        string Test();

        // TODO: Добавьте здесь операции служб
    }

    // Используйте контракт данных, как показано на следующем примере, чтобы добавить сложные типы к сервисным операциям.
    // В проект можно добавлять XSD-файлы. После построения проекта вы можете напрямую использовать в нем определенные типы данных с пространством имен "CourceWord_dll.ContractType".
    [DataContract]
    public class DataEmployees
    {
        [DataMember]
        public string Name;

        [DataMember]
        public string Address;

        [DataMember]
        public string Post;
    }
}
