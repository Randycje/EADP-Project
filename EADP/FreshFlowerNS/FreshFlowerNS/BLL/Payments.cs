using SingaporeFlorist.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace FreshFlowerNS.BLL
{
    public class Payments
    {
        public DataSet GetALLPayment()
        {
            DALFreshFLowers dal;
            dal = new DALFreshFLowers();
            return dal.GetALLPayment();
        }

        public DataSet ViewPayment(int paymentID)
        {
            DALFreshFLowers dal;
            dal = new DALFreshFLowers();
            return dal.ViewPayment(paymentID);
        }
    }
}