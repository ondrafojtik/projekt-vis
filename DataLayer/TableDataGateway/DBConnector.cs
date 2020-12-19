using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DataLayer.TableDataGateway
{
    class DBConnector
    {
        public static SqlConnectionStringBuilder GetBuilder()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"dbsys.cs.vsb.cz\STUDENT";
            builder.UserID = "foj0104";
            builder.Password = "zO4SvxDYhh";
            builder.InitialCatalog = "foj0104";
            return builder;
        }
    }
}
