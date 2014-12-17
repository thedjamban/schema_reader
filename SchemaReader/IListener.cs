using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SchemaReader
{
    public interface IListener
    {
        void refreshSqlServer(DataTable dtb, LibraryFramework.DatabaseSqlServer.Koneksi con);
        void refreshMySql(DataTable dtb, LibraryFramework.DatabaseMySql.Koneksi con, string databaseMySql);
    }
}
