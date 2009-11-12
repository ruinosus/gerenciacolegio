using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Negocios.ModuloAuxiliar.Util.CustomComparer
{
    internal static class Values
    {
        /// <summary>
        /// Get the value of the property
        /// </summary>
        /// <param name="obj">The object wich holds the property's value</param>
        /// <param name="propertyName">The full name of the property</param>
        /// <returns>The property's value</returns>
        internal static Object GetValue(Object obj, String propertyName)
        {
            if (Util.HasNestedProperties(propertyName))
            {
                return GetValue(Util.GetNestedProperties(propertyName), obj);
            }
            else
                return GetValue(propertyName, obj);
        }

        /// <summary>
        /// Get the value of the property
        /// </summary>
        /// <param name="propertiesNames">A list of the nested properties' names</param>
        /// <param name="obj">The object wich holds the property's value</param>
        /// <returns>The property's value</returns>
        private static Object GetValue(IEnumerable<String> propertiesNames, Object obj)
        {
            if (obj != null)
            {
                object objValue = obj;

                foreach (String propertyName in propertiesNames)
                {
                    objValue = GetValue(propertyName, objValue);
                }

                return objValue;
            }

            return null;
        }

        /// <summary>
        /// Get the value of the property
        /// </summary>
        /// <param name="propertyName">The simple name of the property</param>
        /// <param name="obj">The object wich holds the property's value</param>
        /// <returns>The property's value</returns>
        private static object GetValue(String propertyName, Object obj)
        {
            if (obj != null)
            {
                Validator.ValidatePropertyName(propertyName, obj);
            
                PropertyInfo propertyInfo = obj.GetType().GetProperty(propertyName);

                return propertyInfo.GetValue(obj, null);
            } 
            
            return null;
        }
    }
}
