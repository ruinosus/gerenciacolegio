using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Negocios.ModuloAuxiliar.Util.CustomComparer
{
    internal static class Validator
    {
        /// <summary>
        /// Validate the Property Name
        /// </summary>
        internal static void ValidatePropertyName(String propertyName, Object obj)
        {
            try
            {
                if (propertyName == null)
                {
                    throw new ArgumentNullException("propertyName");
                }

                if (String.IsNullOrEmpty(propertyName))
                {
                    throw new ArgumentException("An Empty String is not valid as Property Name", "propertyName");
                }

                if (!ExistsProperty(propertyName, obj))
                {
                    throw new PropertyNotExistsException(propertyName);
                }
            }
            catch { }
        }

        /// <summary>
        /// Check if the property name exists in the object
        /// </summary>
        private static Boolean ExistsProperty(String propertyName, Object obj)
        {
            if (obj != null)
            {
                Type objType = obj.GetType();

                PropertyInfo[] propertiesInfo = objType.GetProperties();

                foreach (PropertyInfo propertyInfo in propertiesInfo)
                {
                    if (String.Equals(propertyInfo.Name, propertyName))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
