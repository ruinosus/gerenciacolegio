using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloChequeBoletoMensalidade.Processos
{
    /// <summary>
    /// Interface IChequeBoletoMensalidadeRepositorio
    /// </summary>
    public interface IChequeBoletoMensalidadeProcesso
    {
        /// <summary>
        /// M�todo respons�vel por incluir uma chequeBoletoMensalidade no sistema.
        /// </summary>
        /// <param name="chequeBoletoMensalidade">Objeto do tipo chequeBoletoMensalidade a ser incluido.</param>
        void Incluir(ChequeBoletoMensalidade chequeBoletoMensalidade);

        /// <summary>
        /// M�todo respons�vel por excluir uma chequeBoletoMensalidade do sistema.
        /// </summary>
        /// <param name="chequeBoletoMensalidade">Objeto do tipo chequeBoletoMensalidade a ser excluido.</param>
        void Excluir(ChequeBoletoMensalidade chequeBoletoMensalidade);

        /// <summary>
        /// M�todo repons�vel por alterar uma chequeBoletoMensalidade do sistema.
        /// </summary>
        /// <param name="chequeBoletoMensalidade">Objeto do tipo chequeBoletoMensalidade a ser alterado.</param>
        void Alterar(ChequeBoletoMensalidade chequeBoletoMensalidade);

        /// <summary>
        /// M�todo respons�vel por consultar chequeBoletoMensalidades do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="chequeBoletoMensalidade">Objeto do tipo chequeBoletoMensalidade que ir� ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todas as chequeBoletoMensalidades cadastradas.</returns>
        List<ChequeBoletoMensalidade> Consultar(ChequeBoletoMensalidade chequeBoletoMensalidade, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// M�todo respons�vel por consultar todas as chequeBoletoMensalidades do sistema.
        /// </summary>
        /// <returns>Lista contendo todas as chequeBoletoMensalidades cadastradas.</returns>
        List<ChequeBoletoMensalidade> Consultar();

        /// <summary>
        /// M�todo respons�vel por confirmar as altera��es no sistema.
        /// </summary>       
        void Confirmar();
    }
}