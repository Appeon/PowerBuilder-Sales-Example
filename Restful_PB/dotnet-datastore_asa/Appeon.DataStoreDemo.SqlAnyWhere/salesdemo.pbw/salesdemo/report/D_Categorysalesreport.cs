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
    [DataWindow("d_categorysalesreport", DwStyle.Default)]
    public class D_Categorysalesreport
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

    }

}