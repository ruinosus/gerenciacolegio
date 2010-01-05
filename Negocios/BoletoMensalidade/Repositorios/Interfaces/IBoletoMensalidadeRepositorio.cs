using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Negocios.ModuloBoletoMensalidade.Repositorios
{
    /// <summary>
    /// Interface IBoletoMensalidadeRepositorio
    /// </summary>
    public interface IBoletoMensalidadeRepositorio
    {
        /// <summary>
        /// M�todo respons�vel por incluir uma boletoMensalidade no sistema.
        /// </summary>
        /// <param name="turma">Objeto do tipo boletoMensalidade a ser incluido.</param>
        void Incluir(BoletoMensalidade boletoMensalidade);

        /// <summary>
        /// M�todo respons�vel por excluir uma boletoMensalidade do sistema.
        /// </summary>
        /// <param name="turma">Objeto do tipo boletoMensalidade a ser excluido.</param>
        void Excluir(BoletoMensalidade boletoMensalidade);

        /// <summary>
        /// M�todo repons�vel por alterar uma boletoMensalidade do sistema.
        /// </summary>
        /// <param name="turma">Objeto do tipo boletoMensalidade a ser alterado.</param>
        void Alterar(BoletoMensalidade boletoMensalidade);

        /// <summary>
        /// M�todo respons�vel por consultar boletoMensalidades do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="turma">Objeto do tipo turma que ir� ser utilizado como parametro de pesquisa.</param>
        /// <returns>Lista contendo todas as boletoMensalidades cadastradas.</returns>
        List<BoletoMensalidade> Consultar(BoletoMensalidade boletoMensalidade);

        /// <summary>
        /// M�todo respons�vel por consultar todas as boletoMensalidades do sistema.
        /// </summary>
        /// <returns>Lista contendo todas as boletoMensalidades cadastradas.</returns>
        List<BoletoMensalidade> Consultar();
		
		/// <summary>
        /// M�todo respons�vel por confirmar as altera��es no sistema.
        /// </summary>       
		void Confirmar();
    }
}