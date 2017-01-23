using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication34
{
    static class CsvSelialize
    {
        static public string Serialise<T>(T obj) where T : new()
        {
            StringBuilder builder = new StringBuilder();
            Type type = typeof(T);

           

            foreach (var propertyInfo in type.GetProperties())
            {         
                if(propertyInfo.GetOptionalCustomModifiers)      
                if (propertyInfo.PropertyType == typeof(string)  && propertyInfo.GetCustomAttribute<NoCsvAttribute>() == null && propertyInfo.CanRead && propertyInfo.CanWrite)
                    builder.Append((string)propertyInfo.GetValue(obj)+",");
            }
            string resultStr = builder.ToString();
            if (resultStr[resultStr.Length - 1] == ',')
            {
                resultStr = resultStr.Remove(resultStr.Length - 1, 1);
            }

            return resultStr;
        }

        public static T Deserialize<T>(string str) where T : new()
        {
            string[] splited = str.Split(new char[] { ',' });
            T obj = new T();
            Type type = typeof(T);
            int i = 0;
            foreach (var propertyInfo in type.GetProperties())
            {
                if (propertyInfo.PropertyType == typeof(string) && propertyInfo.GetCustomAttribute<NoCsvAttribute>() == null && propertyInfo.CanRead && propertyInfo.CanWrite)
                {
                    propertyInfo.SetValue(obj, splited[i++]);
                }                    
            }
            return obj;
        }
    }
}
