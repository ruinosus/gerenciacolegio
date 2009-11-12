using System;
using System.Collections.Generic;

namespace Negocios.ModuloAuxiliar.Util.CustomComparer
{
    public interface ICustomComparer<T> : IComparer<T>
    {
        /// <summary>
        /// Set the Property will be used to sort and how it will be sorted
        /// </summary>
        /// <param name="propertyName">The Property Name used to sort</param>
        /// <param name="order">The Order that informs how it will be sorted </param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="PropertyNotExistsException"></exception>
        void OrderBy(string propertyName, Order order);
    }
}
