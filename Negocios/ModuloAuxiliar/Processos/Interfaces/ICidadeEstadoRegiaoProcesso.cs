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
using Negocios.ModuloAuxuliar.VOs;
using System.Collections.Generic;
using Negocios.ModuloAuxuliar.Filtros;

namespace Negocios.ModuloAuxiliar.Processos
{
    /// <summary>
    /// Summary description for ICidadeEstadoProcesso
    /// </summary>
    public interface ICidadeEstadoRegiaoProcesso
    {
        /// <summary>
        /// Método responsável por consultar Regiões do Brasil de acordo com o parametro passado.
        /// </summary>
        /// <param name="regiao">Objeto do tipo região que será utilizado para pesquisa.</param>
        /// <param name="regiaoFiltroConsulta">Filtro contendo os campos necessários para retorno.</param>
        /// <param name="lazy"></param>
        /// <returns>Uma lista contendo todos os estados encontrados.</returns>     
        List<Regiao> ConsultarRegioes(Regiao regiao, RegiaoFiltroConsulta regiaoFiltroConsulta, bool lazy);

        /// <summary>
        /// Método responsável por consultar todas as Regiões do Brasil.
        /// </summary>
        /// <param name="regiaoFiltroConsulta">Filtro contendo os campos necessários para retorno.</param>
        /// <param name="lazy"></param>
        /// <returns>Uma lista contendo todos os estados encontrados.</returns>     
        List<Regiao> ConsultarRegioes(RegiaoFiltroConsulta regiaoFiltroConsulta, bool lazy);

        /// <summary>
        /// Método responsável por consultar Estados do Brasil de acordo com o parametro passado.
        /// </summary>
        /// <param name="cidade">Objeto do tipo estadi que será utilizado para pesquisa.</param>
        /// <param name="estadoFiltroConsulta">Filtro contendo os campos necessários para retorno.</param>
        /// <param name="lazy"></param>
        /// <returns>Uma lista contendo todos os estados encontrados.</returns>     
        List<Estado> ConsultarEstados(Estado estado, EstadoFiltroConsulta estadoFiltroConsulta, bool lazy);

        /// <summary>
        /// Método responsável por consultar todos os Estados do Brasil.
        /// </summary>
        /// <param name="estadoFiltroConsulta">Filtro contendo os campos necessários para retorno.</param>
        /// <param name="lazy"></param>
        /// <returns>Uma lista contendo todos os estados encontrados.</returns>     
        List<Estado> ConsultarEstados(EstadoFiltroConsulta estadoFiltroConsulta, bool lazy);


        /// <summary>
        /// Método responsável por consultar Cidades do Brasil de acordo com o parametro passado.
        /// </summary>
        /// <param name="cidade">Objeto do tipo cidade que será utilizado para pesquisa.</param>
        /// <param name="cidadeFiltroConsulta">Filtro contendo os campos necessários para retorno.</param>
        /// <param name="lazy"></param>
        /// <returns>Uma lista contendo todas as cidades encontradas.</returns>       
        List<Cidade> ConsultarCidades(Cidade cidade, CidadeFiltroConsulta cidadeFiltroConsulta, bool lazy);

        /// <summary>
        /// Método responsável por consultar todas as Cidades do Brasil.
        /// </summary>
        /// <param name="cidadeFiltroConsulta">Filtro contendo os campos necessários para retorno.</param>
        /// <param name="lazy"></param>
        /// <returns>Uma lista contendo todas as cidades encontradas.</returns>       
        List<Cidade> ConsultarCidades(CidadeFiltroConsulta cidadeFiltroConsulta, bool lazy);


    }
}