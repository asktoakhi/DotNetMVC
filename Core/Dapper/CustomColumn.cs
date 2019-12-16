using System;
using System.Runtime.CompilerServices;

namespace Core.Dapper
{
    [AttributeUsage(AttributeTargets.Class)]
    public class TableMapping : Attribute
    {
        public TableMapping([CallerMemberName] string name = "")
        {
            TableName = name;
        }

        public string TableName { get; set; }
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class CustomColumn : Attribute
    {
        public CustomColumn([CallerLineNumber] int order = 0, [CallerMemberName] string name = "")
        {
            Order = order;
            Primary = false;
            Identity = false;
            Ignore = false;
            ColumnName = name;
        }

        public int Order { get; private set; }
        public bool Primary { get; set; }
        public bool Identity { get; set; }
        public bool Ignore { get; set; }
        public string ColumnName { get; set; }
    }
}
