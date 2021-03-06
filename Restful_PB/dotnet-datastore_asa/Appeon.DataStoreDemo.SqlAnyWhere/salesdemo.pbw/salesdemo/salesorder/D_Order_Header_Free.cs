using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using SnapObjects.Data;
using DWNet.Data;
using Newtonsoft.Json;
using System.Collections;

namespace Appeon.DataStoreDemo.SqlAnywhere
{
    [DataWindow("d_order_header_free", DwStyle.Default)]
    #region DwSelectAttribute  
    [DwSelect("SELECT @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM Sales.SalesOrderHeader \r\n "
                  +"WHERE Sales.SalesOrderHeader.SalesOrderID = :al_order_id")]
    #endregion
    [DwParameter("al_order_id", typeof(double?))]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [Table("SalesOrderHeader", Schema = "Sales")]
    public class D_Order_Header_Free
    {
        [Identity]
        [DwColumn("Sales.SalesOrderHeader", "salesorderid")]
        [Key]
        public int Salesorderid { get; set; } = 0;
        
        [SqlDefaultValue("0")]
        [DwColumn("Sales.SalesOrderHeader", "revisionnumber")]
        [ConcurrencyCheck]
        public byte Revisionnumber { get; set; }
        
        [SqlDefaultValue("current server timestamp")]
        [DwColumn("Sales.SalesOrderHeader", "orderdate", TypeName = "timestamp")]
        [ConcurrencyCheck]
        [Required]
        public DateTime Orderdate { get; set; }
        
        [DwColumn("Sales.SalesOrderHeader", "duedate", TypeName = "timestamp")]
        [ConcurrencyCheck]
        public DateTime Duedate { get; set; }
        
        [DwColumn("Sales.SalesOrderHeader", "shipdate", TypeName = "timestamp")]
        [ConcurrencyCheck]
        public DateTime? Shipdate { get; set; }
        
        [DwColumn("Sales.SalesOrderHeader", "status")]
        [ConcurrencyCheck]
        public byte Status { get; set; } = 1;
        
        [SqlDefaultValue("True")]
        [DwColumn("Sales.SalesOrderHeader", "onlineorderflag")]
        [ConcurrencyCheck]
        public bool Onlineorderflag { get; set; }
        
        [SqlDefaultValue("(\"isnull\"('SO'+convert(nvarchar(23),\"SalesOrderID\"),'*** ERROR ***'))")]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("Sales.SalesOrderHeader", "salesordernumber")]
        public string Salesordernumber { get; set; }
        
        [DwColumn("Sales.SalesOrderHeader", "purchaseordernumber")]
        [ConcurrencyCheck]
        [StringLength(25)]
        public string Purchaseordernumber { get; set; }
        
        [DwColumn("Sales.SalesOrderHeader", "accountnumber")]
        [ConcurrencyCheck]
        [StringLength(15)]
        public string Accountnumber { get; set; }
        
        [DwChild("Customer_Customerid", "Full_Name", typeof(D_Dddw_Customer_Individual))]
        [DwColumn("Sales.SalesOrderHeader", "customerid")]
        [ConcurrencyCheck]
        public int Customerid { get; set; }
        
        [DwChild("Salesperson_Businessentityid", "Full_Name", typeof(D_Dddw_Salesperson), AutoRetrieve = true)]
        [DwColumn("Sales.SalesOrderHeader", "salespersonid")]
        [ConcurrencyCheck]
        public int? Salespersonid { get; set; }
        
        [DwChild("Salesterritory_Territoryid", "Salesterritory_Name", typeof(D_Dddw_Salesterritory), AutoRetrieve = true)]
        [DwColumn("Sales.SalesOrderHeader", "territoryid")]
        [ConcurrencyCheck]
        public int? Territoryid { get; set; }
        
        [DwChild("Businessentityaddress_Addressid", "Address_Addressline1", typeof(D_Dddw_Customer_Address))]
        [DwColumn("Sales.SalesOrderHeader", "billtoaddressid")]
        [ConcurrencyCheck]
        public int Billtoaddressid { get; set; }
        
        [DwChild("Businessentityaddress_Addressid", "Address_Addressline1", typeof(D_Dddw_Customer_Address))]
        [DwColumn("Sales.SalesOrderHeader", "shiptoaddressid")]
        [ConcurrencyCheck]
        public int Shiptoaddressid { get; set; }
        
        [DwChild("Shipmethodid", "Name", typeof(D_Dddw_Shipmethod), AutoRetrieve = true)]
        [DwColumn("Sales.SalesOrderHeader", "shipmethodid")]
        [ConcurrencyCheck]
        public int Shipmethodid { get; set; }
        
        [DwChild("Creditcard_Creditcardid", "Creditcard_Cardnumber", typeof(D_Dddw_Customer_Creditcard))]
        [DwColumn("Sales.SalesOrderHeader", "creditcardid")]
        [ConcurrencyCheck]
        public int? Creditcardid { get; set; }
        
        [DwColumn("Sales.SalesOrderHeader", "creditcardapprovalcode")]
        [ConcurrencyCheck]
        [StringLength(15)]
        public string Creditcardapprovalcode { get; set; }
        
        [DwColumn("Sales.SalesOrderHeader", "currencyrateid")]
        [ConcurrencyCheck]
        public int? Currencyrateid { get; set; }
        
        [DwColumn("Sales.SalesOrderHeader", "subtotal")]
        [ConcurrencyCheck]
        public decimal Subtotal { get; set; } = 0m;
        
        [DwColumn("Sales.SalesOrderHeader", "taxamt")]
        [ConcurrencyCheck]
        public decimal Taxamt { get; set; } = 0m;
        
        [DwColumn("Sales.SalesOrderHeader", "freight")]
        [ConcurrencyCheck]
        public decimal Freight { get; set; } = 0m;
        
        [DwColumn("Sales.SalesOrderHeader", "totaldue")]
        //[ConcurrencyCheck]
        [PropertySave(SaveStrategy.ReadAfterSave)]
        public decimal Totaldue { get; set; }
        
        [DwColumn("Sales.SalesOrderHeader", "comment")]
        [ConcurrencyCheck]
        [StringLength(128)]
        public string Comment { get; set; }
        
        [SqlDefaultValue("current server timestamp")]
        [DwColumn("Sales.SalesOrderHeader", "modifieddate", TypeName = "timestamp")]
        [ConcurrencyCheck]
        public DateTime Modifieddate { get; set; }
        
    }
    
}