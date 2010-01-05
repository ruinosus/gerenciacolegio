using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloProfessorDisciplinaSala.Repositorios;

namespace Negocios.ModuloProfessorDisciplinaSala.Fabricas
{
    /// <summary>
    /// Classe ProfessorDisciplinaSalaFabrica
    /// </summary>
    public class ProfessorDisciplinaSalaFabrica
    {
        #region Atributos
        private static IProfessorDisciplinaSalaRepositorio iProfessorDisciplinaSalaRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface IProfessorDisciplinaSalaRepositorio.
        /// </summary>
        public static IProfessorDisciplinaSalaRepositorio IProfessorDisciplinaSalaInstance
        {
            get
            {
                iProfessorDisciplinaSalaRepositorioInstance = new ProfessorDisciplinaSalaRepositorio();
                return iProfessorDisciplinaSalaRepositorioInstance;
            }

        }
        #endregion
    }
}