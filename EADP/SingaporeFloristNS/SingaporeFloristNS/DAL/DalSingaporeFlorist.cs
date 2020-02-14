using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using SingaporeFloristNS.SingaporeFloristWs;

namespace SingaporeFloristNS.DAL
{
    public class DalSingaporeFlorist
    {
        SingaporeFloristWSClient orders = new SingaporeFloristWSClient();

        public DataSet getAllOrders()
        {
            return orders.GetAllOrders();
        }

        public DataSet getAllDelivery()
        {
            return orders.GetAllDelivery();
        }
    }
}