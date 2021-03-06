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
    [DataWindow("d_dddw_shipmethod", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"Purchasing.ShipMethod\" ) @(_COLUMNS_PLACEHOLDER_) )")]
    #endregion
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [Table("ShipMethod", Schema = "Purchasing")]
    public class D_Dddw_Shipmethod
    {
        [Identity]
        [SqlDefaultValue("autoincrement")]
        [DwColumn("Purchasing.ShipMethod", "ShipMethodID")]
        [Key]
        public int Shipmethodid { get; set; }

        [DwColumn("Purchasing.ShipMethod", "Name")]
        [ConcurrencyCheck]
        [StringLength(50)]
        public string Name { get; set; }

        [DwColumn("Purchasing.ShipMethod", "ShipBase")]
        [ConcurrencyCheck]
        public decimal Shipbase { get; set; }

        [DwColumn("Purchasing.ShipMethod", "ShipRate")]
        [ConcurrencyCheck]
        public decimal Shiprate { get; set; }

    }

}