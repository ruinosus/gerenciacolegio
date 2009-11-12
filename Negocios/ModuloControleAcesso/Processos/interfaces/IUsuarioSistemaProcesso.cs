using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Collections.Generic;
using Negocios.ModuloControleAcesso.Filtros;
using Negocios.ModuloControleAcesso.VOs;

namespace Negocios.ModuloControleAcesso.Processos
{
    /// <summary>
    /// Summary description for IUsuarioSistemaProcesso
    /// </summary>
    public interface IUsuarioSistemaProcesso
    {
        /// <summary>
        /// Método responsável por incluir um usuário no sistema.
        /// </summary>
        /// <param name="usuarioSistemaVO">Objeto do tipo usuário a ser incluido.</param>
        void Incluir(UsuarioSistemaVO usuarioSistemaVO);

        /// <summary>
        /// Método responsável por excluir um usuário do sistema.
        /// </summary>
        /// <param name="usuarioSistemaVO">Objeto do tipo usuário a ser excluido.</param>
        void Excluir(UsuarioSistemaVO usuarioSistemaVO);

        /// <summary>
        /// Método reponsável por alterar um usuario do sistema.
        /// </summary>
        /// <param name="usuarioSistemaVO">Objeto do tipo usuário a ser alterado.</param>
        void Alterar(UsuarioSistemaVO usuarioSistemaVO);

        /// <summary>
        /// Método responsável por consultar usuários do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="usuarioSistemaVO">Objeto do tipo usuario que irá ser utilizado como parametro de pesquisa.</param>
        /// <param name="usuarioSistemaFiltroConsulta">Filtro contendo os campos necessários para retorno.</param>
        /// <param name="lazy"></param>
        /// <returns>Lista contendo todos os usuarios encontrados.</returns>
        List<UsuarioSistemaVO> Consultar(UsuarioSistemaVO usuarioSistemaVO, UsuarioSistemaFiltroConsulta usuarioSistemaFiltroConsulta, bool lazy);

        /// <summary>
        /// Método responsável por consultar todos os usuários do sistema.
        /// </summary>
        /// <param name="usuarioSistemaFiltroConsulta">Filtro contendo os campos necessários para retorno.</param>
        /// <param name="lazy"></param>
        /// <returns>Lista contendo todos os usuarios cadastrados.</returns>
        List<UsuarioSistemaVO> Consultar(UsuarioSistemaFiltroConsulta usuarioSistemaFiltroConsulta, bool lazy);
 
    }
}