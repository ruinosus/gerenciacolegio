using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Negocios.ModuloAtividade.Repositorios
{
    /// <summary>
    /// Interface IAtividadeRepositorio
    /// </summary>
    public interface IAtividadeRepositorio
    {
        /// <summary>
        /// Método responsável por incluir uma atividade no sistema.
        /// </summary>
        /// <param name="turma">Objeto do tipo atividade a ser incluido.</param>
        void Incluir(Atividade atividade);

        /// <summary>
        /// Método responsável por excluir uma atividade do sistema.
        /// </summary>
        /// <param name="turma">Objeto do tipo atividade a ser excluido.</param>
        void Excluir(Atividade atividade);

        /// <summary>
        /// Método reponsável por alterar uma atividade do sistema.
        /// </summary>
        /// <param name="turma">Objeto do tipo atividade a ser alterado.</param>
        void Alterar(Atividade atividade);

        /// <summary>
        /// Método responsável por consultar atividades do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="turma">Objeto do tipo turma que irá ser utilizado como parametro de pesquisa.</param>
        /// <returns>Lista contendo todas as atividades cadastradas.</returns>
        List<Atividade> Consultar(Atividade atividade);

        /// <summary>
        /// Método responsável por consultar todas as atividades do sistema.
        /// </summary>
        /// <returns>Lista contendo todas as atividades cadastradas.</returns>
        List<Atividade> Consultar();
		
		/// <summary>
        /// Método responsável por confirmar as alterações no sistema.
        /// </summary>       
		void Confirmar();
    }
}