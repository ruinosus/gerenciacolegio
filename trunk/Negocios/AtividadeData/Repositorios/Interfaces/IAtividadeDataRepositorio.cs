using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Negocios.ModuloAtividadeData.Repositorios
{
    /// <summary>
    /// Interface IAtividadeDataRepositorio
    /// </summary>
    public interface IAtividadeDataRepositorio
    {
        /// <summary>
        /// Método responsável por incluir uma atividadeData no sistema.
        /// </summary>
        /// <param name="turma">Objeto do tipo atividadeData a ser incluido.</param>
        void Incluir(AtividadeData atividadeData);

        /// <summary>
        /// Método responsável por excluir uma atividadeData do sistema.
        /// </summary>
        /// <param name="turma">Objeto do tipo atividadeData a ser excluido.</param>
        void Excluir(AtividadeData atividadeData);

        /// <summary>
        /// Método reponsável por alterar uma atividadeData do sistema.
        /// </summary>
        /// <param name="turma">Objeto do tipo atividadeData a ser alterado.</param>
        void Alterar(AtividadeData atividadeData);

        /// <summary>
        /// Método responsável por consultar atividadeDatas do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="turma">Objeto do tipo turma que irá ser utilizado como parametro de pesquisa.</param>
        /// <returns>Lista contendo todas as atividadeDatas cadastradas.</returns>
        List<AtividadeData> Consultar(AtividadeData atividadeData);

        /// <summary>
        /// Método responsável por consultar todas as atividadeDatas do sistema.
        /// </summary>
        /// <returns>Lista contendo todas as atividadeDatas cadastradas.</returns>
        List<AtividadeData> Consultar();
		
		/// <summary>
        /// Método responsável por confirmar as alterações no sistema.
        /// </summary>       
		void Confirmar();
    }
}