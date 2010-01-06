using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloResponsavelAluno.Repositorios
{
    /// <summary>
    /// Summary description for IResponsavelAlunoRepositorio
    /// </summary>
    public interface IResponsavelAlunoRepositorio
    {
        /// <summary>
        /// Método responsável por incluir um Responsavel do Aluno no sistema.
        /// </summary>
        /// <param name="responsavelAluno">Objeto do tipo ResponsavelAluno a ser incluido.</param>
        void Incluir(ResponsavelAluno responsavelAluno);

        /// <summary>
        /// Método responsável por excluir um Responsavel do Aluno do sistema.
        /// </summary>
        /// <param name="responsavelAluno">Objeto do tipo ResponsavelAluno a ser excluido.</param>
        void Excluir(ResponsavelAluno responsavelAluno);

        /// <summary>
        /// Método reponsável por alterar um Responsavel do Aluno do sistema.
        /// </summary>
        /// <param name="responsavelAluno">Objeto do tipo ResponsavelAluno a ser alterado.</param>
        void Alterar(ResponsavelAluno responsavelAluno);

        /// <summary>
        /// Método responsável por consultar Responsaveis do Aluno do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="responsavelAluno">Objeto do tipo responsavelAluno que irá ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todos os Responsaveis do Aluno cadastrados.</returns>
        List<ResponsavelAluno> Consultar(ResponsavelAluno responsavelAluno, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// Método responsável por consultar todos os Responsaveis do Aluno do sistema.
        /// </summary>
        /// <returns>Lista contendo todos os Responsaveis do Aluno cadastrados.</returns>
        List<ResponsavelAluno> Consultar();
		
		/// <summary>
        /// Método responsável por confirmar as alterações no sistema.
        /// </summary>       
		void Confirmar();
    }
}