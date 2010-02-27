using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Singleton;
using Negocios.ModuloChequeBoletoAtividade.Repositorios;
using Negocios.ModuloChequeBoletoAtividade.Processos;
using Negocios.ModuloChequeBoletoAtividade.Fabricas;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloChequeBoletoAtividade.Excecoes;

namespace Negocios.ModuloChequeBoletoAtividade.Processos
{
    /// <summary>
    /// Classe ChequeBoletoAtividadeProcesso
    /// </summary>
    public class ChequeBoletoAtividadeProcesso : Singleton<ChequeBoletoAtividadeProcesso>, IChequeBoletoAtividadeProcesso
    {
        #region Atributos
        private IChequeBoletoAtividadeRepositorio chequeBoletoAtividadeRepositorio = null;
        #endregion

        #region Construtor
        public ChequeBoletoAtividadeProcesso()
        {
            chequeBoletoAtividadeRepositorio = ChequeBoletoAtividadeFabrica.IChequeBoletoAtividadeInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(ChequeBoletoAtividade chequeBoletoAtividade)
        {
            this.chequeBoletoAtividadeRepositorio.Incluir(chequeBoletoAtividade);

        }

        public void Excluir(ChequeBoletoAtividade chequeBoletoAtividade)
        {

            try
            {
                if (chequeBoletoAtividade.ID == 0)
                    throw new ChequeBoletoAtividadeNaoExcluidaExcecao();

                List<ChequeBoletoAtividade> resultado = chequeBoletoAtividadeRepositorio.Consultar(chequeBoletoAtividade, TipoPesquisa.E);

                if (resultado == null || resultado.Count <= 0 || resultado.Count > 1)
                    throw new ChequeBoletoAtividadeNaoExcluidaExcecao();

                resultado[0].Status = (int)Status.Inativo;
                this.Alterar(resultado[0]);
            }
            catch (Exception e)
            {

                throw e;
            }
            //this.chequeBoletoAtividadeRepositorio.Excluir(chequeBoletoAtividade);
        }

        public void Alterar(ChequeBoletoAtividade chequeBoletoAtividade)
        {
            this.chequeBoletoAtividadeRepositorio.Alterar(chequeBoletoAtividade);
        }

        public List<ChequeBoletoAtividade> Consultar(ChequeBoletoAtividade chequeBoletoAtividade, TipoPesquisa tipoPesquisa)
        {
            List<ChequeBoletoAtividade> chequeBoletoAtividadeList = this.chequeBoletoAtividadeRepositorio.Consultar(chequeBoletoAtividade, tipoPesquisa);           

            return chequeBoletoAtividadeList;
        }

        public List<ChequeBoletoAtividade> Consultar()
        {
            List<ChequeBoletoAtividade> chequeBoletoAtividadeList = this.chequeBoletoAtividadeRepositorio.Consultar();

            return chequeBoletoAtividadeList;
        }



        public void Confirmar()
        {
            this.chequeBoletoAtividadeRepositorio.Confirmar();
        }

        #endregion
    }
}