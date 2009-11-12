using System;
using System.Text;
using System.Reflection;
using System.Collections.Generic;


namespace Negocios.ModuloAuxiliar.Util.CustomComparer
{
    public enum Order
    {
        Asc,
        Desc
    }

    public class CustomComparer<T> : ICustomComparer<T>
    {
        private Type type;

        private Order order;
        private string propertyName;

        public CustomComparer()
        {
            type = typeof(T);
        }

        /// <summary>
        /// Set the Property will be used to sort and how it will be sorted
        /// </summary>
        /// <param name="propertyName">The Property Name used to sort</param>
        /// <param name="order">The Order that informs how it will be sorted </param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="PropertyNotExistsException"></exception>
        void ICustomComparer<T>.OrderBy(String propertyName, Order order)
        {
            //ValidatePropertyName(propertyName);
            this.propertyName = propertyName;


            //ValidateOrder(order);
            this.order = order;
        }

        /// <summary>
        /// Method used by the sort method
        /// </summary>
        int IComparer<T>.Compare(T x, T y)
        {
            // Check whether x or y has values.
            if (x == null || y == null)
            {
                return 0;
            }

            object valueX = Values.GetValue(x, propertyName); //propertyInfo.GetValue(x, null);
            object valueY = Values.GetValue(y, propertyName); //propertyInfo.GetValue(y, null);

            if (valueX == null || valueY == null)
            {
                return 0;
            }
            else if (Comparer.ValuesEquals(valueX, valueY))
            {
                return 0;
            }
            else if (Comparer.LessThan(valueX, valueY))
            {
                return (order == Order.Asc ? -1 : 1);
            }
            else if (Comparer.GreatThan(valueX, valueY))
            {
                return (order == Order.Asc ? 1 : -1);
            }

            return 0;
        }
    }

}