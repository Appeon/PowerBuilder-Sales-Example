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
    [DataWindow("d_categorysalesreport_pie_saleroom", DwStyle.Graph)]
    public class D_Categorysalesreport_Pie_Saleroom
    {
        [DwColumn("ProductCategoryName")]
        public string Productcategoryname { get; set; }

        [DwColumn("TotalSalesqty")]
        public double? Totalsalesqty { get; set; }

        [DwColumn("name_1")]
        public decimal? Totalsaleroom { get; set; }

    }

}