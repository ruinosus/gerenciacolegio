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
using Negocios.ModuloAuxiliar.Repositorios;
using Negocios.ModuloControleAcesso.Repositorios;


namespace Negocios.ModuloAuxiliar.Fabricas
{


    /// <summary>
    /// Summary description for ModuloAuxiliarFabrica
    /// </summary>
    public static class ModuloAuxiliarFabrica
    {

        #region Atributos
        private static ICidadeEstadoRegiaoRepositorio iCidadeEstadoRegiaoRepositorioInstance;

        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da Interface de ICidadeEstadoRegiaoRepositorioInstance.
        /// </summary>
        public static ICidadeEstadoRegiaoRepositorio ICidadeEstadoRegiaoRepositorioInstance
        {
            get { return new CidadeEstadoRegiaoRepositorio(); }
        } 
        #endregion



    }
}