using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SieuAm.DataAccess;

namespace Bussiness
{
    public class Modules
    {
        public DataTable GetDataTable(string Sql)
        {
            return SqlExtend.ExecuteDataTable(Data.ConnectionString,CommandType.Text,Sql);
        }
    }
}
