using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloCheque.Repositorios;

namespace Negocios.ModuloCheque.Fabricas
{
    /// <summary>
    /// Classe ChequeFabrica
    /// </summary>
    public class ChequeFabrica
    {
        #region Atributos
        private static IChequeRepositorio iChequeRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface IChequeRepositorio.
        /// </summary>
        public static IChequeRepositorio IChequeInstance
        {
            get
            {
                iChequeRepositorioInstance = new ChequeRepositorio();
                return iChequeRepositorioInstance;
            }

        }
        #endregion
    }
}