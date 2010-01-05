using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAuxiliar.Singleton;
using Negocios.ModuloAtividade.Repositorios;
using Negocios.ModuloAtividade.Processos;
using Negocios.ModuloAtividade.Fabricas;

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
            this.atividadeRepositorio.Excluir(atividade);
        }

        public void Alterar(Atividade atividade)
        {
            this.atividadeRepositorio.Alterar(atividade);
        }

        public List<Atividade> Consultar(Atividade atividade)
        {
            List<Atividade> atividadeList = this.atividadeRepositorio.Consultar(atividade);           

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