using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Negocios.ModuloSalaPeriodo.Repositorios
{
    /// <summary>
    /// Interface ISalaPeriodoRepositorio
    /// </summary>
    public interface ISalaPeriodoRepositorio
    {
        /// <summary>
        /// M�todo respons�vel por incluir uma salaPeriodo no sistema.
        /// </summary>
        /// <param name="turma">Objeto do tipo salaPeriodo a ser incluido.</param>
        void Incluir(SalaPeriodo salaPeriodo);

        /// <summary>
        /// M�todo respons�vel por excluir uma salaPeriodo do sistema.
        /// </summary>
        /// <param name="turma">Objeto do tipo salaPeriodo a ser excluido.</param>
        void Excluir(SalaPeriodo salaPeriodo);

        /// <summary>
        /// M�todo repons�vel por alterar uma salaPeriodo do sistema.
        /// </summary>
        /// <param name="turma">Objeto do tipo salaPeriodo a ser alterado.</param>
        void Alterar(SalaPeriodo salaPeriodo);

        /// <summary>
        /// M�todo respons�vel por consultar salaPeriodos do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="turma">Objeto do tipo turma que ir� ser utilizado como parametro de pesquisa.</param>
        /// <returns>Lista contendo todas as salaPeriodos cadastradas.</returns>
        List<SalaPeriodo> Consultar(SalaPeriodo salaPeriodo);

        /// <summary>
        /// M�todo respons�vel por consultar todas as salaPeriodos do sistema.
        /// </summary>
        /// <returns>Lista contendo todas as salaPeriodos cadastradas.</returns>
        List<SalaPeriodo> Consultar();
		
		/// <summary>
        /// M�todo respons�vel por confirmar as altera��es no sistema.
        /// </summary>       
		void Confirmar();
    }
}