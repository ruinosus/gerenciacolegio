using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAtividadeData.Repositorios;

namespace Negocios.ModuloAtividadeData.Fabricas
{
    /// <summary>
    /// Classe AtividadeDataFabrica
    /// </summary>
    public class AtividadeDataFabrica
    {
        #region Atributos
        private static IAtividadeDataRepositorio iAtividadeDataRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface IAtividadeDataRepositorio.
        /// </summary>
        public static IAtividadeDataRepositorio IAtividadeDataInstance
        {
            get
            {
                iAtividadeDataRepositorioInstance = new AtividadeDataRepositorio();
                return iAtividadeDataRepositorioInstance;
            }

        }
        #endregion
    }
}