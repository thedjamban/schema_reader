using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchemaReader
{
    class TypeConverterCSharp
    {
        public static string convert(string typeSQL)
        {
            switch (typeSQL)
            {
                case "bigint":
                    return "Int64";
                case "binnary":
                    return "byte[]";
                case "bit":
                    return "bool";
                case "char":
                    return "string";
                case "date":
                    return "DateTime";
                case "datetime":
                    return "DateTime";
                case "datetime2":
                    return "DateTime";
                case "datetimeoffset":
                    return "DateTimeOffset";
                case "decimal":
                    return "decimal";
                case "float":
                    return "float";
                case "varbinary":
                    return "byte[]";
                case "image":
                    return "byte[]";
                case "int":
                    return "int";
                case "nchar":
                    return "string";
                case "numeric":
                    return "decimal";
                case "nvarchar":
                    return "string";
                case "money":
                    return "decimal";
                case "real":
                    return "single";
                case "smallint":
                    return "int";
                case "smalldatetime":
                    return "DateTime";
                case "smallmoney":
                    return "decimal";
                case "sql_variant":
                    return "object";
                case "text":
                    return "string";
                case "time":
                    return "TimeSpan";
                case "timestamp":
                    return "byte[]";
                case "tinyint":
                    return "int";
                case "varchar":
                    return "string";
                case "xml":
                    return "Xml";
                default:
                    return "object";
            }
        }
    }
}
