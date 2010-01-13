using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAuxiliar.Singleton;
using Negocios.ModuloChequeBoletoAtividade.Repositorios;
using Negocios.ModuloChequeBoletoAtividade.Processos;
using Negocios.ModuloChequeBoletoAtividade.Fabricas;
using Negocios.ModuloBasico.Enums;

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