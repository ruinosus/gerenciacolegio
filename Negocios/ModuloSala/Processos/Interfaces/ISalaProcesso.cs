using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;

namespace Negocios.ModuloSala.Processos
{
    /// <summary>
    /// Interface ISalaRepositorio
    /// </summary>
    public interface ISalaProcesso
    {
        /// <summary>
        /// M�todo respons�vel por incluir uma sala no sistema.
        /// </summary>
        /// <param name="sala">Objeto do tipo sala a ser incluido.</param>
        void Incluir(Sala sala);

        /// <summary>
        /// M�todo respons�vel por excluir uma sala do sistema.
        /// </summary>
        /// <param name="sala">Objeto do tipo sala a ser excluido.</param>
        void Excluir(Sala sala);

        /// <summary>
        /// M�todo repons�vel por alterar uma sala do sistema.
        /// </summary>
        /// <param name="sala">Objeto do tipo sala a ser alterado.</param>
        void Alterar(Sala sala);

        /// <summary>
        /// M�todo respons�vel por consultar salas do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="sala">Objeto do tipo sala que ir� ser utilizado como parametro de pesquisa.</param>
        /// <returns>Lista contendo todas as salas cadastradas.</returns>
        List<Sala> Consultar(Sala sala);

        /// <summary>
        /// M�todo respons�vel por consultar todas as salas do sistema.
        /// </summary>
        /// <returns>Lista contendo todas as salas cadastradas.</returns>
        List<Sala> Consultar();
		
		/// <summary>
        /// M�todo respons�vel por confirmar as altera��es no sistema.
        /// </summary>       
		void Confirmar();
    }
}