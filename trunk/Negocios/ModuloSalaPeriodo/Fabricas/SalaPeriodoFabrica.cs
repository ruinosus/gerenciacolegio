using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloSalaPeriodo.Repositorios;

namespace Negocios.ModuloSalaPeriodo.Fabricas
{
    /// <summary>
    /// Classe SalaPeriodoFabrica
    /// </summary>
    public class SalaPeriodoFabrica
    {
        #region Atributos
        private static ISalaPeriodoRepositorio iSalaPeriodoRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface ISalaPeriodoRepositorio.
        /// </summary>
        public static ISalaPeriodoRepositorio ISalaPeriodoInstance
        {
            get
            {
                iSalaPeriodoRepositorioInstance = new SalaPeriodoRepositorio();
                return iSalaPeriodoRepositorioInstance;
            }

        }
        #endregion
    }
}