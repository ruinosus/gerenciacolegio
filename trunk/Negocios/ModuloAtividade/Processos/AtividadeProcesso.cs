using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Singleton;
using Negocios.ModuloAtividade.Repositorios;
using Negocios.ModuloAtividade.Processos;
using Negocios.ModuloAtividade.Fabricas;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloAtividade.Excecoes;

namespace Negocios.ModuloAtividade.Processos
{
    /// <summary>
    /// Classe AtividadeProcesso
    /// </summary>
    public class AtividadeProcesso : Singleton<AtividadeProcesso>, IAtividadeProcesso
    {
        #region Atributos
        private IAtividadeRepositorio atividadeRepositorio = null;
        #endregion

        #region Construtor
        public AtividadeProcesso()
        {
            atividadeRepositorio = AtividadeFabrica.IAtividadeInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(Atividade atividade)
        {
            this.atividadeRepositorio.Incluir(atividade);

        }

        public void Excluir(Atividade atividade)
        {
            try
            {
                if (atividade.ID == 0)
                    throw new AtividadeNaoExcluidaExcecao();

                List<Atividade> resultado = atividadeRepositorio.Consultar(atividade, TipoPesquisa.E);

                if (resultado == null || resultado.Count <= 0 || resultado.Count > 1)
                    throw new AtividadeNaoExcluidaExcecao();

                resultado[0].Status = (int)Status.Inativo;
                this.Alterar(resultado[0]);

            }
            catch (Exception e)
            {

                throw e;
            }

            //this.atividadeRepositorio.Excluir(atividade);
        }

        public void Alterar(Atividade atividade)
        {
            this.atividadeRepositorio.Alterar(atividade);
        }

        public List<Atividade> Consultar(Atividade atividade, TipoPesquisa tipoPesquisa)
        {
            List<Atividade> atividadeList = this.atividadeRepositorio.Consultar(atividade,tipoPesquisa);           

            return atividadeList;
        }

        public List<Atividade> Consultar()
        {
            List<Atividade> atividadeList = this.atividadeRepositorio.Consultar();

            return atividadeList;
        }



        public void Confirmar()
        {
            this.atividadeRepositorio.Confirmar();
        }

        #endregion
    }
}