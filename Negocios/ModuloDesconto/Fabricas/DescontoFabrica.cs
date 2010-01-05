using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloDesconto.Repositorios;

namespace Negocios.ModuloDesconto.Fabricas
{
    /// <summary>
    /// Classe DescontoFabrica
    /// </summary>
    public class DescontoFabrica
    {
        #region Atributos
        private static IDescontoRepositorio iDescontoRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface IDescontoRepositorio.
        /// </summary>
        public static IDescontoRepositorio IDescontoInstance
        {
            get
            {
                iDescontoRepositorioInstance = new DescontoRepositorio();
                return iDescontoRepositorioInstance;
            }

        }
        #endregion
    }
}