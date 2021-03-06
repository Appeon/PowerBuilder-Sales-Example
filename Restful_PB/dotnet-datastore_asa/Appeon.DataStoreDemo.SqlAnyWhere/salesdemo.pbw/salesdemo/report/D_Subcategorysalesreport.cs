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
    [DataWindow("d_subcategorysalesreport", DwStyle.Default)]
    public class D_Subcategorysalesreport
    {
        [DwColumn("Name")]
        public string Name { get; set; }

        [DwColumn("SalesqtyMonth1")]
        public double? Salesqtymonth1 { get; set; }

        [DwColumn("SalesRoomMonth1")]
        public decimal? Salesroommonth1 { get; set; }

        [DwColumn("SalesqtyMonth2")]
        public double? Salesqtymonth2 { get; set; }

        [DwColumn("SalesRoomMonth2")]
        public decimal? Salesroommonth2 { get; set; }

        [DwColumn("SalesqtyMonth3")]
        public double? Salesqtymonth3 { get; set; }

        [DwColumn("SalesRoomMonth3")]
        public decimal? Salesroommonth3 { get; set; }

        [DwColumn("SalesqtyMonth4")]
        public double? Salesqtymonth4 { get; set; }

        [DwColumn("SalesRoomMonth4")]
        public decimal? Salesroommonth4 { get; set; }

        [DwColumn("SalesqtyMonth5")]
        public double? Salesqtymonth5 { get; set; }

        [DwColumn("SalesRoomMonth5")]
        public decimal? Salesroommonth5 { get; set; }

        [DwColumn("SalesqtyMonth6")]
        public double? Salesqtymonth6 { get; set; }

        [DwColumn("SalesRoomMonth6")]
        public decimal? Salesroommonth6 { get; set; }

    }

}