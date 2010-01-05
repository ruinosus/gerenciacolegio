using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloTurma.Repositorios;

namespace Negocios.ModuloTurma.Fabricas
{
    /// <summary>
    /// Classe TurmaFabrica
    /// </summary>
    public class TurmaFabrica
    {
        #region Atributos
        private static ITurmaRepositorio iTurmaRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface ITurmaRepositorio.
        /// </summary>
        public static ITurmaRepositorio ITurmaInstance
        {
            get
            {
                iTurmaRepositorioInstance = new TurmaRepositorio();
                return iTurmaRepositorioInstance;
            }

        }
        #endregion
    }
}