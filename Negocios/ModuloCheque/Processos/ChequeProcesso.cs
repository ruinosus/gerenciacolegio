using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloAuxiliar.Singleton;
using Negocios.ModuloCheque.Repositorios;
using Negocios.ModuloCheque.Processos;
using Negocios.ModuloCheque.Fabricas;

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
            this.chequeRepositorio.Excluir(cheque);
        }

        public void Alterar(Cheque cheque)
        {
            this.chequeRepositorio.Alterar(cheque);
        }

        public List<Cheque> Consultar(Cheque cheque)
        {
            List<Cheque> chequeList = this.chequeRepositorio.Consultar(cheque);           

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