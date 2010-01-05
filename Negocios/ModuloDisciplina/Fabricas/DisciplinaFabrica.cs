using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloDisciplina.Repositorios;

namespace Negocios.ModuloDisciplina.Fabricas
{
    /// <summary>
    /// Classe DisciplinaFabrica
    /// </summary>
    public class DisciplinaFabrica
    {
        #region Atributos
        private static IDisciplinaRepositorio iDisciplinaRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface IDisciplinaRepositorio.
        /// </summary>
        public static IDisciplinaRepositorio IDisciplinaInstance
        {
            get
            {
                iDisciplinaRepositorioInstance = new DisciplinaRepositorio();
                return iDisciplinaRepositorioInstance;
            }

        }
        #endregion
    }
}