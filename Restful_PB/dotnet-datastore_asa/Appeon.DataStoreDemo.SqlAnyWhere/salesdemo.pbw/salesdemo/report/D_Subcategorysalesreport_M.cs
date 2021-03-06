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
    [DataWindow("d_subcategorysalesreport_m", DwStyle.Composite)]
    public class D_Subcategorysalesreport_M
    {
        [DwColumn("a")]
        public string A { get; set; }

        [DwReport(typeof(D_Subcategorysalesreport))]
        [JsonIgnore]
        [IgnoreDataMember]
        public IList<D_Subcategorysalesreport> Dw_Subcategorysalesreport { get; set; }

        [DwReport(typeof(D_Subcategorysalesreport_Graph))]
        [JsonIgnore]
        [IgnoreDataMember]
        public IList<D_Subcategorysalesreport_Graph> Dw_Subcategorysalesreport_Graph { get; set; }

        [DwReport(typeof(D_Productsalesreport))]
        [JsonIgnore]
        [IgnoreDataMember]
        public IList<D_Productsalesreport> Dw_Productsalesreport { get; set; }

    }

}