using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAluno.Repositorios;

namespace Negocios.ModuloAluno.Fabricas
{
    /// <summary>
    /// Classe AlunoFabrica
    /// </summary>
    public class AlunoFabrica
    {
        #region Atributos
        private static IAlunoRepositorio iAlunoRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface IAlunoRepositorio.
        /// </summary>
        public static IAlunoRepositorio IAlunoInstance
        {
            get
            {
                iAlunoRepositorioInstance = new AlunoRepositorio();
                return iAlunoRepositorioInstance;
            }

        }
        #endregion
    }
}