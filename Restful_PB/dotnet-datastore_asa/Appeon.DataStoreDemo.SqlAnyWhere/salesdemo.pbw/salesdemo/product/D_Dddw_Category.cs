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
    [DataWindow("d_dddw_category", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"production.productcategory\" ) @(_COLUMNS_PLACEHOLDER_) )")]
    #endregion
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [Table("productcategory", Schema = "production")]
    public class D_Dddw_Category
    {
        [Identity]
        [SqlDefaultValue("autoincrement")]
        [DwColumn("production.productcategory", "productcategoryid")]
        [Key]
        public int Productcategoryid { get; set; }

        [DwColumn("production.productcategory", "name")]
        [ConcurrencyCheck]
        [StringLength(50)]
        public string Name { get; set; }

    }

}