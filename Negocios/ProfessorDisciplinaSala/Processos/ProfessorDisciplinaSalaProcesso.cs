using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAuxiliar.Singleton;
using Negocios.ModuloProfessorDisciplinaSala.Repositorios;
using Negocios.ModuloProfessorDisciplinaSala.Processos;
using Negocios.ModuloProfessorDisciplinaSala.Fabricas;

namespace Negocios.ModuloProfessorDisciplinaSala.Processos
{
    /// <summary>
    /// Classe ProfessorDisciplinaSalaProcesso
    /// </summary>
    public class ProfessorDisciplinaSalaProcesso : Singleton<ProfessorDisciplinaSalaProcesso>, IProfessorDisciplinaSalaProcesso
    {
        #region Atributos
        private IProfessorDisciplinaSalaRepositorio professorDisciplinaSalaRepositorio = null;
        #endregion

        #region Construtor
        public ProfessorDisciplinaSalaProcesso()
        {
            professorDisciplinaSalaRepositorio = ProfessorDisciplinaSalaFabrica.IProfessorDisciplinaSalaInstance;
        }

        #endregion


        #region M�todos da Interface

        public void Incluir(ProfessorDisciplinaSala professorDisciplinaSala)
        {
            this.professorDisciplinaSalaRepositorio.Incluir(professorDisciplinaSala);

        }

        public void Excluir(ProfessorDisciplinaSala professorDisciplinaSala)
        {
            this.professorDisciplinaSalaRepositorio.Excluir(professorDisciplinaSala);
        }

        public void Alterar(ProfessorDisciplinaSala professorDisciplinaSala)
        {
            this.professorDisciplinaSalaRepositorio.Alterar(professorDisciplinaSala);
        }

        public List<ProfessorDisciplinaSala> Consultar(ProfessorDisciplinaSala professorDisciplinaSala)
        {
            List<ProfessorDisciplinaSala> professorDisciplinaSalaList = this.professorDisciplinaSalaRepositorio.Consultar(professorDisciplinaSala);           

            return professorDisciplinaSalaList;
        }

        public List<ProfessorDisciplinaSala> Consultar()
        {
            List<ProfessorDisciplinaSala> professorDisciplinaSalaList = this.professorDisciplinaSalaRepositorio.Consultar();

            return professorDisciplinaSalaList;
        }



        public void Confirmar()
        {
            this.professorDisciplinaSalaRepositorio.Confirmar();
        }

        #endregion
    }
}