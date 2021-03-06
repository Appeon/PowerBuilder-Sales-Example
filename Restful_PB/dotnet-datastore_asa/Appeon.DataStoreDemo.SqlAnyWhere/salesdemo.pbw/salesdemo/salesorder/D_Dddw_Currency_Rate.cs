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
    [DataWindow("d_dddw_currency_rate", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"Sales.CurrencyRate\" ) @(_COLUMNS_PLACEHOLDER_) WHERE(    EXP1 =\"Sales.CurrencyRate.CurrencyRateDate\"   OP =\"=\"    EXP2 =\"(select max(CurrencyRateDate) from Sales.CurrencyRate )\" ) ) ORDER(NAME=\"Sales.CurrencyRate.ToCurrencyCode\" ASC=yes )")]
    #endregion
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [Table("CurrencyRate", Schema = "Sales")]
    public class D_Dddw_Currency_Rate
    {
        [Identity]
        [SqlDefaultValue("autoincrement")]
        [DwColumn("Sales.CurrencyRate", "CurrencyRateID")]
        [Key]
        public int Currencyrateid { get; set; }

        [DwColumn("Sales.CurrencyRate", "CurrencyRateDate", TypeName = "timestamp")]
        [ConcurrencyCheck]
        public DateTime Currencyratedate { get; set; }

        [DwColumn("Sales.CurrencyRate", "FromCurrencyCode")]
        [ConcurrencyCheck]
        [StringLength(3)]
        public string Fromcurrencycode { get; set; }

        [DwColumn("Sales.CurrencyRate", "ToCurrencyCode")]
        [ConcurrencyCheck]
        [StringLength(3)]
        public string Tocurrencycode { get; set; }

        [DwColumn("Sales.CurrencyRate", "AverageRate")]
        [ConcurrencyCheck]
        public decimal Averagerate { get; set; }

        [DwColumn("Sales.CurrencyRate", "EndOfDayRate")]
        [ConcurrencyCheck]
        public decimal Endofdayrate { get; set; }

    }

}