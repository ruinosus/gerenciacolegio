using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloChequeBoletoMensalidade.Repositorios;

namespace Negocios.ModuloChequeBoletoMensalidade.Fabricas
{
    /// <summary>
    /// Classe ChequeBoletoMensalidadeFabrica
    /// </summary>
    public class ChequeBoletoMensalidadeFabrica
    {
        #region Atributos
        private static IChequeBoletoMensalidadeRepositorio iChequeBoletoMensalidadeRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface IChequeBoletoMensalidadeRepositorio.
        /// </summary>
        public static IChequeBoletoMensalidadeRepositorio IChequeBoletoMensalidadeInstance
        {
            get
            {
                iChequeBoletoMensalidadeRepositorioInstance = new ChequeBoletoMensalidadeRepositorio();
                return iChequeBoletoMensalidadeRepositorioInstance;
            }

        }
        #endregion
    }
}