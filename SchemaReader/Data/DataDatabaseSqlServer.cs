using LibraryFramework.DatabaseSqlServer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SchemaReader.Data
{
    class DataDatabaseSqlServer : Query
    {
        public DataDatabaseSqlServer(IDbConnection con) : base(con) { }

        public DataTable getDatabase()
        {
            ss = "sp_databases ";
            return Dml(ss);
        }

        public DataTable getTableName()
        {
            ss = "select table_name from information_schema.tables order by table_name asc ";
            return Dml(ss);
        }

        public DataTable getTableSchema(string tableName)
        {
            ss = "select COLUMN_NAME, IS_NULLABLE, DATA_TYPE from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = '" + tableName + "' order by COLUMN_NAME asc ";
            return Dml(ss);
        }
    }
}
