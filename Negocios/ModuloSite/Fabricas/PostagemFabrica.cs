using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloSite.Repositorios;

namespace Negocios.ModuloSite.Fabricas
{
    /// <summary>
    /// Classe PostagemFabrica
    /// </summary>
    public class PostagemFabrica
    {
        #region Atributos
        private static IPostagemRepositorio iPostagemRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface IPostagemRepositorio.
        /// </summary>
        public static IPostagemRepositorio IPostagemInstance
        {
            get
            {
                iPostagemRepositorioInstance = new PostagemRepositorio();
                return iPostagemRepositorioInstance;
            }

        }
        #endregion
    }
}