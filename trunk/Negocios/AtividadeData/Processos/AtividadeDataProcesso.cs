using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAuxiliar.Singleton;
using Negocios.ModuloAtividadeData.Repositorios;
using Negocios.ModuloAtividadeData.Processos;
using Negocios.ModuloAtividadeData.Fabricas;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloAtividadeData.Excecoes;

namespace Negocios.ModuloAtividadeData.Processos
{
    /// <summary>
    /// Classe AtividadeDataProcesso
    /// </summary>
    public class AtividadeDataProcesso : Singleton<AtividadeDataProcesso>, IAtividadeDataProcesso
    {
        #region Atributos
        private IAtividadeDataRepositorio atividadeDataRepositorio = null;
        #endregion

        #region Construtor
        public AtividadeDataProcesso()
        {
            atividadeDataRepositorio = AtividadeDataFabrica.IAtividadeDataInstance;
        }

        #endregion

        #region Métodos da Interface

        public void Incluir(AtividadeData atividadeData)
        {
            if (atividadeData == null)
                throw new AtividadeDataNaoIncluidaExcecao();

            this.atividadeDataRepositorio.Incluir(atividadeData);

        }

        public void Excluir(AtividadeData atividadeData)
        {
            if (atividadeData == null || atividadeData.ID == 0)
                throw new AtividadeDataNaoExcluidaExcecao();

            this.atividadeDataRepositorio.Excluir(atividadeData);
        }

        public void Alterar(AtividadeData atividadeData)
        {
            if (atividadeData == null || atividadeData.ID == 0)
                throw new AtividadeDataNaoAlteradaExcecao();

            this.atividadeDataRepositorio.Alterar(atividadeData);
        }

        public List<AtividadeData> Consultar(AtividadeData atividadeData, TipoPesquisa tipoPesquisa)
        {
            List<AtividadeData> atividadeDataList = this.atividadeDataRepositorio.Consultar(atividadeData, tipoPesquisa);

            return atividadeDataList;
        }

        public List<AtividadeData> Consultar()
        {
            List<AtividadeData> atividadeDataList = this.atividadeDataRepositorio.Consultar();

            return atividadeDataList;
        }



        public void Confirmar()
        {
            this.atividadeDataRepositorio.Confirmar();
        }

        #endregion
    }
}