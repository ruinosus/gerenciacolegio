using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAuxiliar.Singleton;
using Negocios.ModuloBoletoMensalidade.Repositorios;
using Negocios.ModuloBoletoMensalidade.Processos;
using Negocios.ModuloBoletoMensalidade.Fabricas;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloBoletoMensalidade.Processos
{
    /// <summary>
    /// Classe BoletoMensalidadeProcesso
    /// </summary>
    public class BoletoMensalidadeProcesso : Singleton<BoletoMensalidadeProcesso>, IBoletoMensalidadeProcesso
    {
        #region Atributos
        private IBoletoMensalidadeRepositorio boletoMensalidadeRepositorio = null;
        #endregion

        #region Construtor
        public BoletoMensalidadeProcesso()
        {
            boletoMensalidadeRepositorio = BoletoMensalidadeFabrica.IBoletoMensalidadeInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(BoletoMensalidade boletoMensalidade)
        {
            this.boletoMensalidadeRepositorio.Incluir(boletoMensalidade);

        }

        public void Excluir(BoletoMensalidade boletoMensalidade)
        {
            this.boletoMensalidadeRepositorio.Excluir(boletoMensalidade);
        }

        public void Alterar(BoletoMensalidade boletoMensalidade)
        {
            this.boletoMensalidadeRepositorio.Alterar(boletoMensalidade);
        }

        public List<BoletoMensalidade> Consultar(BoletoMensalidade boletoMensalidade, TipoPesquisa tipoPesquisa)
        {
            List<BoletoMensalidade> boletoMensalidadeList = this.boletoMensalidadeRepositorio.Consultar(boletoMensalidade, tipoPesquisa);           

            return boletoMensalidadeList;
        }

        public List<BoletoMensalidade> Consultar()
        {
            List<BoletoMensalidade> boletoMensalidadeList = this.boletoMensalidadeRepositorio.Consultar();

            return boletoMensalidadeList;
        }



        public void Confirmar()
        {
            this.boletoMensalidadeRepositorio.Confirmar();
        }

        #endregion
    }
}