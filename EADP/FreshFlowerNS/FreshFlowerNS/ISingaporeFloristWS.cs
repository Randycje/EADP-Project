using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace SingaporeFlorist
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISingaporeFloristWS" in both code and config file together.
    [ServiceContract]
    public interface ISingaporeFloristWS
    {
        [OperationContract]
        DataSet GetAllProduct();

        [OperationContract]
        DataSet GetAllOrders();

        [OperationContract]
        DataSet GetAllDelivery();

        [OperationContract]
        DataSet getAllInvoice();
    }
}
