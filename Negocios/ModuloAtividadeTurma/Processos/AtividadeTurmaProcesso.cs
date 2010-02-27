using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Singleton;
using Negocios.ModuloAtividadeTurma.Repositorios;
using Negocios.ModuloAtividadeTurma.Processos;
using Negocios.ModuloAtividadeTurma.Fabricas;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloAtividadeTurma.Excecoes;

namespace Negocios.ModuloAtividadeTurma.Processos
{
    /// <summary>
    /// Classe AtividadeTurmaProcesso
    /// </summary>
    public class AtividadeTurmaProcesso : Singleton<AtividadeTurmaProcesso>, IAtividadeTurmaProcesso
    {
        #region Atributos
        private IAtividadeTurmaRepositorio atividadeTurmaRepositorio = null;
        #endregion
         
        #region Construtor
        public AtividadeTurmaProcesso()
        {
            atividadeTurmaRepositorio = AtividadeTurmaFabrica.IAtividadeTurmaInstance;
        }

        #endregion

        #region Métodos da Interface

        public void Incluir(AtividadeTurma atividadeTurma)
        {
            if (atividadeTurma == null)
                throw new AtividadeTurmaNaoIncluidaExcecao();

            this.atividadeTurmaRepositorio.Incluir(atividadeTurma);

        }

        public void Excluir(AtividadeTurma atividadeTurma)
        {

            try
            {
                if (atividadeTurma.ID == 0)
                    throw new AtividadeTurmaNaoExcluidaExcecao();

                List<AtividadeTurma> resultado = atividadeTurmaRepositorio.Consultar(atividadeTurma, TipoPesquisa.E);

                if (resultado == null || resultado.Count <= 0 || resultado.Count > 1)
                    throw new AtividadeTurmaNaoExcluidaExcecao();

                resultado[0].Status = (int)Status.Inativo;
                this.Alterar(resultado[0]);

            }
            catch (Exception e)
            {

                throw e;
            }

            //this.atividadeTurmaRepositorio.Excluir(atividadeTurma);
        }

        public void Alterar(AtividadeTurma atividadeTurma)
        {
            if (atividadeTurma == null || atividadeTurma.ID == 0)
                throw new AtividadeTurmaNaoAlteradaExcecao();

            this.atividadeTurmaRepositorio.Alterar(atividadeTurma);
        }

        public List<AtividadeTurma> Consultar(AtividadeTurma atividadeTurma, TipoPesquisa tipoPesquisa)
        {
            List<AtividadeTurma> atividadeTurmaList = this.atividadeTurmaRepositorio.Consultar(atividadeTurma, tipoPesquisa);

            return atividadeTurmaList;
        }

        public List<AtividadeTurma> Consultar()
        {
            List<AtividadeTurma> atividadeTurmaList = this.atividadeTurmaRepositorio.Consultar();

            return atividadeTurmaList;
        }



        public void Confirmar()
        {
            this.atividadeTurmaRepositorio.Confirmar();
        }

        #endregion
    }
}