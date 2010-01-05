using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloSerie.Repositorios;

namespace Negocios.ModuloSerie.Fabricas
{
    /// <summary>
    /// Classe SerieFabrica
    /// </summary>
    public class SerieFabrica
    {
        #region Atributos
        private static ISerieRepositorio iSerieRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface ISerieRepositorio.
        /// </summary>
        public static ISerieRepositorio ISerieInstance
        {
            get
            {
                iSerieRepositorioInstance = new SerieRepositorio();
                return iSerieRepositorioInstance;
            }

        }
        #endregion
    }
}