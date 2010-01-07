using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloCheque.Processos
{
    /// <summary>
    /// Summary description for IChequeRepositorio
    /// </summary>
    public interface IChequeProcesso
    {
        /// <summary>
        /// Método responsável por incluir um cheque no sistema.
        /// </summary>
        /// <param name="cheque">Objeto do tipo cheque a ser incluido.</param>
        void Incluir(Cheque cheque);

        /// <summary>
        /// Método responsável por excluir um cheque do sistema.
        /// </summary>
        /// <param name="cheque">Objeto do tipo cheque a ser excluido.</param>
        void Excluir(Cheque cheque);

        /// <summary>
        /// Método reponsável por alterar um cheque do sistema.
        /// </summary>
        /// <param name="cheque">Objeto do tipo cheque a ser alterado.</param>
        void Alterar(Cheque cheque);

        /// <summary>
        /// Método responsável por consultar perfis do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="cheque">Objeto do tipo cheque que irá ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todos os perfis cadastrados.</returns>
        List<Cheque> Consultar(Cheque cheque, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// Método responsável por consultar todos os comentários do sistema.
        /// </summary>
        /// <returns>Lista contendo todos os cheques cadastrados.</returns>
        List<Cheque> Consultar();

        /// <summary>
        /// Método responsável por confirmar as alterações no sistema.
        /// </summary>       
        void Confirmar();
    }
}