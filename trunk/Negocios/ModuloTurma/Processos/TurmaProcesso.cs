
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloBasico.Singleton;
using Negocios.ModuloTurma.Repositorios;
using Negocios.ModuloTurma.Processos;
using Negocios.ModuloTurma.Fabricas;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloTurma.Excecoes;
namespace Negocios.ModuloTurma.Processos
{
    /// <summary>
    /// Classe TurmaProcesso
    /// </summary>
    public class TurmaProcesso : Singleton<TurmaProcesso>, ITurmaProcesso
    {
        #region Atributos
        private ITurmaRepositorio turmaRepositorio = null;
        #endregion

        #region Construtor
        public TurmaProcesso()
        {
            turmaRepositorio = TurmaFabrica.ITurmaInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(Turma turma)
        {
            this.turmaRepositorio.Incluir(turma);

        }

        public void Excluir(Turma turma)
        {
            try
            {
                if (turma.ID == 0)
                    throw new TurmaNaoExcluidaExcecao();

                List<Turma> resultado = turmaRepositorio.Consultar(turma, TipoPesquisa.E);

                if (resultado == null || resultado.Count <= 0 || resultado.Count > 1)
                    throw new TurmaNaoExcluidaExcecao();

                resultado[0].Status = (int)Status.Inativo;
                this.Alterar(resultado[0]);
            }
            catch (Exception e)
            {

                throw e;
            }
            //this.turmaRepositorio.Excluir(turma);
        }

        public void Alterar(Turma turma)
        {
            this.turmaRepositorio.Alterar(turma);
        }

        public List<Turma> Consultar(Turma turma, TipoPesquisa tipoPesquisa)
        {
            List<Turma> turmaList = this.turmaRepositorio.Consultar(turma,tipoPesquisa);           

            return turmaList;
        }

        public List<Turma> Consultar()
        {
            List<Turma> turmaList = this.turmaRepositorio.Consultar();

            return turmaList;
        }

        public void Confirmar()
        {
            this.turmaRepositorio.Confirmar();
        }

        #endregion
    }
}