using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloBoletoMensalidade.Repositorios
{
    /// <summary>
    /// Interface IBoletoMensalidadeRepositorio
    /// </summary>
    public interface IBoletoMensalidadeRepositorio
    {
        /// <summary>
        /// Método responsável por incluir uma boletoMensalidade no sistema.
        /// </summary>
        /// <param name="boletoMensalidade">Objeto do tipo boletoMensalidade a ser incluido.</param>
        void Incluir(BoletoMensalidade boletoMensalidade);

        /// <summary>
        /// Método responsável por excluir uma boletoMensalidade do sistema.
        /// </summary>
        /// <param name="boletoMensalidade">Objeto do tipo boletoMensalidade a ser excluido.</param>
        void Excluir(BoletoMensalidade boletoMensalidade);

        /// <summary>
        /// Método reponsável por alterar uma boletoMensalidade do sistema.
        /// </summary>
        /// <param name="boletoMensalidade">Objeto do tipo boletoMensalidade a ser alterado.</param>
        void Alterar(BoletoMensalidade boletoMensalidade);

        /// <summary>
        /// Método responsável por consultar boletoMensalidades do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="boletoMensalidade">Objeto do tipo boletoMensalidade que irá ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todas as boletoMensalidades cadastradas.</returns>
        List<BoletoMensalidade> Consultar(BoletoMensalidade boletoMensalidade, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// Método responsável por consultar todas as boletoMensalidades do sistema.
        /// </summary>
        /// <returns>Lista contendo todas as boletoMensalidades cadastradas.</returns>
        List<BoletoMensalidade> Consultar();
		
		/// <summary>
        /// Método responsável por confirmar as alterações no sistema.
        /// </summary>       
		void Confirmar();
    }
}