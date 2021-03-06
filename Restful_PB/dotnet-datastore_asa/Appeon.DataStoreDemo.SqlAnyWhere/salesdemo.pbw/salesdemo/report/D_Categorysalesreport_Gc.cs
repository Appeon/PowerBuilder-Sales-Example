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
    [DataWindow("d_categorysalesreport_gc", DwStyle.Default)]
    public class D_Categorysalesreport_Gc
    {
        [DwColumn("ProductCategoryName")]
        public string Productcategoryname { get; set; }

        [DwColumn("TotalSalesqty")]
        public double? Totalsalesqty { get; set; }

        [DwColumn("TotalSaleroom")]
        public decimal? Totalsaleroom { get; set; }

        [DwColumn("LastTotalSalesqty")]
        public double? Lasttotalsalesqty { get; set; }

        [DwColumn("LastTotalSaleroom")]
        public decimal? Lasttotalsaleroom { get; set; }

        [DwCompute("sum(  totalsaleroom  for all )")]
        [JsonIgnore]
        [IgnoreDataMember]
        public object Compute_1 { get; set; }

        [DwCompute("sum(  lasttotalsaleroom  for all )")]
        [JsonIgnore]
        [IgnoreDataMember]
        public object Compute_2 { get; set; }

    }

}