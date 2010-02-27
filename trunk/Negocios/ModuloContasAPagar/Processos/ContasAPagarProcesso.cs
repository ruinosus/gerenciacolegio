using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Singleton;
using Negocios.ModuloContasAPagar.Repositorios;
using Negocios.ModuloContasAPagar.Processos;
using Negocios.ModuloContasAPagar.Fabricas;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloContasAPagar.Excecoes;

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

            try
            {
                if (contasAPagar.ID == 0)
                    throw new ContasAPagarNaoExcluidaExcecao();

                List<ContasAPagar> resultado = contasAPagarRepositorio.Consultar(contasAPagar, TipoPesquisa.E);

                if (resultado == null || resultado.Count <= 0 || resultado.Count > 1)
                    throw new ContasAPagarNaoExcluidaExcecao();

                resultado[0].Status = (int)Status.Inativo;
                this.Alterar(resultado[0]);
            }
            catch (Exception e)
            {

                throw e;
            }
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