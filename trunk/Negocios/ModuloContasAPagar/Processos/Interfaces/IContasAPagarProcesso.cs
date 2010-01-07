using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloContasAPagar.Processos
{
    /// <summary>
    /// Interface IContasAPagarRepositorio
    /// </summary>
    public interface IContasAPagarProcesso
    {
        /// <summary>
        /// Método responsável por incluir uma contasAPagar no sistema.
        /// </summary>
        /// <param name="contasAPagar">Objeto do tipo contasAPagar a ser incluido.</param>
        void Incluir(ContasAPagar contasAPagar);

        /// <summary>
        /// Método responsável por excluir uma contasAPagar do sistema.
        /// </summary>
        /// <param name="contasAPagar">Objeto do tipo contasAPagar a ser excluido.</param>
        void Excluir(ContasAPagar contasAPagar);

        /// <summary>
        /// Método reponsável por alterar uma contasAPagar do sistema.
        /// </summary>
        /// <param name="contasAPagar">Objeto do tipo contasAPagar a ser alterado.</param>
        void Alterar(ContasAPagar contasAPagar);

        /// <summary>
        /// Método responsável por consultar contasAPagars do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="contasAPagar">Objeto do tipo turma que irá ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todas as contasAPagars cadastradas.</returns>
        List<ContasAPagar> Consultar(ContasAPagar contasAPagar, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// Método responsável por consultar todas as contasAPagars do sistema.
        /// </summary>
        /// <returns>Lista contendo todas as contasAPagars cadastradas.</returns>
        List<ContasAPagar> Consultar();

        /// <summary>
        /// Método responsável por confirmar as alterações no sistema.
        /// </summary>       
        void Confirmar();
    }
}