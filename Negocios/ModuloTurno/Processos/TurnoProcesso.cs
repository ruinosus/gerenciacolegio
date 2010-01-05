using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloAuxiliar.Singleton;
using Negocios.ModuloTurno.Repositorios;
using Negocios.ModuloTurno.Processos;
using Negocios.ModuloTurno.Fabricas;

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
            this.turnoRepositorio.Excluir(turno);
        }

        public void Alterar(Turno turno)
        {
            this.turnoRepositorio.Alterar(turno);
        }

        public List<Turno> Consultar(Turno turno)
        {
            List<Turno> turnoList = this.turnoRepositorio.Consultar(turno);           

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