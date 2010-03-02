using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Negocios.ModuloBasico.Enums;
using Negocios.ModuloBasico.VOs;

namespace Negocios.ModuloSite.Processos
{
    public interface IPostagemProcesso
    {
        /// <summary>
        /// M�todo respons�vel por incluir um postagem no sistema.
        /// </summary>
        /// <param name="postagem">Objeto do tipo postagem a ser incluido.</param>
        void Incluir(Postagem postagem);

        /// <summary>
        /// M�todo respons�vel por excluir um postagem do sistema.
        /// </summary>
        /// <param name="postagem">Objeto do tipo postagem a ser excluido.</param>
        void Excluir(Postagem postagem);

        /// <summary>
        /// M�todo repons�vel por alterar um postagem do sistema.
        /// </summary>
        /// <param name="postagem">Objeto do tipo postagem a ser alterado.</param>
        void Alterar(Postagem postagem);

        /// <summary>
        /// M�todo respons�vel por consultar postagems do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="postagem">Objeto do tipo postagem que ir� ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todos os postagems cadastrados.</returns>
        List<Postagem> Consultar(Postagem postagem, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// M�todo respons�vel por consultar todos os postagems do sistema.
        /// </summary>
        /// <returns>Lista contendo todos os postagems cadastrados.</returns>
        List<Postagem> Consultar();

        /// <summary>
        /// M�todo respons�vel por confirmar as altera��es no sistema.
        /// </summary>       
        void Confirmar();
    }
}