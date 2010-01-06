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
        /// M�todo respons�vel por incluir uma contasAPagar no sistema.
        /// </summary>
        /// <param name="contasAPagar">Objeto do tipo contasAPagar a ser incluido.</param>
        void Incluir(ContasAPagar contasAPagar);

        /// <summary>
        /// M�todo respons�vel por excluir uma contasAPagar do sistema.
        /// </summary>
        /// <param name="contasAPagar">Objeto do tipo contasAPagar a ser excluido.</param>
        void Excluir(ContasAPagar contasAPagar);

        /// <summary>
        /// M�todo repons�vel por alterar uma contasAPagar do sistema.
        /// </summary>
        /// <param name="contasAPagar">Objeto do tipo contasAPagar a ser alterado.</param>
        void Alterar(ContasAPagar contasAPagar);

        /// <summary>
        /// M�todo respons�vel por consultar contasAPagars do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="contasAPagar">Objeto do tipo turma que ir� ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todas as contasAPagars cadastradas.</returns>
        List<ContasAPagar> Consultar(ContasAPagar contasAPagar, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// M�todo respons�vel por consultar todas as contasAPagars do sistema.
        /// </summary>
        /// <returns>Lista contendo todas as contasAPagars cadastradas.</returns>
        List<ContasAPagar> Consultar();

        /// <summary>
        /// M�todo respons�vel por confirmar as altera��es no sistema.
        /// </summary>       
        void Confirmar();
    }
}