using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAlunoAtividade.Repositorios;

namespace Negocios.ModuloAlunoAtividade.Fabricas
{
    /// <summary>
    /// Classe AlunoAtividadeFabrica
    /// </summary>
    public class AlunoAtividadeFabrica
    {
        #region Atributos
        private static IAlunoAtividadeRepositorio iAlunoAtividadeRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface IAlunoAtividadeRepositorio.
        /// </summary>
        public static IAlunoAtividadeRepositorio IAlunoAtividadeInstance
        {
            get {
                iAlunoAtividadeRepositorioInstance = new AlunoAtividadeRepositorio();
                return iAlunoAtividadeRepositorioInstance;
            }

        }
        #endregion
    }
}