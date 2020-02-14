using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using SingaporeFloristNS.BLL;
using SingaporeFlorist.BLL;

namespace FreshFlowers
{
    public class WsFreshFlowers : IWsFreshFlowers
    {
        public DataSet GetAllAccount()
        {
            BllFreshFlowers bizLayerAccount = new BllFreshFlowers();
            return bizLayerAccount.GetAllAccount();
        }
        //public DataSet GetProductDetails()
        //{
        //    BllFreshFlowers bizLayerProduct = new BllFreshFlowers();
        //    return bizLayerProduct.GetAllProduct();
        //}
        public DataSet GetAllPOrders()
        {
            BllFreshFlowers bizLayerPOrder = new BllFreshFlowers();
            return bizLayerPOrder.GetAllPOrders();
        }

        public DataSet getALLPayment()
        {
            BllFreshFlowers bizLayerPayment = new BllFreshFlowers();
            return bizLayerPayment.GetAllPayment();
        }
        public DataSet ViewPayment(int paymentID)
        {
            BllFreshFlowers bizLayerPayment = new BllFreshFlowers();
            return bizLayerPayment.ViewPayment(paymentID);
        }
    }
}
