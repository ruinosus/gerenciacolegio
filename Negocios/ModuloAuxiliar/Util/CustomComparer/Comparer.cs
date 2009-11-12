using System;
using System.Collections.Generic;
using System.Text;

namespace Negocios.ModuloAuxiliar.Util.CustomComparer
{
    internal static class Comparer
    {
        /// <summary>
        /// Check whether the values are equals or not
        /// </summary>
        internal static bool ValuesEquals(Object valueX, Object valueY)
        {
            TypeCode typeCode = Type.GetTypeCode(valueX.GetType());

            switch (typeCode)
            {
                case TypeCode.Boolean:
                    return ((Boolean)valueX == (Boolean)valueY ? true : false);
                case TypeCode.Byte:
                    return ((Byte)valueX == (Byte)valueY ? true : false);
                case TypeCode.Char:
                    return ((Char)valueX == (Char)valueY ? true : false);
                case TypeCode.DateTime:
                    return (((DateTime)valueX).CompareTo((DateTime)valueY) == 0 ? true : false);
                case TypeCode.Decimal:
                    return ((Decimal)valueX == (Decimal)valueY ? true : false);
                case TypeCode.Double:
                    return ((Double)valueX == (Double)valueY ? true : false);
                case TypeCode.Int16:
                    return ((Int16)valueX == (Int16)valueY ? true : false);
                case TypeCode.Int32:
                    return ((Int32)valueX == (Int32)valueY ? true : false);
                case TypeCode.Int64:
                    return ((Int64)valueX == (Int64)valueY ? true : false);
                case TypeCode.SByte:
                    return ((SByte)valueX == (SByte)valueY ? true : false);
                case TypeCode.Single:
                    return ((Single)valueX == (Single)valueY ? true : false);
                case TypeCode.String:
                    return ((String)valueX == (String)valueY ? true : false);
                case TypeCode.UInt16:
                    return ((UInt16)valueX == (UInt16)valueY ? true : false);
                case TypeCode.UInt32:
                    return ((UInt32)valueX == (UInt32)valueY ? true : false);
                case TypeCode.UInt64:
                    return ((UInt64)valueX == (UInt64)valueY ? true : false);
                default:
                    return false;
            };
        }

        /// <summary>
        /// Check whether the first value is less than the second or not
        /// </summary>
        internal static bool LessThan(Object valueX, Object valueY)
        {
            TypeCode typeCode = Type.GetTypeCode(valueX.GetType());

            switch (typeCode)
            {
                case TypeCode.Boolean:
                    return (((Boolean)valueX).CompareTo((Boolean)valueY) < 0 ? true : false);
                case TypeCode.Byte:
                    return ((Byte)valueX < (Byte)valueY ? true : false);
                case TypeCode.Char:
                    return ((Char)valueX < (Char)valueY ? true : false);
                case TypeCode.DateTime:
                    return (((DateTime)valueX).CompareTo((DateTime)valueY) < 0 ? true : false);
                case TypeCode.Decimal:
                    return ((Decimal)valueX < (Decimal)valueY ? true : false);
                case TypeCode.Double:
                    return ((Double)valueX < (Double)valueY ? true : false);
                case TypeCode.Int16:
                    return ((Int16)valueX < (Int16)valueY ? true : false);
                case TypeCode.Int32:
                    return ((Int32)valueX < (Int32)valueY ? true : false);
                case TypeCode.Int64:
                    return ((Int64)valueX < (Int64)valueY ? true : false);
                case TypeCode.SByte:
                    return ((SByte)valueX < (SByte)valueY ? true : false);
                case TypeCode.Single:
                    return ((Single)valueX < (Single)valueY ? true : false);
                case TypeCode.String:
                    return (((String)valueX).CompareTo((String)valueY) < 0 ? true : false);
                case TypeCode.UInt16:
                    return ((UInt16)valueX < (UInt16)valueY ? true : false);
                case TypeCode.UInt32:
                    return ((UInt32)valueX < (UInt32)valueY ? true : false);
                case TypeCode.UInt64:
                    return ((UInt64)valueX < (UInt64)valueY ? true : false);
                default:
                    return false;
            };
        }

        /// <summary>
        /// Check whether the first value is great than the second or not
        /// </summary>
        internal static bool GreatThan(Object valueX, Object valueY)
        {
            TypeCode typeCode = Type.GetTypeCode(valueX.GetType());

            switch (typeCode)
            {
                case TypeCode.Boolean:
                    return (((Boolean)valueX).CompareTo((Boolean)valueY) > 0 ? true : false);
                case TypeCode.Byte:
                    return ((Byte)valueX > (Byte)valueY ? true : false);
                case TypeCode.Char:
                    return ((Char)valueX > (Char)valueY ? true : false);
                case TypeCode.DateTime:
                    return (((DateTime)valueX).CompareTo((DateTime)valueY) > 0 ? true : false);
                case TypeCode.Decimal:
                    return ((Decimal)valueX > (Decimal)valueY ? true : false);
                case TypeCode.Double:
                    return ((Double)valueX > (Double)valueY ? true : false);
                case TypeCode.Int16:
                    return ((Int16)valueX > (Int16)valueY ? true : false);
                case TypeCode.Int32:
                    return ((Int32)valueX > (Int32)valueY ? true : false);
                case TypeCode.Int64:
                    return ((Int64)valueX > (Int64)valueY ? true : false);
                case TypeCode.SByte:
                    return ((SByte)valueX > (SByte)valueY ? true : false);
                case TypeCode.Single:
                    return ((Single)valueX > (Single)valueY ? true : false);
                case TypeCode.String:
                    return (((String)valueX).CompareTo((String)valueY) > 0 ? true : false);
                case TypeCode.UInt16:
                    return ((UInt16)valueX > (UInt16)valueY ? true : false);
                case TypeCode.UInt32:
                    return ((UInt32)valueX > (UInt32)valueY ? true : false);
                case TypeCode.UInt64:
                    return ((UInt64)valueX > (UInt64)valueY ? true : false);
                default:
                    return false;
            };
        }
    }
}
