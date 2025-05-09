using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace NeerajraiInfra.Models
{
    public class User
    {
        public DataSet GetSiteList()
        {
            DataSet ds = Connection.ExecuteQuery("SiteList");
            return ds;
        }

    }
}