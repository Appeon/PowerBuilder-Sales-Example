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
    [DataWindow("d_order_detail_free", DwStyle.Default)]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"Sales.SalesOrderDetail\" ) @(_COLUMNS_PLACEHOLDER_) WHERE(    EXP1 =\"Sales.SalesOrderDetail.SalesOrderID\"   OP =\"=\"    EXP2 =\":al_order_id\" ) ) ORDER(NAME=\"Sales.SalesOrderDetail.salesorderdetailid\" ASC=yes ) ARG(NAME = \"al_order_id\" TYPE = number)")]
    #endregion
    [DwParameter("al_order_id", typeof(double?))]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [Table("SalesOrderDetail", Schema = "Sales")]
    public class D_Order_Detail_Free
    {
        [DwColumn("Sales.SalesOrderDetail", "salesorderid")]
        [Key]
        public int Salesorderid { get; set; }

        [Identity]
        [SqlDefaultValue("autoincrement")]
        [DwColumn("Sales.SalesOrderDetail", "salesorderdetailid")]
        [Key]
        public int Salesorderdetailid { get; set; }

        [DwColumn("Sales.SalesOrderDetail", "carriertrackingnumber")]
        [ConcurrencyCheck]
        [StringLength(25)]
        public string Carriertrackingnumber { get; set; }

        [DwColumn("Sales.SalesOrderDetail", "orderqty")]
        [ConcurrencyCheck]
        [Required]
        public short Orderqty { get; set; } = 0;

        [DwChild("Product_Productid", "Product_Name", typeof(D_Dddw_Order_Production), AutoRetrieve = true)]
        [DwColumn("Sales.SalesOrderDetail", "productid")]
        [ConcurrencyCheck]
        [Required]
        public int Productid { get; set; }

        [DwChild("Specialofferproduct_Specialofferid", "Specialoffer_Description", typeof(D_Dddw_Specialoffer), AutoRetrieve = true)]
        [DwColumn("Sales.SalesOrderDetail", "specialofferid")]
        [ConcurrencyCheck]
        [Required]
        public int Specialofferid { get; set; }

        [DwColumn("Sales.SalesOrderDetail", "unitprice")]
        [ConcurrencyCheck]
        [Required]
        public decimal Unitprice { get; set; } = 0m;

        [DwColumn("Sales.SalesOrderDetail", "unitpricediscount")]
        [ConcurrencyCheck]
        [Required]
        public decimal Unitpricediscount { get; set; } = 0m;

        [Identity]
        [SqlDefaultValue("(\"isnull\"((\"UnitPrice\"*((1.0)-\"UnitPriceDiscount\"))*\"OrderQty\",(0.0)))")]
        [DwColumn("Sales.SalesOrderDetail", "linetotal")]
        [ConcurrencyCheck]
        public decimal Linetotal { get; set; }

        [SqlDefaultValue("current server timestamp")]
        [DwColumn("Sales.SalesOrderDetail", "modifieddate", TypeName = "timestamp")]
        [ConcurrencyCheck]
        public DateTime Modifieddate { get; set; }

        [DwCompute("String(getrow()) +\"/\" + RowCount()")]
        [JsonIgnore]
        [IgnoreDataMember]
        public object Compute_1 { get; set; }

    }

}