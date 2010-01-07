using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBoletoAtividade.Repositorios;

namespace Negocios.ModuloBoletoAtividade.Fabricas
{
    /// <summary>
    /// Classe BoletoAtividadeFabrica
    /// </summary>
    public class BoletoAtividadeFabrica
    {
        #region Atributos
        private static IBoletoAtividadeRepositorio iBoletoAtividadeRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface IBoletoAtividadeRepositorio.
        /// </summary>
        public static IBoletoAtividadeRepositorio IBoletoAtividadeInstance
        {
            get
            {
                iBoletoAtividadeRepositorioInstance = new BoletoAtividadeRepositorio();
                return iBoletoAtividadeRepositorioInstance;
            }

        }
        #endregion
    }
}