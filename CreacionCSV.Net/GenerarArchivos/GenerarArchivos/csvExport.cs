using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GenerarArchivos
{
    public class csvExport<T> where T: class
    {
        public List<T> _objects;
        public csvExport(List<T> objects)
        {
            _objects = objects;
        }

        public string Export()
        {
            return Export(true);
        }

        public string Export(bool includeHeaderLine)
        {
            StringBuilder sb = new StringBuilder();

            IList<PropertyInfo> propertyInfos = typeof(T).GetProperties();

            //Header line
            if (includeHeaderLine)
            {
                foreach (PropertyInfo propertyInfo in propertyInfos)
                {
                    sb.Append(propertyInfo.Name).Append(",");
                }
                sb.Remove(sb.Length - 1, 1).AppendLine();
            }

            foreach (T obj in _objects)
            {
                foreach (PropertyInfo propertyInfo in propertyInfos)
                {
                    sb.Append(MakeValueCsvFriendly(propertyInfo.GetValue(obj, null))).Append(",");
                }
            }

            return sb.ToString();
        }

        private string MakeValueCsvFriendly(object value)
        {
            if (value == null) return "";
            if (value is Nullable && ((INullable)value).IsNull) return "";
            //throw new NotImplementedException();
            if (value is DateTime)
            {
                if (((DateTime)value).TimeOfDay.TotalSeconds == 0)
                {
                    return ((DateTime)value).ToString("yyyy-MM-dd");
                }
                return ((DateTime)value).ToString("yyyy-MM-dd HH:mm:ss");
            }

            string output = value.ToString();

            if (output.Contains(",") || output.Contains("\""))
            {
                output = '"' + output.Replace("\"", "\"\"") + '"';
            }

            return output;
        }

        public void ExportFile(string path)
        {
            File.WriteAllText(path, Export());
        }

        public byte[] ExportToBytes()
        {
            return Encoding.UTF8.GetBytes(Export());
        }
    }
}
