using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloBasico.Singleton;
using Negocios.ModuloTurno.Repositorios;
using Negocios.ModuloTurno.Processos;
using Negocios.ModuloTurno.Fabricas;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloTurno.Excecoes;

namespace Negocios.ModuloTurno.Processos
{
    /// <summary>
    /// Classe TurnoProcesso
    /// </summary>
    public class TurnoProcesso : Singleton<TurnoProcesso>, ITurnoProcesso
    {
        #region Atributos
        private ITurnoRepositorio turnoRepositorio = null;
        #endregion

        #region Construtor
        public TurnoProcesso()
        {
            turnoRepositorio = TurnoFabrica.ITurnoInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(Turno turno)
        {
            this.turnoRepositorio.Incluir(turno);

        }

        public void Excluir(Turno turno)
        {
            try
            {
                if (turno.ID == 0)
                    throw new TurnoNaoExcluidoExcecao();

                List<Turno> resultado = turnoRepositorio.Consultar(turno, TipoPesquisa.E);

                if (resultado == null || resultado.Count <= 0 || resultado.Count > 1)
                    throw new TurnoNaoExcluidoExcecao();

                resultado[0].Status = (int)Status.Inativo;

                this.Alterar(resultado[0]);
            }
            catch (Exception e)
            {

                throw e;
            }
            //this.turnoRepositorio.Excluir(turno);
        }

        public void Alterar(Turno turno)
        {
            this.turnoRepositorio.Alterar(turno);
        }

        public  List<Turno> Consultar(Turno turno, TipoPesquisa tipoPesquisa)
        {
            List<Turno> turnoList = this.turnoRepositorio.Consultar(turno,tipoPesquisa);           

            return turnoList;
        }

        public List<Turno> Consultar()
        {
            List<Turno> turnoList = this.turnoRepositorio.Consultar();

            return turnoList;
        }


        public void Confirmar()
        {
            this.turnoRepositorio.Confirmar();
        }

        #endregion
    }
}