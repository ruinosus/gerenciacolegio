using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloChequeBoletoAtividade.Repositorios;

namespace Negocios.ModuloChequeBoletoAtividade.Fabricas
{
    /// <summary>
    /// Classe ChequeBoletoAtividadeFabrica
    /// </summary>
    public class ChequeBoletoAtividadeFabrica
    {
        #region Atributos
        private static IChequeBoletoAtividadeRepositorio iChequeBoletoAtividadeRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface IChequeBoletoAtividadeRepositorio.
        /// </summary>
        public static IChequeBoletoAtividadeRepositorio IChequeBoletoAtividadeInstance
        {
            get
            {
                iChequeBoletoAtividadeRepositorioInstance = new ChequeBoletoAtividadeRepositorio();
                return iChequeBoletoAtividadeRepositorioInstance;
            }

        }
        #endregion
    }
}