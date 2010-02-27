using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Singleton;
using Negocios.ModuloBoletoAtividade.Repositorios;
using Negocios.ModuloBoletoAtividade.Processos;
using Negocios.ModuloBoletoAtividade.Fabricas;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloBoletoAtividade.Excecoes;

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
            try
            {
                if (boletoAtividade.ID == 0)
                    throw new BoletoAtividadeNaoExcluidaExcecao();

                List<BoletoAtividade> resultado = boletoAtividadeRepositorio.Consultar(boletoAtividade, TipoPesquisa.E);

                if (resultado == null || resultado.Count <= 0 || resultado.Count > 1)
                    throw new BoletoAtividadeNaoExcluidaExcecao();

                resultado[0].Status = (int)Status.Inativo;
                this.Alterar(resultado[0]);

            }
            catch (Exception e)
            {

                throw e;
            }
            //this.boletoAtividadeRepositorio.Excluir(boletoAtividade);
        }

        public void Alterar(BoletoAtividade boletoAtividade)
        {
            this.boletoAtividadeRepositorio.Alterar(boletoAtividade);
        }

        public List<BoletoAtividade> Consultar(BoletoAtividade boletoAtividade, TipoPesquisa tipoPesquisa)
        {
            List<BoletoAtividade> boletoAtividadeList = this.boletoAtividadeRepositorio.Consultar(boletoAtividade, tipoPesquisa);           

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