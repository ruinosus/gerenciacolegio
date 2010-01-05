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
        /// Método responsável por incluir um alunoAtividade no sistema.
        /// </summary>
        /// <param name="alunoAtividade">Objeto do tipo alunoAtividade a ser incluido.</param>
        void Incluir(AlunoAtividade alunoAtividade);

        /// <summary>
        /// Método responsável por excluir um alunoAtividade do sistema.
        /// </summary>
        /// <param name="alunoAtividade">Objeto do tipo alunoAtividade a ser excluido.</param>
        void Excluir(AlunoAtividade alunoAtividade);

        /// <summary>
        /// Método reponsável por alterar um alunoAtividade do sistema.
        /// </summary>
        /// <param name="alunoAtividade">Objeto do tipo alunoAtividade a ser alterado.</param>
        void Alterar(AlunoAtividade alunoAtividade);

        /// <summary>
        /// Método responsável por consultar perfis do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="alunoAtividade">Objeto do tipo alunoAtividade que irá ser utilizado como parametro de pesquisa.</param>
        /// <returns>Lista contendo todos os perfis cadastrados.</returns>
        List<AlunoAtividade> Consultar(AlunoAtividade alunoAtividade);

        /// <summary>
        /// Método responsável por consultar todos os comentários do sistema.
        /// </summary>
        /// <returns>Lista contendo todos os alunoAtividades cadastrados.</returns>
        List<AlunoAtividade> Consultar();
		
		/// <summary>
        /// Método responsável por confirmar as alterações no sistema.
        /// </summary>       
		void Confirmar();
    }
}