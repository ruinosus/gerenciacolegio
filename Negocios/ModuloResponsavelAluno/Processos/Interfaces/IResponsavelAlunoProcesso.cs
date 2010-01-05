using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;

namespace Negocios.ModuloResponsavelAluno.Processos
{
    /// <summary>
    ///  Interface IResponsavelAlunoProcesso
    /// </summary>
    public interface IResponsavelAlunoProcesso
    {
        /// <summary>
        /// M�todo respons�vel por incluir um Responsavel do Aluno no sistema.
        /// </summary>
        /// <param name="responsavelAluno">Objeto do tipo Responsavel do Aluno a ser incluido.</param>
        void Incluir(ResponsavelAluno responsavelAluno);

        /// <summary>
        /// M�todo respons�vel por excluir um Responsavel do Aluno do sistema.
        /// </summary>
        /// <param name="responsavelAluno">Objeto do tipo Responsavel do Aluno a ser excluido.</param>
        void Excluir(ResponsavelAluno responsavelAluno);

        /// <summary>
        /// M�todo repons�vel por alterar um Responsavel do Aluno do sistema.
        /// </summary>
        /// <param name="responsavelAluno">Objeto do tipo Responsavel do Aluno a ser alterado.</param>
        void Alterar(ResponsavelAluno responsavelAluno);

        /// <summary>
        /// M�todo respons�vel por consultar Responsaveis do Aluno do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="responsavelAluno">Objeto do tipo Responsavel do Aluno que ir� ser utilizado como parametro de pesquisa.</param>
        /// <returns>Lista contendo todos os Responsaveis do Aluno cadastrados.</returns>
        List<ResponsavelAluno> Consultar(ResponsavelAluno responsavelAluno);

        /// <summary>
        /// M�todo respons�vel por consultar todos os Responsaveis do Aluno do sistema.
        /// </summary>
        /// <returns>Lista contendo todos os Responsaveis do Aluno cadastrados.</returns>
        List<ResponsavelAluno> Consultar();
		
		/// <summary>
        /// M�todo respons�vel por confirmar as altera��es no sistema.
        /// </summary>       
		void Confirmar();
    }
}