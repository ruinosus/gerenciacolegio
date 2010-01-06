using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using Negocios.ModuloControleAcesso.Repositorios;

namespace Negocios.ModuloControleAcesso.Fabricas
{
    /// <summary>
    /// Summary description for ModuloControleAcessoFabrica
    /// </summary>
    public static class ModuloControleAcessoFabrica
    {
        #region Atributos
        private static IUsuarioSistemaRepositorio iUsuarioSistemaRepositorioInstance;

        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface IUsuarioSistemaRepositorio.
        /// </summary>
        public static IUsuarioSistemaRepositorio IUsuarioSistemaRepositorioInstance
        {
            get
            {
                iUsuarioSistemaRepositorioInstance = new UsuarioSistemaRepositorio();
                return iUsuarioSistemaRepositorioInstance;
            }

        }
        #endregion
    }
}