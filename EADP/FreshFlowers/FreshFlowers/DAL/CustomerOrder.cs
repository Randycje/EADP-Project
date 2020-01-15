using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for CustomerOrder
/// </summary>
public class CustomerOrder
{
    private string connStr = ConfigurationManager.ConnectionStrings["TestBase"].ConnectionString;
    private string _orderItem;
    private DateTime _Date;
    private int _orderID;

    public CustomerOrder(string orderItem, DateTime Date)
    {
        _orderItem = orderItem;
        _Date = Date;
    }

}