using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// COrders 的摘要描述
/// </summary>
public class COrders
{
    public int oid { set; get; }
    public int book_id { set; get; }
    public int bookPrice { set; get; }
    public int count { set; get; }
    public int subtotal { set; get; }
    public DateTime orderDate { set; get; }
    public string note { set; get; }
}