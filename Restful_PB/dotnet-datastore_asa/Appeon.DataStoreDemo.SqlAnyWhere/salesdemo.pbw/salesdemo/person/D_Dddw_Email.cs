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
    [DataWindow("d_dddw_email", DwStyle.Grid)]
    [DwTemplate(DataFormat.Xml, "d_dddw_email", "Models\\\\salesdemo\\\\person\\\\d_dddw_email.tpl.d_dddw_email.xml")]
    [DwData(typeof(D_Dddw_Email_Data))]
    public class D_Dddw_Email
    {
        [DwColumn("name")]
        public string Name { get; set; }

        [DwColumn("value")]
        public double? Value { get; set; }

    }

    #region D_Dddw_Email_Data
    public class D_Dddw_Email_Data : DwDataInitializer<D_Dddw_Email>
    {
        public override IList<D_Dddw_Email> GetDefaultData()
        {
            var list = new List<D_Dddw_Email>();
			 
            list.Add(new D_Dddw_Email() { Name = "Contact does not wish to receive e-mail promotions", Value = 0 });
				 
            list.Add(new D_Dddw_Email() { Name = "Contact does wish to receive e-mail promotions from AdventureWorks", Value = 1 });
				 
            list.Add(new D_Dddw_Email() { Name = "Contact does wish to receive e-mail promotions from AdventureWorks and selected partners", Value = 2 });
				
            return list;
        }
    }
    #endregion
}