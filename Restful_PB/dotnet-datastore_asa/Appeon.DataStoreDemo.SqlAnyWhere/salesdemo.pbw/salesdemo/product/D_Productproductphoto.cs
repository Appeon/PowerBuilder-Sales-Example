using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SnapObjects.Data;
using DWNet.Data;

namespace Appeon.DataStoreDemo.SqlAnywhere
{
    [DataWindow("d_productproductphoto", DwStyle.Grid)]
    [Table("ProductProductPhoto", Schema = "Production")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"Production.ProductProductPhoto\" ) @(_COLUMNS_PLACEHOLDER_) WHERE(    EXP1 =\"\\\"Production\\\".\\\"ProductProductPhoto\\\".\\\"ProductID\\\"\"   OP =\"=\"    EXP2 =\":al_productid\" ) ) ARG(NAME = \"al_productid\" TYPE = number)")]
    #endregion
    [DwParameter("al_productid", typeof(decimal?))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Productproductphoto
    {
        [Key]
        [DwColumn("ProductProductPhoto", "ProductID")]
        public int Productid { get; set; }

        [Key]
        [DwColumn("ProductProductPhoto", "ProductPhotoID")]
        public int Productphotoid { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("((0))")]
        [DwColumn("ProductProductPhoto", "Primary")]
        public byte Primary { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("(getdate())")]
        [DwColumn("ProductProductPhoto", "ModifiedDate")]
        public DateTime Modifieddate { get; set; }

    }

}