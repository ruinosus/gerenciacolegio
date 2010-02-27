using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloBasico.Singleton;
using Negocios.ModuloCheque.Repositorios;
using Negocios.ModuloCheque.Processos;
using Negocios.ModuloCheque.Fabricas;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloCheque.Excecoes;

namespace Negocios.ModuloCheque.Processos
{
    /// <summary>
    /// Classe ChequeProcesso
    /// </summary>
    public class ChequeProcesso : Singleton<ChequeProcesso>, IChequeProcesso
    {
        #region Atributos
        private IChequeRepositorio chequeRepositorio = null;
        #endregion

        #region Construtor
        public ChequeProcesso()
        {
            chequeRepositorio = ChequeFabrica.IChequeInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(Cheque cheque)
        {
            this.chequeRepositorio.Incluir(cheque);

        }

        public void Excluir(Cheque cheque)
        {

            try
            {
                if (cheque.ID == 0)
                    throw new ChequeNaoExcluidoExcecao();

                List<Cheque> resultado = chequeRepositorio.Consultar(cheque, TipoPesquisa.E);

                if (resultado == null || resultado.Count <= 0 || resultado.Count > 1)
                    throw new ChequeNaoExcluidoExcecao();

                resultado[0].Status = (int)Status.Inativo;
                this.Alterar(resultado[0]);
            }
            catch (Exception e)
            {

                throw e;
            }
            //this.chequeRepositorio.Excluir(cheque);
        }

        public void Alterar(Cheque cheque)
        {
            this.chequeRepositorio.Alterar(cheque);
        }

        public List<Cheque> Consultar(Cheque cheque, TipoPesquisa tipoPesquisa)
        {
            List<Cheque> chequeList = this.chequeRepositorio.Consultar(cheque,tipoPesquisa);           

            return chequeList;
        }

        public List<Cheque> Consultar()
        {
            List<Cheque> chequeList = this.chequeRepositorio.Consultar();

            return chequeList;
        }

     
        public void Confirmar()
        {
            this.chequeRepositorio.Confirmar();
        }

        #endregion
    }
}