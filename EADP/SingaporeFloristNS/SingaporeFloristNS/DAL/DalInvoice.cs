using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SingaporeFloristNS.SingaporeFloristWs;
using System.Data;

namespace SingaporeFloristNS.DAL
{
    public class DalInvoice
    {
        SingaporeFloristWSClient ws = new SingaporeFloristWSClient();

        public DataSet getAllInvoice()
        {
            return ws.getAllInvoice();
        }

    }
}