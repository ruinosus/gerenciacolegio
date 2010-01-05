using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloMatricula.Repositorios;

namespace Negocios.ModuloMatricula.Fabricas
{
    /// <summary>
    /// Classe MatriculaFabrica
    /// </summary>
    public class MatriculaFabrica
    {
        #region Atributos
        private static IMatriculaRepositorio iMatriculaRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface IMatriculaRepositorio.
        /// </summary>
        public static IMatriculaRepositorio IMatriculaInstance
        {
            get
            {
                iMatriculaRepositorioInstance = new MatriculaRepositorio();
                return iMatriculaRepositorioInstance;
            }

        }
        #endregion
    }
}