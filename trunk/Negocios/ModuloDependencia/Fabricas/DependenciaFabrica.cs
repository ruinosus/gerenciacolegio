using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloDependencia.Repositorios;

namespace Negocios.ModuloDependencia.Fabricas
{
    /// <summary>
    /// Classe DependenciaFabrica
    /// </summary>
    public class DependenciaFabrica
    {
        #region Atributos
        private static IDependenciaRepositorio iDependenciaRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface IDependenciaRepositorio.
        /// </summary>
        public static IDependenciaRepositorio IDependenciaInstance
        {
            get
            {
                iDependenciaRepositorioInstance = new DependenciaRepositorio();
                return iDependenciaRepositorioInstance;
            }

        }
        #endregion
    }
}