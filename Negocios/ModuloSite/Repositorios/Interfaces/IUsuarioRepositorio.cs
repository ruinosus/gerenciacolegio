using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Negocios.ModuloBasico.Enums;
using Negocios.ModuloBasico.VOs;

namespace Negocios.ModuloSite.Repositorios
{
    public interface IUsuarioRepositorio
    {
        /// <summary>
        /// M�todo respons�vel por incluir um usuario no sistema.
        /// </summary>
        /// <param name="usuario">Objeto do tipo usuario a ser incluido.</param>
        void Incluir(Usuario usuario);

        /// <summary>
        /// M�todo respons�vel por excluir um usuario do sistema.
        /// </summary>
        /// <param name="usuario">Objeto do tipo usuario a ser excluido.</param>
        void Excluir(Usuario usuario);

        /// <summary>
        /// M�todo repons�vel por alterar um usuario do sistema.
        /// </summary>
        /// <param name="usuario">Objeto do tipo usuario a ser alterado.</param>
        void Alterar(Usuario usuario);

        /// <summary>
        /// M�todo respons�vel por consultar usuarios do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="usuario">Objeto do tipo usuario que ir� ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todos os usuarios cadastrados.</returns>
        List<Usuario> Consultar(Usuario usuario, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// M�todo respons�vel por consultar todos os usuarios do sistema.
        /// </summary>
        /// <returns>Lista contendo todos os usuarios cadastrados.</returns>
        List<Usuario> Consultar();

        /// <summary>
        /// M�todo respons�vel por confirmar as altera��es no sistema.
        /// </summary>       
        void Confirmar();
    }
}