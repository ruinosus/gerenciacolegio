using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloPostagem.Repositorios;

namespace Negocios.ModuloPostagem.Fabricas
{
    /// <summary>
    /// Summary description for ModuloPostagemFabrica
    /// </summary>
    public static class ModuloPostagemFabrica
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
            get { return new PostagemRepositorio(); }

        }
        #endregion
    }
}