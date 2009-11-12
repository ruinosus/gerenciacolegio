using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloComentario.VOs;
using Negocios.ModuloComentario.Filtro;

namespace Negocios.ModuloComentario.Processos
{
    /// <summary>
    /// Summary description for IPostagemRepositorio
    /// </summary>
    public interface IComentarioProcesso
    {
        /// <summary>
        /// Método responsável por incluir um comentario no sistema.
        /// </summary>
        /// <param name="comentario">Objeto do tipo comentario a ser incluido.</param>
        void Incluir(ComentarioVO comentario);

        /// <summary>
        /// Método responsável por excluir um comentario do sistema.
        /// </summary>
        /// <param name="comentario">Objeto do tipo comentario a ser excluido.</param>
        void Excluir(ComentarioVO comentario);

        /// <summary>
        /// Método reponsável por alterar um comentário do sistema.
        /// </summary>
        /// <param name="comentario">Objeto do tipo comentario a ser alterado.</param>
        void Alterar(ComentarioVO comentario);

        /// <summary>
        /// Método responsável por consultar comentários do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="comentario">Objeto do tipo comentario que irá ser utilizado como parametro de pesquisa.</param>
        /// <param name="comentarioFiltroConsulta">Filtro contendo os campos necessários para retorno.</param>
        /// <param name="lazy"></param>
        /// <returns>Lista contendo todos os comentarios cadastrados.</returns>
        List<ComentarioVO> Consultar(ComentarioVO comentario, ComentarioFiltroConsulta comentarioFiltroConsulta, bool lazy);

        /// <summary>
        /// Método responsável por consultar todos os comentários do sistema.
        /// </summary>
        /// <param name="comentarioFiltroConsulta">Filtro contendo os campos necessários para retorno.</param>
        /// <param name="lazy"></param>
        /// <returns>Lista contendo todos os comentarios cadastrados.</returns>
        List<ComentarioVO> Consultar(ComentarioFiltroConsulta comentarioFiltroConsulta, bool lazy);
    }
}