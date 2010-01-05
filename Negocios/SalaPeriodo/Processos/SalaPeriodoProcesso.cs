using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAuxiliar.Singleton;
using Negocios.ModuloSalaPeriodo.Repositorios;
using Negocios.ModuloSalaPeriodo.Processos;
using Negocios.ModuloSalaPeriodo.Fabricas;

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
            this.salaPeriodoRepositorio.Excluir(salaPeriodo);
        }

        public void Alterar(SalaPeriodo salaPeriodo)
        {
            this.salaPeriodoRepositorio.Alterar(salaPeriodo);
        }

        public List<SalaPeriodo> Consultar(SalaPeriodo salaPeriodo)
        {
            List<SalaPeriodo> salaPeriodoList = this.salaPeriodoRepositorio.Consultar(salaPeriodo);           

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