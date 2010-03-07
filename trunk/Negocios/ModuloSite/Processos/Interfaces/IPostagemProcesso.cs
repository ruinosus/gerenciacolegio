using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Negocios.ModuloBasico.Enums;
using Negocios.ModuloBasico.VOs;
using Negocios.ModuloSite.VOs;

namespace Negocios.ModuloSite.Processos
{
    public interface IPostagemProcesso
    {
        /// <summary>
        /// Método responsável por incluir um postagem no sistema.
        /// </summary>
        /// <param name="postagem">Objeto do tipo postagem a ser incluido.</param>
        void Incluir(Postagem postagem);

        /// <summary>
        /// Método responsável por excluir um postagem do sistema.
        /// </summary>
        /// <param name="postagem">Objeto do tipo postagem a ser excluido.</param>
        void Excluir(Postagem postagem);

        /// <summary>
        /// Método para verificar a existência de uma postagem já cadastrada
        /// </summary>
        /// <param name="postagem">postagem</param>
        /// <returns>verdadeiro caso exista repetido, falso caso não</returns>
        bool verificaSeJaExiste(Postagem postagem);

        /// <summary>
        /// Método reponsável por alterar um postagem do sistema.
        /// </summary>
        /// <param name="postagem">Objeto do tipo postagem a ser alterado.</param>
        void Alterar(Postagem postagem);

        /// <summary>
        /// Método responsável por consultar postagems do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="postagem">Objeto do tipo postagem que irá ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todos os postagems cadastrados.</returns>
        List<Postagem> Consultar(Postagem postagem, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// Método responsável por consultar todos os postagems do sistema.
        /// </summary>
        /// <returns>Lista contendo todos os postagems cadastrados.</returns>
        List<Postagem> Consultar();

        /// <summary>
        /// Método responsável por Consultar uma postagem 
        /// </summary>
        /// <param name="tipo">Tipo da postagem a ser pesquisada</param>
        /// <returns>Postagem encontrada com o local informado</returns>
        PostagemExibicao Consultar(TipoPagina tipo);

        /// <summary>
        /// Método responsável por confirmar as alterações no sistema.
        /// </summary>       
        void Confirmar();
    }
}