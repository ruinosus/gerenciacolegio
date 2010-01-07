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
        /// Método responsável por incluir uma chequeBoletoAtividade no sistema.
        /// </summary>
        /// <param name="chequeBoletoAtividade">Objeto do tipo chequeBoletoAtividade a ser incluido.</param>
        void Incluir(ChequeBoletoAtividade chequeBoletoAtividade);

        /// <summary>
        /// Método responsável por excluir uma chequeBoletoAtividade do sistema.
        /// </summary>
        /// <param name="chequeBoletoAtividade">Objeto do tipo chequeBoletoAtividade a ser excluido.</param>
        void Excluir(ChequeBoletoAtividade chequeBoletoAtividade);

        /// <summary>
        /// Método reponsável por alterar uma chequeBoletoAtividade do sistema.
        /// </summary>
        /// <param name="chequeBoletoAtividade">Objeto do tipo chequeBoletoAtividade a ser alterado.</param>
        void Alterar(ChequeBoletoAtividade chequeBoletoAtividade);

        /// <summary>
        /// Método responsável por consultar chequeBoletoAtividades do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="chequeBoletoAtividade">Objeto do tipo chequeBoletoAtividade que irá ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todas as chequeBoletoAtividades cadastradas.</returns>
        List<ChequeBoletoAtividade> Consultar(ChequeBoletoAtividade chequeBoletoAtividade, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// Método responsável por consultar todas as chequeBoletoAtividades do sistema.
        /// </summary>
        /// <returns>Lista contendo todas as chequeBoletoAtividades cadastradas.</returns>
        List<ChequeBoletoAtividade> Consultar();
		
		/// <summary>
        /// Método responsável por confirmar as alterações no sistema.
        /// </summary>       
		void Confirmar();
    }
}