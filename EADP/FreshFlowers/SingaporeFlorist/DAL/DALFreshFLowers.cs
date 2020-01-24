using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SingaporeFlorist.SingaporeFlorist;
using SingaporeFlorist.DAL;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace SingaporeFlorist.DAL
{
    public class DALFreshFLowers
    {
        WsFreshFlowersClient stocks = new WsFreshFlowersClient();

        public DataSet GetAllStocks()
        {
            return stocks.GetProductDetails();
        }
    }
}