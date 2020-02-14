using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SingaporeFloristNS.SingaporeFloristWs;
using System.Data;

namespace FreshFlowers.DAL
{
    public class DALStocks
    {
        SingaporeFloristWSClient stocks = new SingaporeFloristWSClient();

        public DataSet GetAllStocks()
        {
            return stocks.GetAllProduct();
        }
    }
}