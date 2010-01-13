using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAuxiliar.Singleton;
using Negocios.ModuloContasAPagar.Repositorios;
using Negocios.ModuloContasAPagar.Processos;
using Negocios.ModuloContasAPagar.Fabricas;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloContasAPagar.Processos
{
    /// <summary>
    /// Classe ContasAPagarProcesso
    /// </summary>
    public class ContasAPagarProcesso : Singleton<ContasAPagarProcesso>, IContasAPagarProcesso
    {
        #region Atributos
        private IContasAPagarRepositorio contasAPagarRepositorio = null;
        #endregion

        #region Construtor
        public ContasAPagarProcesso()
        {
            contasAPagarRepositorio = ContasAPagarFabrica.IContasAPagarInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(ContasAPagar contasAPagar)
        {
            this.contasAPagarRepositorio.Incluir(contasAPagar);

        }

        public void Excluir(ContasAPagar contasAPagar)
        {
            //this.contasAPagarRepositorio.Excluir(contasAPagar);
        }

        public void Alterar(ContasAPagar contasAPagar)
        {
            this.contasAPagarRepositorio.Alterar(contasAPagar);
        }

        public List<ContasAPagar> Consultar(ContasAPagar contasAPagar, TipoPesquisa tipoPesquisa)
        {
            List<ContasAPagar> contasAPagarList = this.contasAPagarRepositorio.Consultar(contasAPagar,tipoPesquisa);           

            return contasAPagarList;
        }

        public List<ContasAPagar> Consultar()
        {
            List<ContasAPagar> contasAPagarList = this.contasAPagarRepositorio.Consultar();

            return contasAPagarList;
        }



        public void Confirmar()
        {
            this.contasAPagarRepositorio.Confirmar();
        }

        #endregion
    }
}