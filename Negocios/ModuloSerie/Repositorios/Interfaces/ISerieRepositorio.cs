using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloSerie.Repositorios
{
    /// <summary>
    /// Interface ISerieRepositorio
    /// </summary>
    public interface ISerieRepositorio
    {
        /// <summary>
        /// M�todo respons�vel por incluir uma serie no sistema.
        /// </summary>
        /// <param name="serie">Objeto do tipo serie a ser incluido.</param>
        void Incluir(Serie serie);

        /// <summary>
        /// M�todo respons�vel por excluir uma serie do sistema.
        /// </summary>
        /// <param name="serie">Objeto do tipo serie a ser excluido.</param>
        void Excluir(Serie serie);

        /// <summary>
        /// M�todo repons�vel por alterar uma serie do sistema.
        /// </summary>
        /// <param name="serie">Objeto do tipo serie a ser alterado.</param>
        void Alterar(Serie serie);

        /// <summary>
        /// M�todo respons�vel por consultar series do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="serie">Objeto do tipo serie que ir� ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todas as series cadastradas.</returns>
        List<Serie> Consultar(Serie serie,TipoPesquisa tipoPesquisa);

        /// <summary>
        /// M�todo respons�vel por consultar todas as series do sistema.
        /// </summary>
        /// <returns>Lista contendo todas as series cadastradas.</returns>
        List<Serie> Consultar();
		
		/// <summary>
        /// M�todo respons�vel por confirmar as altera��es no sistema.
        /// </summary>       
		void Confirmar();
    }
}