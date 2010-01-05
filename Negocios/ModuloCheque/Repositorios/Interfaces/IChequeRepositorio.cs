using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;

namespace Negocios.ModuloCheque.Repositorios
{
    /// <summary>
    /// Summary description for IChequeRepositorio
    /// </summary>
    public interface IChequeRepositorio
    {
        /// <summary>
        /// M�todo respons�vel por incluir um cheque no sistema.
        /// </summary>
        /// <param name="cheque">Objeto do tipo cheque a ser incluido.</param>
        void Incluir(Cheque cheque);

        /// <summary>
        /// M�todo respons�vel por excluir um cheque do sistema.
        /// </summary>
        /// <param name="cheque">Objeto do tipo cheque a ser excluido.</param>
        void Excluir(Cheque cheque);

        /// <summary>
        /// M�todo repons�vel por alterar um cheque do sistema.
        /// </summary>
        /// <param name="cheque">Objeto do tipo cheque a ser alterado.</param>
        void Alterar(Cheque cheque);

        /// <summary>
        /// M�todo respons�vel por consultar perfis do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="cheque">Objeto do tipo cheque que ir� ser utilizado como parametro de pesquisa.</param>
        /// <returns>Lista contendo todos os perfis cadastrados.</returns>
        List<Cheque> Consultar(Cheque cheque);

        /// <summary>
        /// M�todo respons�vel por consultar todos os coment�rios do sistema.
        /// </summary>
        /// <returns>Lista contendo todos os cheques cadastrados.</returns>
        List<Cheque> Consultar();
		
		/// <summary>
        /// M�todo respons�vel por confirmar as altera��es no sistema.
        /// </summary>       
		void Confirmar();
    }
}