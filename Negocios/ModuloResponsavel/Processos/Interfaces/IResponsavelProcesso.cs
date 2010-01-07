using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloResponsavel.Processos
{
    /// <summary>
    /// Summary description for IResponsavelRepositorio
    /// </summary>
    public interface IResponsavelProcesso
    {
        /// <summary>
        /// M�todo respons�vel por incluir um responsavel no sistema.
        /// </summary>
        /// <param name="responsavel">Objeto do tipo responsavel a ser incluido.</param>
        void Incluir(Responsavel responsavel);

        /// <summary>
        /// M�todo respons�vel por excluir um responsavel do sistema.
        /// </summary>
        /// <param name="responsavel">Objeto do tipo responsavel a ser excluido.</param>
        void Excluir(Responsavel responsavel);

        /// <summary>
        /// M�todo repons�vel por alterar um responsavel do sistema.
        /// </summary>
        /// <param name="responsavel">Objeto do tipo responsavel a ser alterado.</param>
        void Alterar(Responsavel responsavel);

        /// <summary>
        /// M�todo respons�vel por consultar perfis do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="responsavel">Objeto do tipo responsavel que ir� ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todos os perfis cadastrados.</returns>
        List<Responsavel> Consultar(Responsavel responsavel, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// M�todo respons�vel por consultar todos os coment�rios do sistema.
        /// </summary>
        /// <returns>Lista contendo todos os responsavels cadastrados.</returns>
        List<Responsavel> Consultar();

        /// <summary>
        /// M�todo respons�vel por confirmar as altera��es no sistema.
        /// </summary>       
        void Confirmar();
    }
}