using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloBasico.Singleton;
using Negocios.ModuloSala.Repositorios;
using Negocios.ModuloSala.Processos;
using Negocios.ModuloSala.Fabricas;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloSala.Excecoes;

namespace Negocios.ModuloSala.Processos
{
    /// <summary>
    /// Classe SalaProcesso
    /// </summary>
    public class SalaProcesso : Singleton<SalaProcesso>, ISalaProcesso
    {
        #region Atributos
        private ISalaRepositorio salaRepositorio = null;
        #endregion

        #region Construtor
        public SalaProcesso()
        {
            salaRepositorio = SalaFabrica.ISalaInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(Sala sala)
        {
            this.salaRepositorio.Incluir(sala);

        }

        public void Excluir(Sala sala)
        {

            try
            {
                if (sala.ID == 0)
                    throw new SalaNaoExcluidaExcecao();

                List<Sala> resultado = salaRepositorio.Consultar(sala, TipoPesquisa.E);

                if (resultado == null || resultado.Count <= 0 || resultado.Count > 1)
                    throw new SalaNaoExcluidaExcecao();

                resultado[0].Status = (int)Status.Inativo;
                this.Alterar(resultado[0]);
            }
            catch (Exception e)
            {

                throw e;
            }
            //this.salaRepositorio.Excluir(sala);
        }

        public void Alterar(Sala sala)
        {
            this.salaRepositorio.Alterar(sala);
        }

        public List<Sala> Consultar(Sala sala, TipoPesquisa tipoPesquisa)
        {
            List<Sala> salaList = this.salaRepositorio.Consultar(sala, tipoPesquisa);           

            return salaList;
        }

        public List<Sala> Consultar()
        {
            List<Sala> salaList = this.salaRepositorio.Consultar();

            return salaList;
        }
        public void Confirmar()
        {
            this.salaRepositorio.Confirmar();
        }

        #endregion
    }
}