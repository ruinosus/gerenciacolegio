using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Negocios.ModuloAlunoAtividade.Repositorios
{
    /// <summary>
    /// Summary description for IAlunoAtividadeRepositorio
    /// </summary>
    public interface IAlunoAtividadeRepositorio
    {
        /// <summary>
        /// M�todo respons�vel por incluir um alunoAtividade no sistema.
        /// </summary>
        /// <param name="alunoAtividade">Objeto do tipo alunoAtividade a ser incluido.</param>
        void Incluir(AlunoAtividade alunoAtividade);

        /// <summary>
        /// M�todo respons�vel por excluir um alunoAtividade do sistema.
        /// </summary>
        /// <param name="alunoAtividade">Objeto do tipo alunoAtividade a ser excluido.</param>
        void Excluir(AlunoAtividade alunoAtividade);

        /// <summary>
        /// M�todo repons�vel por alterar um alunoAtividade do sistema.
        /// </summary>
        /// <param name="alunoAtividade">Objeto do tipo alunoAtividade a ser alterado.</param>
        void Alterar(AlunoAtividade alunoAtividade);

        /// <summary>
        /// M�todo respons�vel por consultar perfis do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="alunoAtividade">Objeto do tipo alunoAtividade que ir� ser utilizado como parametro de pesquisa.</param>
        /// <returns>Lista contendo todos os perfis cadastrados.</returns>
        List<AlunoAtividade> Consultar(AlunoAtividade alunoAtividade);

        /// <summary>
        /// M�todo respons�vel por consultar todos os coment�rios do sistema.
        /// </summary>
        /// <returns>Lista contendo todos os alunoAtividades cadastrados.</returns>
        List<AlunoAtividade> Consultar();
		
		/// <summary>
        /// M�todo respons�vel por confirmar as altera��es no sistema.
        /// </summary>       
		void Confirmar();
    }
}