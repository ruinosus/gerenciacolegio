using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloChequeBoletoAtividade.Repositorios
{
    /// <summary>
    /// Interface IChequeBoletoAtividadeRepositorio
    /// </summary>
    public interface IChequeBoletoAtividadeRepositorio
    {
        /// <summary>
        /// M�todo respons�vel por incluir uma chequeBoletoAtividade no sistema.
        /// </summary>
        /// <param name="chequeBoletoAtividade">Objeto do tipo chequeBoletoAtividade a ser incluido.</param>
        void Incluir(ChequeBoletoAtividade chequeBoletoAtividade);

        /// <summary>
        /// M�todo respons�vel por excluir uma chequeBoletoAtividade do sistema.
        /// </summary>
        /// <param name="chequeBoletoAtividade">Objeto do tipo chequeBoletoAtividade a ser excluido.</param>
        void Excluir(ChequeBoletoAtividade chequeBoletoAtividade);

        /// <summary>
        /// M�todo repons�vel por alterar uma chequeBoletoAtividade do sistema.
        /// </summary>
        /// <param name="chequeBoletoAtividade">Objeto do tipo chequeBoletoAtividade a ser alterado.</param>
        void Alterar(ChequeBoletoAtividade chequeBoletoAtividade);

        /// <summary>
        /// M�todo respons�vel por consultar chequeBoletoAtividades do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="chequeBoletoAtividade">Objeto do tipo chequeBoletoAtividade que ir� ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todas as chequeBoletoAtividades cadastradas.</returns>
        List<ChequeBoletoAtividade> Consultar(ChequeBoletoAtividade chequeBoletoAtividade, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// M�todo respons�vel por consultar todas as chequeBoletoAtividades do sistema.
        /// </summary>
        /// <returns>Lista contendo todas as chequeBoletoAtividades cadastradas.</returns>
        List<ChequeBoletoAtividade> Consultar();
		
		/// <summary>
        /// M�todo respons�vel por confirmar as altera��es no sistema.
        /// </summary>       
		void Confirmar();
    }
}