using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloBoletoAtividade.Repositorios
{
    /// <summary>
    /// Interface IBoletoAtividadeRepositorio
    /// </summary>
    public interface IBoletoAtividadeRepositorio
    {
        /// <summary>
        /// M�todo respons�vel por incluir uma boletoAtividade no sistema.
        /// </summary>
        /// <param name="boletoAtividade">Objeto do tipo boletoAtividade a ser incluido.</param>
        void Incluir(BoletoAtividade boletoAtividade);

        /// <summary>
        /// M�todo respons�vel por excluir uma boletoAtividade do sistema.
        /// </summary>
        /// <param name="boletoAtividade">Objeto do tipo boletoAtividade a ser excluido.</param>
        void Excluir(BoletoAtividade boletoAtividade);

        /// <summary>
        /// M�todo repons�vel por alterar uma boletoAtividade do sistema.
        /// </summary>
        /// <param name="boletoAtividade">Objeto do tipo boletoAtividade a ser alterado.</param>
        void Alterar(BoletoAtividade boletoAtividade);

        /// <summary>
        /// M�todo respons�vel por consultar boletoAtividades do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="boletoAtividade">Objeto do tipo boletoAtividade que ir� ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todas as boletoAtividades cadastradas.</returns>
        List<BoletoAtividade> Consultar(BoletoAtividade boletoAtividade, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// M�todo respons�vel por consultar todas as boletoAtividades do sistema.
        /// </summary>
        /// <returns>Lista contendo todas as boletoAtividades cadastradas.</returns>
        List<BoletoAtividade> Consultar();
		
		/// <summary>
        /// M�todo respons�vel por confirmar as altera��es no sistema.
        /// </summary>       
		void Confirmar();
    }
}