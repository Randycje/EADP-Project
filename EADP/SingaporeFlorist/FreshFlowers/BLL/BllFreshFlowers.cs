using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using FreshFlowers.DAL;

namespace FreshFlowers.BLL
{
    public class BllFreshFlowers
    {
        public DataSet GetAllAccount()
        {
            AccountClass dataLayerAccount;

            dataLayerAccount = new AccountClass();
            return dataLayerAccount.GetAccountDetails();
        }
        public DataSet GetAllProduct()
        {
            Product dataLayerProduct;

            dataLayerProduct = new Product();
            return dataLayerProduct.GetProductDetails();
        }
    }
}