using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using FreshFlowers.BLL;

namespace FreshFlowers
{
    public class WsFreshFlowers : IWsFreshFlowers
    {
        public DataSet GetAllAccount()
        {
            BllFreshFlowers bizLayerAccount = new BllFreshFlowers();
            return bizLayerAccount.GetAllAccount();
        }
        public DataSet GetProductDetails()
        {
            BllFreshFlowers bizLayerProduct = new BllFreshFlowers();
            return bizLayerProduct.GetAllProduct();
        }
    }
}
