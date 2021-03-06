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
    [DataWindow("d_dddw_subcategory", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"production.productsubcategory\" ) @(_COLUMNS_PLACEHOLDER_) )")]
    #endregion
    [DwSort("productcategoryid A productsubcategoryid A")]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [Table("productsubcategory", Schema = "production")]
    public class D_Dddw_Subcategory
    {
        [Identity]
        [SqlDefaultValue("autoincrement")]
        [DwColumn("production.productsubcategory", "productsubcategoryid")]
        [Key]
        public int Productsubcategoryid { get; set; }

        [DwColumn("production.productsubcategory", "productcategoryid")]
        [ConcurrencyCheck]
        public int Productcategoryid { get; set; }

        [DwColumn("production.productsubcategory", "name")]
        [ConcurrencyCheck]
        [StringLength(50)]
        public string Name { get; set; }

    }

}