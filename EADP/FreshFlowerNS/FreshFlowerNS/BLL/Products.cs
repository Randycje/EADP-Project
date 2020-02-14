using SingaporeFlorist.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace SingaporeFlorist.BLL
{
    public class Products
    {
        public DataSet GetAllProduct()
        {
            Product dataLayerProduct;

            dataLayerProduct = new Product();
            return dataLayerProduct.GetProductDetails();
        }
    }
}