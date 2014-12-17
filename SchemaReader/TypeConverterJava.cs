using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchemaReader
{
    class TypeConverterJava
    {
        public static string convert(string typeSQL)
        {
            switch (typeSQL)
            {
                case "bigint":
                    return "Integer";
                case "binnary":
                    return "Byte[]";
                case "bit":
                    return "Boolean";
                case "char":
                    return "String";
                case "date":
                    return "String";
                case "datetime":
                    return "String";
                case "datetime2":
                    return "String";
                case "datetimeoffset":
                    return "DateTimeOffset";
                case "decimal":
                    return "Double";
                case "enum":
                    return "String";
                case "float":
                    return "Float";
                case "varbinary":
                    return "Byte[]";
                case "image":
                    return "Byte[]";
                case "int":
                    return "Integer";
                case "nchar":
                    return "String";
                case "numeric":
                    return "Double";
                case "nvarchar":
                    return "String";
                case "money":
                    return "Double";
                case "real":
                    return "Float";
                case "smallint":
                    return "Integer";
                case "smalldatetime":
                    return "String";
                case "smallmoney":
                    return "Double";
                case "sql_variant":
                    return "Object";
                case "text":
                    return "String";
                case "time":
                    return "String";
                case "timestamp":
                    return "Byte[]";
                case "tinyint":
                    return "Integer";
                case "varchar":
                    return "String";
                case "xml":
                    return "Xml";
                default:
                    return "Object";
            }
        }
    }
}
