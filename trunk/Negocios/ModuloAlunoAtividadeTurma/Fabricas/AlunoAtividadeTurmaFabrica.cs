using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAlunoAtividadeTurma.Repositorios;

namespace Negocios.ModuloAlunoAtividadeTurma.Fabricas
{
    /// <summary>
    /// Classe AlunoAtividadeTurmaFabrica
    /// </summary>
    public class AlunoAtividadeTurmaFabrica
    {
        #region Atributos
        private static IAlunoAtividadeTurmaRepositorio iAlunoAtividadeTurmaRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface IAlunoAtividadeTurmaRepositorio.
        /// </summary>
        public static IAlunoAtividadeTurmaRepositorio IAlunoAtividadeTurmaInstance
        {
            get {
                iAlunoAtividadeTurmaRepositorioInstance = new AlunoAtividadeTurmaRepositorio();
                return iAlunoAtividadeTurmaRepositorioInstance;
            }

        }
        #endregion
    }
}