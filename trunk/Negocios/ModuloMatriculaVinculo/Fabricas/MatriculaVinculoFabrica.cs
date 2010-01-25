using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloMatriculaVinculo.Repositorios;

namespace Negocios.ModuloMatriculaVinculo.Fabricas
{
    /// <summary>
    /// Classe MatriculaVinculoFabrica
    /// </summary>
    public class MatriculaVinculoFabrica
    {
        #region Atributos
        private static IMatriculaVinculoRepositorio iMatriculaVinculoRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface IMatriculaVinculoRepositorio.
        /// </summary>
        public static IMatriculaVinculoRepositorio IMatriculaVinculoInstance
        {
            get
            {
                iMatriculaVinculoRepositorioInstance = new MatriculaVinculoRepositorio();
                return iMatriculaVinculoRepositorioInstance;
            }

        }
        #endregion
    }
}