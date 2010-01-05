using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Negocios.ModuloProfessorDisciplinaSala.Processos
{
    /// <summary>
    /// Interface IProfessorDisciplinaSalaRepositorio
    /// </summary>
    public interface IProfessorDisciplinaSalaProcesso
    {
        /// <summary>
        /// M�todo respons�vel por incluir uma professorDisciplinaSala no sistema.
        /// </summary>
        /// <param name="professorDisciplinaSala">Objeto do tipo professorDisciplinaSala a ser incluido.</param>
        void Incluir(ProfessorDisciplinaSala professorDisciplinaSala);

        /// <summary>
        /// M�todo respons�vel por excluir uma professorDisciplinaSala do sistema.
        /// </summary>
        /// <param name="professorDisciplinaSala">Objeto do tipo professorDisciplinaSala a ser excluido.</param>
        void Excluir(ProfessorDisciplinaSala professorDisciplinaSala);

        /// <summary>
        /// M�todo repons�vel por alterar uma professorDisciplinaSala do sistema.
        /// </summary>
        /// <param name="professorDisciplinaSala">Objeto do tipo professorDisciplinaSala a ser alterado.</param>
        void Alterar(ProfessorDisciplinaSala professorDisciplinaSala);

        /// <summary>
        /// M�todo respons�vel por consultar professorDisciplinaSalas do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="professorDisciplinaSala">Objeto do tipo professorDisciplinaSala que ir� ser utilizado como parametro de pesquisa.</param>
        /// <returns>Lista contendo todas as professorDisciplinaSalas cadastradas.</returns>
        List<ProfessorDisciplinaSala> Consultar(ProfessorDisciplinaSala professorDisciplinaSala);

        /// <summary>
        /// M�todo respons�vel por consultar todas as professorDisciplinaSalas do sistema.
        /// </summary>
        /// <returns>Lista contendo todas as professorDisciplinaSalas cadastradas.</returns>
        List<ProfessorDisciplinaSala> Consultar();
		
		/// <summary>
        /// M�todo respons�vel por confirmar as altera��es no sistema.
        /// </summary>       
		void Confirmar();
    }
}