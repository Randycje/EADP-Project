using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FreshFlowers.DAL;
using System.Data;
using SingaporeFloristNS.DAL;

namespace SingaporeFloristNS.BLL
{
    public class BllOrders
    {
        DalSingaporeFlorist dal = new DalSingaporeFlorist();

        public DataSet getAllOrders()
        {
            return dal.getAllOrders();
        }

        public DataSet GetAllDelivery()
        {
            return dal.getAllDelivery();
        }
    }
}