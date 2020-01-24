using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SingaporeFlorist.SingaporeFlorist;
using SingaporeFlorist.DAL;
using System.Data;

namespace SingaporeFlorist.BLL
{
    public class Stock
    {
        DALFreshFLowers dal = new DALFreshFLowers();

        public DataSet getAllStocks()
        {
            return dal.GetAllStocks();
        }
    }
}