using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Negocios.ModuloSalaPeriodo.Repositorios
{
    /// <summary>
    /// Interface ISalaPeriodoRepositorio
    /// </summary>
    public interface ISalaPeriodoRepositorio
    {
        /// <summary>
        /// Método responsável por incluir uma salaPeriodo no sistema.
        /// </summary>
        /// <param name="turma">Objeto do tipo salaPeriodo a ser incluido.</param>
        void Incluir(SalaPeriodo salaPeriodo);

        /// <summary>
        /// Método responsável por excluir uma salaPeriodo do sistema.
        /// </summary>
        /// <param name="turma">Objeto do tipo salaPeriodo a ser excluido.</param>
        void Excluir(SalaPeriodo salaPeriodo);

        /// <summary>
        /// Método reponsável por alterar uma salaPeriodo do sistema.
        /// </summary>
        /// <param name="turma">Objeto do tipo salaPeriodo a ser alterado.</param>
        void Alterar(SalaPeriodo salaPeriodo);

        /// <summary>
        /// Método responsável por consultar salaPeriodos do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="turma">Objeto do tipo turma que irá ser utilizado como parametro de pesquisa.</param>
        /// <returns>Lista contendo todas as salaPeriodos cadastradas.</returns>
        List<SalaPeriodo> Consultar(SalaPeriodo salaPeriodo);

        /// <summary>
        /// Método responsável por consultar todas as salaPeriodos do sistema.
        /// </summary>
        /// <returns>Lista contendo todas as salaPeriodos cadastradas.</returns>
        List<SalaPeriodo> Consultar();
		
		/// <summary>
        /// Método responsável por confirmar as alterações no sistema.
        /// </summary>       
		void Confirmar();
    }
}