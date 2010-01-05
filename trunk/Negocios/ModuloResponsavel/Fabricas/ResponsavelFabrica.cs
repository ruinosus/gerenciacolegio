using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloResponsavel.Repositorios;

namespace Negocios.ModuloResponsavel.Fabricas
{
    /// <summary>
    /// Classe ResponsavelFabrica
    /// </summary>
    public class ResponsavelFabrica
    {
        #region Atributos
        private static IResponsavelRepositorio iResponsavelRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface IResponsavelRepositorio.
        /// </summary>
        public static IResponsavelRepositorio IResponsavelInstance
        {
            get
            {
                iResponsavelRepositorioInstance = new ResponsavelRepositorio();
                return iResponsavelRepositorioInstance;
            }

        }
        #endregion
    }
}