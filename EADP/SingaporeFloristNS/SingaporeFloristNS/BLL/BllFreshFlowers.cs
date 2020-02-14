using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using FreshFlowers.DAL;

namespace SingaporeFlorist.BLL
{
    public class BllFreshFlowers
    {
        public DataSet GetAllAccount()
        {
            AccountClass dataLayerAccount;

            dataLayerAccount = new AccountClass();
            return dataLayerAccount.GetAccountDetails();
        }
        //public DataSet GetAllProduct()
        //{
        //    Product dataLayerProduct;

        //    dataLayerProduct = new Product();
        //    return dataLayerProduct.GetProductDetails();
        //}
        public DataSet GetAllPOrders()
        {
            POrders dataLayerOrder;

            dataLayerOrder = new POrders();
            return dataLayerOrder.GetPOrdersDetail();
        }

        public DataSet GetAllPayment()
        {
            PaymentNS dataLayerPayment;

            dataLayerPayment = new PaymentNS();
            return dataLayerPayment.AllPayment();
        }

        public DataSet ViewPayment(int paymentID)
        {
            PaymentNS dataLayer = new PaymentNS();
            return dataLayer.SelectPayment(paymentID);
        }

    }
}