using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBoletoMensalidade.Repositorios;

namespace Negocios.ModuloBoletoMensalidade.Fabricas
{
    /// <summary>
    /// Classe BoletoMensalidadeFabrica
    /// </summary>
    public class BoletoMensalidadeFabrica
    {
        #region Atributos
        private static IBoletoMensalidadeRepositorio iBoletoMensalidadeRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface IBoletoMensalidadeRepositorio.
        /// </summary>
        public static IBoletoMensalidadeRepositorio IBoletoMensalidadeInstance
        {
            get
            {
                iBoletoMensalidadeRepositorioInstance = new BoletoMensalidadeRepositorio();
                return iBoletoMensalidadeRepositorioInstance;
            }

        }
        #endregion
    }
}