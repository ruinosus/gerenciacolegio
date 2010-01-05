using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;

namespace Negocios.ModuloDependencia.Processos
{
    /// <summary>
    /// Interface IDependenciaRepositorio
    /// </summary>
    public interface IDependenciaProcesso
    {
        /// <summary>
        /// M�todo respons�vel por incluir uma dependencia no sistema.
        /// </summary>
        /// <param name="dependencia">Objeto do tipo dependencia a ser incluido.</param>
        void Incluir(Dependencia dependencia);

        /// <summary>
        /// M�todo respons�vel por excluir uma dependencia do sistema.
        /// </summary>
        /// <param name="dependencia">Objeto do tipo dependencia a ser excluido.</param>
        void Excluir(Dependencia dependencia);

        /// <summary>
        /// M�todo repons�vel por alterar uma dependencia do sistema.
        /// </summary>
        /// <param name="dependencia">Objeto do tipo dependencia a ser alterado.</param>
        void Alterar(Dependencia dependencia);

        /// <summary>
        /// M�todo respons�vel por consultar dependencias do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="dependencia">Objeto do tipo dependencia que ir� ser utilizado como parametro de pesquisa.</param>
        /// <returns>Lista contendo todas as dependencias cadastradas.</returns>
        List<Dependencia> Consultar(Dependencia dependencia);

        /// <summary>
        /// M�todo respons�vel por consultar todas as dependencias do sistema.
        /// </summary>
        /// <returns>Lista contendo todas as dependencias cadastradas.</returns>
        List<Dependencia> Consultar();
		
		/// <summary>
        /// M�todo respons�vel por confirmar as altera��es no sistema.
        /// </summary>       
		void Confirmar();
    }
}