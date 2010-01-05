using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloContasAPagar.Repositorios;

namespace Negocios.ModuloContasAPagar.Fabricas
{
    /// <summary>
    /// Classe ContasAPagarFabrica
    /// </summary>
    public class ContasAPagarFabrica
    {
        #region Atributos
        private static IContasAPagarRepositorio iContasAPagarRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface IContasAPagarRepositorio.
        /// </summary>
        public static IContasAPagarRepositorio IContasAPagarInstance
        {
            get
            {
                iContasAPagarRepositorioInstance = new ContasAPagarRepositorio();
                return iContasAPagarRepositorioInstance;
            }

        }
        #endregion
    }
}