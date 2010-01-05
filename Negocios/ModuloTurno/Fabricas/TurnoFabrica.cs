using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloTurno.Repositorios;

namespace Negocios.ModuloTurno.Fabricas
{
    /// <summary>
    /// Classe TurnoFabrica
    /// </summary>
    public class TurnoFabrica
    {
        #region Atributos
        private static ITurnoRepositorio iTurnoRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface ITurnoRepositorio.
        /// </summary>
        public static ITurnoRepositorio ITurnoInstance
        {
            get {
                iTurnoRepositorioInstance = new TurnoRepositorio();
                return iTurnoRepositorioInstance;
            }

        }
        #endregion
    }
}