using LibraryFramework.DatabaseMySql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SchemaReader.Data
{
    class DataDatabaseMySql : Query
    {
        public DataDatabaseMySql(IDbConnection con) : base(con) { }


        public DataTable getDatabase()
        {
            ss = "SHOW databases ";
            return Dml(ss);
        }

        public DataTable getTableName(string database)
        {
            ss = "select table_name from information_schema.tables where table_schema = '" + database + "' ";
            return Dml(ss);
        }

        public DataTable getTableSchema(string database, string tableName)
        {
            ss = "select COLUMN_NAME, IS_NULLABLE, DATA_TYPE from INFORMATION_SCHEMA.COLUMNS where TABLE_schema = '" + database + "' and table_name = '" + tableName + "' ";
            return Dml(ss);
        }
    }
}
