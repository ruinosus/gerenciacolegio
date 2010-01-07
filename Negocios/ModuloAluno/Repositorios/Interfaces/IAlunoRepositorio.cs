using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloAluno.Repositorios
{
    /// <summary>
    /// Summary description for IAlunoRepositorio
    /// </summary>
    public interface IAlunoRepositorio
    {
        /// <summary>
        /// Método responsável por incluir um aluno no sistema.
        /// </summary>
        /// <param name="aluno">Objeto do tipo aluno a ser incluido.</param>
        void Incluir(Aluno aluno);

        /// <summary>
        /// Método responsável por excluir um aluno do sistema.
        /// </summary>
        /// <param name="aluno">Objeto do tipo aluno a ser excluido.</param>
        void Excluir(Aluno aluno);

        /// <summary>
        /// Método reponsável por alterar um aluno do sistema.
        /// </summary>
        /// <param name="aluno">Objeto do tipo aluno a ser alterado.</param>
        void Alterar(Aluno aluno);

        /// <summary>
        /// Método responsável por consultar perfis do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="aluno">Objeto do tipo aluno que irá ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todos os perfis cadastrados.</returns>
        List<Aluno> Consultar(Aluno aluno, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// Método responsável por consultar todos os comentários do sistema.
        /// </summary>
        /// <returns>Lista contendo todos os alunos cadastrados.</returns>
        List<Aluno> Consultar();
		
		/// <summary>
        /// Método responsável por confirmar as alterações no sistema.
        /// </summary>       
		void Confirmar();
    }
}