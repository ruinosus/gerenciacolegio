using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloNota.Repositorios;

namespace Negocios.ModuloNota.Fabricas
{
    /// <summary>
    /// Classe NotaFabrica
    /// </summary>
    public class NotaFabrica
    {
        #region Atributos
        private static INotaRepositorio iNotaRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface INotaRepositorio.
        /// </summary>
        public static INotaRepositorio INotaInstance
        {
            get
            {
                iNotaRepositorioInstance = new NotaRepositorio();
                return iNotaRepositorioInstance;
            }

        }
        #endregion
    }
}