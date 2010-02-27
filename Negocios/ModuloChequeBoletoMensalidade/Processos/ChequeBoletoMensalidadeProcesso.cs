using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Singleton;
using Negocios.ModuloChequeBoletoMensalidade.Repositorios;
using Negocios.ModuloChequeBoletoMensalidade.Processos;
using Negocios.ModuloChequeBoletoMensalidade.Fabricas;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloChequeBoletoMensalidade.Excecoes;

namespace Negocios.ModuloChequeBoletoMensalidade.Processos
{
    /// <summary>
    /// Classe ChequeBoletoMensalidadeProcesso
    /// </summary>
    public class ChequeBoletoMensalidadeProcesso : Singleton<ChequeBoletoMensalidadeProcesso>, IChequeBoletoMensalidadeProcesso
    {
        #region Atributos
        private IChequeBoletoMensalidadeRepositorio chequeBoletoMensalidadeRepositorio = null;
        #endregion

        #region Construtor
        public ChequeBoletoMensalidadeProcesso()
        {
            chequeBoletoMensalidadeRepositorio = ChequeBoletoMensalidadeFabrica.IChequeBoletoMensalidadeInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(ChequeBoletoMensalidade chequeBoletoMensalidade)
        {
            this.chequeBoletoMensalidadeRepositorio.Incluir(chequeBoletoMensalidade);

        }

        public void Excluir(ChequeBoletoMensalidade chequeBoletoMensalidade)
        {

            try
            {
                if (chequeBoletoMensalidade.ID == 0)
                    throw new ChequeBoletoMensalidadeNaoExcluidaExcecao();

                List<ChequeBoletoMensalidade> resultado = chequeBoletoMensalidadeRepositorio.Consultar(chequeBoletoMensalidade, TipoPesquisa.E);

                if (resultado == null || resultado.Count <= 0 || resultado.Count > 1)
                    throw new ChequeBoletoMensalidadeNaoExcluidaExcecao();

                resultado[0].Status = (int)Status.Inativo;
                this.Alterar(resultado[0]);
            }
            catch (Exception e)
            {

                throw e;
            }
            //this.chequeBoletoMensalidadeRepositorio.Excluir(chequeBoletoMensalidade);
        }

        public void Alterar(ChequeBoletoMensalidade chequeBoletoMensalidade)
        {
            this.chequeBoletoMensalidadeRepositorio.Alterar(chequeBoletoMensalidade);
        }

        public List<ChequeBoletoMensalidade> Consultar(ChequeBoletoMensalidade chequeBoletoMensalidade, TipoPesquisa tipoPesquisa)
        {
            List<ChequeBoletoMensalidade> chequeBoletoMensalidadeList = this.chequeBoletoMensalidadeRepositorio.Consultar(chequeBoletoMensalidade, tipoPesquisa);

            return chequeBoletoMensalidadeList;
        }

        public List<ChequeBoletoMensalidade> Consultar()
        {
            List<ChequeBoletoMensalidade> chequeBoletoMensalidadeList = this.chequeBoletoMensalidadeRepositorio.Consultar();

            return chequeBoletoMensalidadeList;
        }



        public void Confirmar()
        {
            this.chequeBoletoMensalidadeRepositorio.Confirmar();
        }

        #endregion
    }
}