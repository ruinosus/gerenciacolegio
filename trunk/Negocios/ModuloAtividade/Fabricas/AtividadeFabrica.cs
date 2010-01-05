using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAtividade.Repositorios;

namespace Negocios.ModuloAtividade.Fabricas
{
    /// <summary>
    /// Classe AtividadeFabrica
    /// </summary>
    public class AtividadeFabrica
    {
        #region Atributos
        private static IAtividadeRepositorio iAtividadeRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface IAtividadeRepositorio.
        /// </summary>
        public static IAtividadeRepositorio IAtividadeInstance
        {
            get {
                iAtividadeRepositorioInstance = new AtividadeRepositorio();
                return iAtividadeRepositorioInstance;
            }

        }
        #endregion
    }
}