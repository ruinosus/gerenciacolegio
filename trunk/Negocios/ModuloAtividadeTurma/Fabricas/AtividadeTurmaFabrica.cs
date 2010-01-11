using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAtividadeTurma.Repositorios;

namespace Negocios.ModuloAtividadeTurma.Fabricas
{
    /// <summary>
    /// Classe AtividadeTurmaFabrica
    /// </summary>
    public class AtividadeTurmaFabrica
    {
        #region Atributos
        private static IAtividadeTurmaRepositorio iAtividadeTurmaRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface IAtividadeTurmaRepositorio.
        /// </summary>
        public static IAtividadeTurmaRepositorio IAtividadeTurmaInstance
        {
            get
            {
                iAtividadeTurmaRepositorioInstance = new AtividadeTurmaRepositorio();
                return iAtividadeTurmaRepositorioInstance;
            }

        }
        #endregion
    }
}