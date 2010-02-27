using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Singleton;
using Negocios.ModuloSalaPeriodo.Repositorios;
using Negocios.ModuloSalaPeriodo.Processos;
using Negocios.ModuloSalaPeriodo.Fabricas;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloSalaPeriodo.Excecoes;

namespace Negocios.ModuloSalaPeriodo.Processos
{
    /// <summary>
    /// Classe SalaPeriodoProcesso
    /// </summary>
    public class SalaPeriodoProcesso : Singleton<SalaPeriodoProcesso>, ISalaPeriodoProcesso
    {
        #region Atributos
        private ISalaPeriodoRepositorio salaPeriodoRepositorio = null;
        #endregion

        #region Construtor
        public SalaPeriodoProcesso()
        {
            salaPeriodoRepositorio = SalaPeriodoFabrica.ISalaPeriodoInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(SalaPeriodo salaPeriodo)
        {
            this.salaPeriodoRepositorio.Incluir(salaPeriodo);

        }

        public void Excluir(SalaPeriodo salaPeriodo)
        {

            try
            {
                if (salaPeriodo.ID == 0)
                    throw new SalaPeriodoNaoExcluidaExcecao();

                List<SalaPeriodo> resultado = salaPeriodoRepositorio.Consultar(salaPeriodo, TipoPesquisa.E);

                if (resultado == null || resultado.Count <= 0 || resultado.Count > 1)
                    throw new SalaPeriodoNaoExcluidaExcecao();

                resultado[0].Status = (int)Status.Inativo;
                this.Alterar(resultado[0]);
            }
            catch (Exception e)
            {

                throw e;
            }
            //this.salaPeriodoRepositorio.Excluir(salaPeriodo);
        }

        public void Alterar(SalaPeriodo salaPeriodo)
        {
            this.salaPeriodoRepositorio.Alterar(salaPeriodo);
        }

        public List<SalaPeriodo> Consultar(SalaPeriodo salaPeriodo, TipoPesquisa tipoPesquisa)
        {
            List<SalaPeriodo> salaPeriodoList = this.salaPeriodoRepositorio.Consultar(salaPeriodo, tipoPesquisa);           

            return salaPeriodoList;
        }

        public List<SalaPeriodo> Consultar()
        {
            List<SalaPeriodo> salaPeriodoList = this.salaPeriodoRepositorio.Consultar();

            return salaPeriodoList;
        }



        public void Confirmar()
        {
            this.salaPeriodoRepositorio.Confirmar();
        }

        #endregion
    }
}