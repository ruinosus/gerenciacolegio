using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;

namespace Negocios.ModuloDisciplina.Processos
{
    /// <summary>
    /// Interface IDisciplinaRepositorio
    /// </summary>
    public interface IDisciplinaProcesso
    {
        /// <summary>
        /// M�todo respons�vel por incluir uma disciplina no sistema.
        /// </summary>
        /// <param name="disciplina">Objeto do tipo disciplina a ser incluido.</param>
        void Incluir(Disciplina disciplina);

        /// <summary>
        /// M�todo respons�vel por excluir uma disciplina do sistema.
        /// </summary>
        /// <param name="disciplina">Objeto do tipo disciplina a ser excluido.</param>
        void Excluir(Disciplina disciplina);

        /// <summary>
        /// M�todo repons�vel por alterar uma disciplina do sistema.
        /// </summary>
        /// <param name="disciplina">Objeto do tipo disciplina a ser alterado.</param>
        void Alterar(Disciplina disciplina);

        /// <summary>
        /// M�todo respons�vel por consultar disciplinas do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="disciplina">Objeto do tipo disciplina que ir� ser utilizado como parametro de pesquisa.</param>
        /// <returns>Lista contendo todas as disciplinas cadastradas.</returns>
        List<Disciplina> Consultar(Disciplina disciplina);

        /// <summary>
        /// M�todo respons�vel por consultar todas as disciplinas do sistema.
        /// </summary>
        /// <returns>Lista contendo todas as disciplinas cadastradas.</returns>
        List<Disciplina> Consultar();
		
		/// <summary>
        /// M�todo respons�vel por confirmar as altera��es no sistema.
        /// </summary>       
		void Confirmar();
    }
}