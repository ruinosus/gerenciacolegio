using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloTurma.Repositorios
{
    /// <summary>
    /// Interface ITurmaRepositorio
    /// </summary>
    public interface ITurmaRepositorio
    {
        /// <summary>
        /// Método responsável por incluir uma turma no sistema.
        /// </summary>
        /// <param name="turma">Objeto do tipo turma a ser incluido.</param>
        void Incluir(Turma turma);

        /// <summary>
        /// Método responsável por excluir uma turma do sistema.
        /// </summary>
        /// <param name="turma">Objeto do tipo turma a ser excluido.</param>
        void Excluir(Turma turma);

        /// <summary>
        /// Método reponsável por alterar uma turma do sistema.
        /// </summary>
        /// <param name="turma">Objeto do tipo turma a ser alterado.</param>
        void Alterar(Turma turma);

        /// <summary>
        /// Método responsável por consultar turmas do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="turma">Objeto do tipo turma que irá ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todas as turmas cadastradas.</returns>
        List<Turma> Consultar(Turma turma, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// Método responsável por consultar todas as turmas do sistema.
        /// </summary>
        /// <returns>Lista contendo todas as turmas cadastradas.</returns>
        List<Turma> Consultar();
		
		/// <summary>
        /// Método responsável por confirmar as alterações no sistema.
        /// </summary>       
		void Confirmar();
    }
}