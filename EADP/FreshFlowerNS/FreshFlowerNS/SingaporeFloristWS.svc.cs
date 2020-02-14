using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using FreshFlowerNS.BLL;
using SingaporeFlorist.BLL;

namespace SingaporeFlorist
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SingaporeFloristWS" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SingaporeFloristWS.svc or SingaporeFloristWS.svc.cs at the Solution Explorer and start debugging.
    public class SingaporeFloristWS : ISingaporeFloristWS
    {
        public DataSet GetAllProduct()
        {
            Products bizLayerProduct = new Products();
            return bizLayerProduct.GetAllProduct();
        }

        public DataSet GetAllOrders()
        {
            BllFreshFlowers bizLayerOrder = new BllFreshFlowers();
            return bizLayerOrder.GetAllOrders();
        }

        public DataSet GetAllDelivery()
        {
            BllFreshFlowers bizLayerOrder = new BllFreshFlowers();
            return bizLayerOrder.GetAllDelivery();
        }

        public DataSet getAllInvoice()
        {
            BllFreshFlowers bizLayerInvoice = new BllFreshFlowers();
            return bizLayerInvoice.GetAllInvoice();
        }
    }
}
