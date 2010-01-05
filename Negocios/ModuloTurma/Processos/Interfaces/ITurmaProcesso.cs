using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;

namespace Negocios.ModuloTurma.Processos
{
    /// <summary>
    /// Interface ITurmaRepositorio
    /// </summary>
    public interface ITurmaProcesso
    {
        /// <summary>
        /// M�todo respons�vel por incluir uma turma no sistema.
        /// </summary>
        /// <param name="turma">Objeto do tipo turma a ser incluido.</param>
        void Incluir(Turma turma);

        /// <summary>
        /// M�todo respons�vel por excluir uma turma do sistema.
        /// </summary>
        /// <param name="turma">Objeto do tipo turma a ser excluido.</param>
        void Excluir(Turma turma);

        /// <summary>
        /// M�todo repons�vel por alterar uma turma do sistema.
        /// </summary>
        /// <param name="turma">Objeto do tipo turma a ser alterado.</param>
        void Alterar(Turma turma);

        /// <summary>
        /// M�todo respons�vel por consultar turmas do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="turma">Objeto do tipo turma que ir� ser utilizado como parametro de pesquisa.</param>
        /// <returns>Lista contendo todas as turmas cadastradas.</returns>
        List<Turma> Consultar(Turma turma);

        /// <summary>
        /// M�todo respons�vel por consultar todas as turmas do sistema.
        /// </summary>
        /// <returns>Lista contendo todas as turmas cadastradas.</returns>
        List<Turma> Consultar();
		
		/// <summary>
        /// M�todo respons�vel por confirmar as altera��es no sistema.
        /// </summary>       
		void Confirmar();
    }
}