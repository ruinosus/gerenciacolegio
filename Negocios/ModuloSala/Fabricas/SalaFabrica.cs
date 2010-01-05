using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloSala.Repositorios;

namespace Negocios.ModuloSala.Fabricas
{
    /// <summary>
    /// Classe SalaFabrica
    /// </summary>
    public class SalaFabrica
    {
        #region Atributos
        private static ISalaRepositorio iSalaRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface ISalaRepositorio.
        /// </summary>
        public static ISalaRepositorio ISalaInstance
        {
            get
            {
                iSalaRepositorioInstance = new SalaRepositorio();
                return iSalaRepositorioInstance;
            }

        }
        #endregion
    }
}