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
    [DataWindow("d_subcategory_list", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("SELECT @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM production.productsubcategory \r\n "
                  +"where (production.productsubcategory.productcategoryid = :ai_id or :ai_id = 0)")]
    #endregion
    [DwParameter("ai_id", typeof(double?))]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [Table("productsubcategory", Schema = "production")]
    public class D_Subcategory_List
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

        [DwColumn("production.productsubcategory", "modifieddate", TypeName = "timestamp")]
        [ConcurrencyCheck]
        public DateTime Modifieddate { get; set; }

    }

}