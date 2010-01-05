using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Negocios.ModuloBoletoAtividade.Repositorios
{
    /// <summary>
    /// Interface IBoletoAtividadeRepositorio
    /// </summary>
    public interface IBoletoAtividadeRepositorio
    {
        /// <summary>
        /// Método responsável por incluir uma boletoAtividade no sistema.
        /// </summary>
        /// <param name="turma">Objeto do tipo boletoAtividade a ser incluido.</param>
        void Incluir(BoletoAtividade boletoAtividade);

        /// <summary>
        /// Método responsável por excluir uma boletoAtividade do sistema.
        /// </summary>
        /// <param name="turma">Objeto do tipo boletoAtividade a ser excluido.</param>
        void Excluir(BoletoAtividade boletoAtividade);

        /// <summary>
        /// Método reponsável por alterar uma boletoAtividade do sistema.
        /// </summary>
        /// <param name="turma">Objeto do tipo boletoAtividade a ser alterado.</param>
        void Alterar(BoletoAtividade boletoAtividade);

        /// <summary>
        /// Método responsável por consultar boletoAtividades do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="turma">Objeto do tipo turma que irá ser utilizado como parametro de pesquisa.</param>
        /// <returns>Lista contendo todas as boletoAtividades cadastradas.</returns>
        List<BoletoAtividade> Consultar(BoletoAtividade boletoAtividade);

        /// <summary>
        /// Método responsável por consultar todas as boletoAtividades do sistema.
        /// </summary>
        /// <returns>Lista contendo todas as boletoAtividades cadastradas.</returns>
        List<BoletoAtividade> Consultar();
		
		/// <summary>
        /// Método responsável por confirmar as alterações no sistema.
        /// </summary>       
		void Confirmar();
    }
}