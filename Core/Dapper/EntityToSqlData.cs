using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dapper
{
    public class EntityToSqlData
    {
        public static IEnumerable<string> GetIdentityProperties<T>()
        {
            List<string> props = new List<string>();

            foreach (var prop in typeof(T).GetProperties())
            {
                var attributes = prop.GetCustomAttributes(typeof(CustomColumn), true).OfType<CustomColumn>().FirstOrDefault();
                if (attributes != null && attributes.Identity)
                {
                    props.Add(prop.Name);
                }
            }
            return props;
        }

        public static IEnumerable<string> GetKeyPropertyNames<T>()
        {
            List<string> props = new List<string>();

            foreach (var prop in typeof(T).GetProperties())
            {
                var attributes = prop.GetCustomAttributes(typeof(CustomColumn), true).OfType<CustomColumn>().FirstOrDefault();
                if (attributes != null && attributes.Primary)
                {
                    props.Add(prop.Name);
                }
            }
            return props;
        }

        public static IEnumerable<PropertyInfo> GetProperties<T>()
        {
            List<PropertyInfo> props = new List<PropertyInfo>();

            foreach (var prop in typeof(T).GetProperties())
            {
                var attributes = prop.GetCustomAttributes(typeof(CustomColumn), true).OfType<CustomColumn>().FirstOrDefault();

                bool ignore = false;

                if (attributes != null && attributes.Ignore)
                {
                    ignore = true;
                }

                if (!ignore)
                {
                    props.Add(prop);
                }
            }
            return props;
        }
    }
}
