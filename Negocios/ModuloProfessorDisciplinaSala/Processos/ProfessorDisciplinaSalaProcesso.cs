using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Singleton;
using Negocios.ModuloProfessorDisciplinaSala.Repositorios;
using Negocios.ModuloProfessorDisciplinaSala.Processos;
using Negocios.ModuloProfessorDisciplinaSala.Fabricas;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloProfessorDisciplinaSala.Excecoes;

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


        #region Métodos da Interface

        public void Incluir(ProfessorDisciplinaSala professorDisciplinaSala)
        {
            this.professorDisciplinaSalaRepositorio.Incluir(professorDisciplinaSala);

        }

        public void Excluir(ProfessorDisciplinaSala professorDisciplinaSala)
        {

            try
            {
                if (professorDisciplinaSala.ID == 0)
                    throw new ProfessorDisciplinaSalaNaoExcluidaExcecao();

                List<ProfessorDisciplinaSala> resultado = professorDisciplinaSalaRepositorio.Consultar(professorDisciplinaSala, TipoPesquisa.E);

                if (resultado == null || resultado.Count <= 0 || resultado.Count > 1)
                    throw new ProfessorDisciplinaSalaNaoExcluidaExcecao();

                resultado[0].Status = (int)Status.Inativo;
                this.Alterar(resultado[0]);
            }
            catch (Exception e)
            {

                throw e;
            }
            //this.professorDisciplinaSalaRepositorio.Excluir(professorDisciplinaSala);
        }

        public void Alterar(ProfessorDisciplinaSala professorDisciplinaSala)
        {
            this.professorDisciplinaSalaRepositorio.Alterar(professorDisciplinaSala);
        }

        public List<ProfessorDisciplinaSala> Consultar(ProfessorDisciplinaSala professorDisciplinaSala, TipoPesquisa tipoPesquisa)
        {
            List<ProfessorDisciplinaSala> professorDisciplinaSalaList = this.professorDisciplinaSalaRepositorio.Consultar(professorDisciplinaSala,tipoPesquisa);           

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