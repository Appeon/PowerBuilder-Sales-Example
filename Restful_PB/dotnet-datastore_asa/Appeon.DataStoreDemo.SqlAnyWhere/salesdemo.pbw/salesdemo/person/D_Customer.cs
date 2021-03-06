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
    [DataWindow("d_customer", DwStyle.Default)]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"Sales.Customer\" ) @(_COLUMNS_PLACEHOLDER_) WHERE(    EXP1 =\"Sales.Customer.PersonID\"   OP =\"=\"    EXP2 =\":ai_id\" ) ) ARG(NAME = \"ai_id\" TYPE = number)")]
    #endregion
    [DwParameter("ai_id", typeof(double?))]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [Table("Customer", Schema = "Sales")]
    public class D_Customer
    {
        [Identity]
        [DwColumn("Sales.Customer", "customerid")]
        [Key]
        public int Customerid { get; set; } = 0;

        [DwColumn("Sales.Customer", "personid")]
        public int? Personid { get; set; } = 0;

        [DwChild("Businessentityid", "Name", typeof(D_Dddw_Store))]
        [DwColumn("Sales.Customer", "storeid")]
        public int? Storeid { get; set; }

        [DwChild("Territoryid", "Name", typeof(D_Dddw_Territory))]
        [DwColumn("Sales.Customer", "territoryid")]
        public int? Territoryid { get; set; }

        [DwColumn("Sales.Customer", "accountnumber")]
        [StringLength(10)]
        public string Accountnumber { get; set; }

        [DwColumn("Sales.Customer", "modifieddate", TypeName = "timestamp")]
        public DateTime Modifieddate { get; set; } = Convert.ToDateTime("1/1/1990 12:00:00 AM");

    }

}