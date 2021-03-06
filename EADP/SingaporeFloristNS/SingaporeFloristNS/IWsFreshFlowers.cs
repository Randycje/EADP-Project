﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace FreshFlowers
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWsFreshFlowers" in both code and config file together.
    [ServiceContract]
    public interface IWsFreshFlowers
    {
        [OperationContract]
        DataSet GetAllAccount();

        //[OperationContract]
        //DataSet GetProductDetails();

        [OperationContract]
        DataSet GetAllPOrders();


        [OperationContract]
        DataSet getALLPayment();

        [OperationContract]
        DataSet ViewPayment(int paymentID);
    }
}
