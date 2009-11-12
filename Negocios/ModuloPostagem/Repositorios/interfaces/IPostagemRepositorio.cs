using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloPostagem.VOs;
using Negocios.ModuloPostagem.Filtros;


namespace Negocios.ModuloPostagem.Repositorios
{
    /// <summary>
    /// Summary description for IPostagemRepositorio
    /// </summary>
    public interface IPostagemRepositorio
    {
        /// <summary>
        /// Método responsável por incluir uma postagem no sistema.
        /// </summary>
        /// <param name="postagemVO">Objeto do tipo postagem a ser incluido.</param>
        void Incluir(PostagemVO postagemVO);

        /// <summary>
        /// Método responsável por excluir uma postagem do sistema.
        /// </summary>
        /// <param name="postagemVO">Objeto do tipo postagem a ser excluido.</param>
        void Excluir(PostagemVO postagemVO);

        /// <summary>
        /// Método reponsável por alterar uma postagem do sistema.
        /// </summary>
        /// <param name="postagemVO">Objeto do tipo postagem a ser alterado.</param>
        void Alterar(PostagemVO postagemVO);

        /// <summary>
        /// Método responsável por consultar postagens do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="postagemVO">Objeto do tipo postagem que irá ser utilizado como parametro de pesquisa.</param>
        /// <param name="postagemFiltroConsulta">Filtro contendo os campos necessários para retorno.</param>
        /// <param name="lazy"></param>
        /// <returns>Lista contendo todas as postagens econtradas.</returns>
        List<PostagemVO> Consultar(PostagemVO postagemVO, PostagemFiltroConsulta postagemFiltroConsulta, bool lazy);

        /// <summary>
        /// Método responsável por consultar todas as postagens do sistema.
        /// </summary>
        /// <param name="postagemFiltroConsulta">Filtro contendo os campos necessários para retorno.</param>
        /// <param name="lazy"></param>
        /// <returns>Lista contendo todas as postagem cadastrados.</returns>
        List<PostagemVO> Consultar(PostagemFiltroConsulta postagemFiltroConsulta, bool lazy);
    }
}