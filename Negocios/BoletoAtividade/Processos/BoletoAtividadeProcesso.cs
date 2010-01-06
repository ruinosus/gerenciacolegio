using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAuxiliar.Singleton;
using Negocios.ModuloBoletoAtividade.Repositorios;
using Negocios.ModuloBoletoAtividade.Processos;
using Negocios.ModuloBoletoAtividade.Fabricas;

namespace Negocios.ModuloBoletoAtividade.Processos
{
    /// <summary>
    /// Classe BoletoAtividadeProcesso
    /// </summary>
    public class BoletoAtividadeProcesso : Singleton<BoletoAtividadeProcesso>, IBoletoAtividadeProcesso
    {
        #region Atributos
        private IBoletoAtividadeRepositorio boletoAtividadeRepositorio = null;
        #endregion

        #region Construtor
        public BoletoAtividadeProcesso()
        {
            boletoAtividadeRepositorio = BoletoAtividadeFabrica.IBoletoAtividadeInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(BoletoAtividade boletoAtividade)
        {
            this.boletoAtividadeRepositorio.Incluir(boletoAtividade);

        }

        public void Excluir(BoletoAtividade boletoAtividade)
        {
            this.boletoAtividadeRepositorio.Excluir(boletoAtividade);
        }

        public void Alterar(BoletoAtividade boletoAtividade)
        {
            this.boletoAtividadeRepositorio.Alterar(boletoAtividade);
        }

        public List<BoletoAtividade> Consultar(BoletoAtividade boletoAtividade)
        {
            List<BoletoAtividade> boletoAtividadeList = this.boletoAtividadeRepositorio.Consultar(boletoAtividade, Negocios.ModuloBasico.Enums.TipoPesquisa.E);           

            return boletoAtividadeList;
        }

        public List<BoletoAtividade> Consultar()
        {
            List<BoletoAtividade> boletoAtividadeList = this.boletoAtividadeRepositorio.Consultar();

            return boletoAtividadeList;
        }



        public void Confirmar()
        {
            this.boletoAtividadeRepositorio.Confirmar();
        }

        #endregion
    }
}