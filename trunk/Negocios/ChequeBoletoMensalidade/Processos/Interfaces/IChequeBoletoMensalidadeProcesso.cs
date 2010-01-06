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
        /// Método responsável por incluir uma chequeBoletoMensalidade no sistema.
        /// </summary>
        /// <param name="chequeBoletoMensalidade">Objeto do tipo chequeBoletoMensalidade a ser incluido.</param>
        void Incluir(ChequeBoletoMensalidade chequeBoletoMensalidade);

        /// <summary>
        /// Método responsável por excluir uma chequeBoletoMensalidade do sistema.
        /// </summary>
        /// <param name="chequeBoletoMensalidade">Objeto do tipo chequeBoletoMensalidade a ser excluido.</param>
        void Excluir(ChequeBoletoMensalidade chequeBoletoMensalidade);

        /// <summary>
        /// Método reponsável por alterar uma chequeBoletoMensalidade do sistema.
        /// </summary>
        /// <param name="chequeBoletoMensalidade">Objeto do tipo chequeBoletoMensalidade a ser alterado.</param>
        void Alterar(ChequeBoletoMensalidade chequeBoletoMensalidade);

        /// <summary>
        /// Método responsável por consultar chequeBoletoMensalidades do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="chequeBoletoMensalidade">Objeto do tipo chequeBoletoMensalidade que irá ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todas as chequeBoletoMensalidades cadastradas.</returns>
        List<ChequeBoletoMensalidade> Consultar(ChequeBoletoMensalidade chequeBoletoMensalidade, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// Método responsável por consultar todas as chequeBoletoMensalidades do sistema.
        /// </summary>
        /// <returns>Lista contendo todas as chequeBoletoMensalidades cadastradas.</returns>
        List<ChequeBoletoMensalidade> Consultar();

        /// <summary>
        /// Método responsável por confirmar as alterações no sistema.
        /// </summary>       
        void Confirmar();
    }
}