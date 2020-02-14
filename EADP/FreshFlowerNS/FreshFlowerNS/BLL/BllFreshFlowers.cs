using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using FreshFlowerNS.DAL;

namespace FreshFlowerNS.BLL
{
    public class BllFreshFlowers
    {
        public DataSet GetAllOrders()
        {
            Orders ord = new Orders();
            return ord.AllOrders();
        }

        public DataSet GetAllDelivery()
        {
            DAL.Delivery del = new DAL.Delivery();
            return del.AllDelivery();
        }

        public DataSet GetAllInvoice()
        {
            DAL.Invoice inv = new DAL.Invoice();
            return inv.AllInvoice();
        }
    }
}