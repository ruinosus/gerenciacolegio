using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloComentario.Repositorios;

namespace Negocios.ModuloComentario.Fabricas
{
    /// <summary>
    /// Summary description for ModuloComentarioFabrica
    /// </summary>
    public class ModuloComentarioFabrica
    {
        #region Atributos
        private static IComentarioRepositorio iComentarioRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface IPostagemRepositorio.
        /// </summary>
        public static IComentarioRepositorio IComentarioInstance
        {
            get { return new ComentarioRepositorio(); }

        }
        #endregion
    }
}