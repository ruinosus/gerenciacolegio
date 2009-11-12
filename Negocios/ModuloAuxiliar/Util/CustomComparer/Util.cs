using System;
using System.Collections.Generic;
using System.Text;

namespace Negocios.ModuloAuxiliar.Util.CustomComparer
{
    internal static class Util
    {
        /// <summary>
        /// Check if there are nested properties
        /// </summary>
        /// <param name="propertyName">The full name of the property</param>
        /// <returns>True if there are nested properties or False if not</returns>
        internal static bool HasNestedProperties(String propertyName)
        {
            return (propertyName.IndexOf('.') != -1);
        }

        /// <summary>
        /// Get a list of properties' names
        /// </summary>
        /// <param name="propertyName">The full name of the property</param>
        /// <returns>A list of properties' names</returns>
        internal static IEnumerable<String> GetNestedProperties(String propertyName)
        {
            return (IEnumerable<String>)propertyName.Split('.');
        }
    }
}
