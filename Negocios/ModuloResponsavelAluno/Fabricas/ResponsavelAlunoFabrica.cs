using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloResponsavelAluno.Repositorios;

namespace Negocios.ModuloResponsavelAluno.Fabricas
{
    /// <summary>
    /// Classe ResponsavelAlunoFabrica
    /// </summary>
    public class ResponsavelAlunoFabrica
    {
        #region Atributos
        private static IResponsavelAlunoRepositorio iResponsavelAlunoRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface IResponsavelAlunoRepositorio.
        /// </summary>
        public static IResponsavelAlunoRepositorio IResponsavelAlunoInstance
        {
            get
            {
                iResponsavelAlunoRepositorioInstance = new ResponsavelAlunoRepositorio();
                return iResponsavelAlunoRepositorioInstance;
            }

        }
        #endregion
    }
}