using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloFuncionario.Repositorios;

namespace Negocios.ModuloFuncionario.Fabricas
{
    /// <summary>
    /// Classe FuncionarioFabrica
    /// </summary>
    public class FuncionarioFabrica
    {
        #region Atributos
        private static IFuncionarioRepositorio iFuncionarioRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface IFuncionarioRepositorio.
        /// </summary>
        public static IFuncionarioRepositorio IFuncionarioInstance
        {
            get
            {
                iFuncionarioRepositorioInstance = new FuncionarioRepositorio();
                return iFuncionarioRepositorioInstance;
            }

        }
        #endregion
    }
}