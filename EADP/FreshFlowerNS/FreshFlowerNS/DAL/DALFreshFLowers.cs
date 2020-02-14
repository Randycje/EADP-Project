using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FreshFlowerNS.SingaporeFloristNS;
using SingaporeFlorist.DAL;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace SingaporeFlorist.DAL
{
    public class DALFreshFLowers
    {
        WsFreshFlowersClient stock = new WsFreshFlowersClient();

        public DataSet GetAllPOrders()
        {
            return stock.GetAllPOrders();
        }

        public DataSet GetALLPayment()
        {
            //WsFreshFlowersClient stocks = new WsFreshFlowersClient();
            WsFreshFlowersClient payment = new WsFreshFlowersClient();
            return payment.getALLPayment();
        }

        public DataSet ViewPayment(int paymentID)
        {
            //WsFreshFlowersClient stocks = new WsFreshFlowersClient();
            WsFreshFlowersClient payment = new WsFreshFlowersClient();
            return payment.ViewPayment(paymentID);
        }
    }
}