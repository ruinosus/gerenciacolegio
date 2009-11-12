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
using Negocios.ModuloAuxiliar.BaseRepositorio;
using Negocios.ModuloAuxiliar.Repositorios;
using System.Collections.Generic;
using Negocios.ModuloAuxuliar.VOs;
using Negocios.ModuloAuxuliar.Filtros;
using MySql.Data.MySqlClient;


namespace Negocios.ModuloAuxiliar.Repositorios
{
    /// <summary>
    /// Summary description for CidadeRepositorio
    /// </summary>
    public class CidadeEstadoRegiaoRepositorio : BaseRepositorioInicial, ICidadeEstadoRegiaoRepositorio
    {
        #region Construtor

        public CidadeEstadoRegiaoRepositorio()
            : base()
        { }

        #endregion

        #region Metodos da Interface

        public List<Regiao> ConsultarRegioes(Regiao regiao, RegiaoFiltroConsulta regiaoFiltroConsulta, bool lazy)
        {
            List<Regiao> regiaoList = new List<Regiao>();

            string sqlTexto = string.Concat("SELECT ", regiaoFiltroConsulta.GetCampos(), " FROM Regiao ");

            if (regiao != null)
            {
                if (regiao.ID != 0)
                {
                    AdicionarParametro("ID", regiao.ID);

                    sqlTexto += " WHERE id=@ID";

                    return this.ConsultarRegioes(sqlTexto, regiaoFiltroConsulta, lazy);

                }
                else if (!string.IsNullOrEmpty(regiao.Nome))
                {
                    AdicionarParametro("NOME", "%" + regiao.Nome + "%");

                    sqlTexto += " WHERE Nome like @NOME";

                    return this.ConsultarRegioes(sqlTexto, regiaoFiltroConsulta, lazy);
                }
                else if (!string.IsNullOrEmpty(regiao.Sigla))
                {
                    AdicionarParametro("Sigla", "%" + regiao.Sigla + "%");

                    sqlTexto += " WHERE Sigla like @Sigla";

                    return this.ConsultarRegioes(sqlTexto, regiaoFiltroConsulta, lazy);
                }

            }

            return this.ConsultarRegioes(sqlTexto, regiaoFiltroConsulta, lazy);

        }

        public List<Regiao> ConsultarRegioes(RegiaoFiltroConsulta regiaoFiltroConsulta, bool lazy)
        {
            List<Estado> estadoList = new List<Estado>();

            string sqlTexto = string.Concat("SELECT ", regiaoFiltroConsulta.GetCampos(), " FROM Regiao ");

            return this.ConsultarRegioes(sqlTexto, regiaoFiltroConsulta, lazy);
        }

        public List<Estado> ConsultarEstados(Estado estado, EstadoFiltroConsulta estadoFiltroConsulta, bool lazy)
        {
            List<Estado> estadoList = new List<Estado>();

            string sqlTexto = string.Concat("SELECT ", estadoFiltroConsulta.GetCampos(), " FROM Estado ");

            if (estado != null)
            {
                if (estado.ID != 0)
                {
                    AdicionarParametro("ID", estado.ID);

                    sqlTexto += " WHERE id=@ID";

                    return this.ConsultarEstados(sqlTexto, estadoFiltroConsulta, lazy);

                }
                else if (!string.IsNullOrEmpty(estado.Nome))
                {
                    AdicionarParametro("NOME", "%" + estado.Nome + "%");

                    sqlTexto += " WHERE Nome like @NOME";

                    return this.ConsultarEstados(sqlTexto, estadoFiltroConsulta, lazy);
                }
                else if (!string.IsNullOrEmpty(estado.Sigla))
                {
                    AdicionarParametro("Sigla", "%" + estado.Sigla + "%");

                    sqlTexto += " WHERE Sigla like @Sigla";

                    return this.ConsultarEstados(sqlTexto, estadoFiltroConsulta, lazy);
                }

            }

            return this.ConsultarEstados(sqlTexto, estadoFiltroConsulta, lazy);

        }

        public List<Estado> ConsultarEstados(EstadoFiltroConsulta estadoFiltroConsulta, bool lazy)
        {
            List<Estado> estadoList = new List<Estado>();

            string sqlTexto = string.Concat("SELECT ", estadoFiltroConsulta.GetCampos(), " FROM Estado ");

            return this.ConsultarEstados(sqlTexto, estadoFiltroConsulta, lazy);

        }

        public List<Cidade> ConsultarCidades(Cidade cidade, CidadeFiltroConsulta cidadeFiltroConsulta, bool lazy)
        {
            List<Cidade> cidadeList = new List<Cidade>();

            string sqlTexto = string.Concat("SELECT ", cidadeFiltroConsulta.GetCampos(), " FROM Cidade ");

            if (cidade != null)
            {
                if (cidade.ID != 0)
                {
                    AdicionarParametro("ID", cidade.ID);

                    sqlTexto += " WHERE id=@ID";

                    return this.ConsultarCidades(sqlTexto, cidadeFiltroConsulta, lazy);

                }
                else if (!string.IsNullOrEmpty(cidade.Nome))
                {
                    AdicionarParametro("NOME", "%" + cidade.Nome + "%");

                    sqlTexto += " WHERE Nome like @NOME";

                    return this.ConsultarCidades(sqlTexto, cidadeFiltroConsulta, lazy);
                }
                else if (cidade.Estado.ID != 0)
                {
                    AdicionarParametro("EstadoId", cidade.Estado.ID);

                    sqlTexto += " WHERE EstadoId= @EstadoId";

                    return this.ConsultarCidades(sqlTexto, cidadeFiltroConsulta, lazy);
                }

            }

            return this.ConsultarCidades(sqlTexto, cidadeFiltroConsulta, lazy);

        }

        public List<Cidade> ConsultarCidades(CidadeFiltroConsulta cidadeFiltroConsulta, bool lazy)
        {
            List<Cidade> cidadeList = new List<Cidade>();

            string sqlTexto = string.Concat("SELECT ", cidadeFiltroConsulta.GetCampos(), " FROM Cidade ");



            return this.ConsultarCidades(sqlTexto, cidadeFiltroConsulta, lazy);

        }


        #endregion

        #region Funcoes Utilitárias

        /// <summary>
        /// Consulta que recebe uma SQL em texto, à executa e preenche uma lista to tipo variavel 
        /// </summary>
        /// <param name="sqlTexto"> O Sql texto como parametro de consulta</param>
        /// <param name="marcaFiltroProduto"> O filtro da consulta</param>
        /// <returns></returns>
        private List<Cidade> ConsultarCidades(string sqlTexto, CidadeFiltroConsulta filtro, bool lazy)
        {
            List<Cidade> cidadeList = new List<Cidade>();

            MySqlDataReader mySqlDataReader = ExecuteReader(sqlTexto);

            // Verifica se foram retornados dados da consulta
            if (mySqlDataReader != null && mySqlDataReader.HasRows)
            {
                // Loop para carregar a lista de retorno do metodo
                while (mySqlDataReader.Read())
                {
                    Cidade cidade = new Cidade();
                    //As verificações abaixo checam quais dados devem ser retornados na consulta,
                    //baseado nos campos do filtro passado como parâmetro. Depois checa se o valor do banco
                    //é diferente de nulo para não ocorrer problemas na hora da converção.
                    //----------------------------------------------------------------------------------

                    if (filtro["Id"])
                    {
                        if (mySqlDataReader["Id"] != DBNull.Value)
                            cidade.ID = Convert.ToInt32(mySqlDataReader["Id"]);
                    }

                    if (filtro["Nome"])
                    {
                        if (mySqlDataReader["Nome"] != DBNull.Value)
                            cidade.Nome = Convert.ToString(mySqlDataReader["Nome"]);
                    }

                    if (filtro["EstadoId"])
                    {
                        if (mySqlDataReader["EstadoId"] != DBNull.Value)
                        {
                            int estadoId = Convert.ToInt32(mySqlDataReader["EstadoId"]);

                            cidade.Estado.ID = estadoId;

                        }
                    }
                    cidadeList.Add(cidade);
                }

            }
            if (mySqlDataReader != null && !mySqlDataReader.IsClosed)
                mySqlDataReader.Close();
            return cidadeList;
        }

        /// <summary>
        /// Consulta que recebe uma SQL em texto, à executa e preenche uma lista to tipo variavel 
        /// </summary>
        /// <param name="sqlTexto"> O Sql texto como parametro de consulta</param>
        /// <param name="marcaFiltroProduto"> O filtro da consulta</param>
        /// <returns></returns>
        private List<Estado> ConsultarEstados(string sqlTexto, EstadoFiltroConsulta filtro, bool lazy)
        {
            List<Estado> estadoList = new List<Estado>();

            MySqlDataReader mySqlDataReader = ExecuteReader(sqlTexto);

            // Verifica se foram retornados dados da consulta
            if (mySqlDataReader != null && mySqlDataReader.HasRows)
            {
                // Loop para carregar a lista de retorno do metodo
                while (mySqlDataReader.Read())
                {
                    Estado estado = new Estado();
                    //As verificações abaixo checam quais dados devem ser retornados na consulta,
                    //baseado nos campos do filtro passado como parâmetro. Depois checa se o valor do banco
                    //é diferente de nulo para não ocorrer problemas na hora da converção.
                    //----------------------------------------------------------------------------------

                    if (filtro["Id"])
                    {
                        if (mySqlDataReader["Id"] != DBNull.Value)
                            estado.ID = Convert.ToInt32(mySqlDataReader["Id"]);
                    }

                    if (filtro["RegiaoId"])
                    {
                        if (mySqlDataReader["RegiaoId"] != DBNull.Value)
                            estado.Regiao.ID = Convert.ToInt32(mySqlDataReader["RegiaoId"]);
                    }


                    if (filtro["Nome"])
                    {
                        if (mySqlDataReader["Nome"] != DBNull.Value)
                            estado.Nome = Convert.ToString(mySqlDataReader["Nome"]);
                    }

                    if (filtro["Sigla"])
                    {
                        if (mySqlDataReader["Sigla"] != DBNull.Value)
                            estado.Sigla = Convert.ToString(mySqlDataReader["Sigla"]);
                    }
                    estadoList.Add(estado);
                }

            }
            if (mySqlDataReader != null && !mySqlDataReader.IsClosed)
                mySqlDataReader.Close();
            return estadoList;
        }

        /// <summary>
        /// Consulta que recebe uma SQL em texto, à executa e preenche uma lista to tipo variavel 
        /// </summary>
        /// <param name="sqlTexto"> O Sql texto como parametro de consulta</param>
        /// <param name="marcaFiltroProduto"> O filtro da consulta</param>
        /// <returns></returns>
        private List<Regiao> ConsultarRegioes(string sqlTexto, RegiaoFiltroConsulta filtro, bool lazy)
        {
            List<Regiao> regiaoList = new List<Regiao>();

            MySqlDataReader mySqlDataReader = ExecuteReader(sqlTexto);

            // Verifica se foram retornados dados da consulta
            if (mySqlDataReader != null && mySqlDataReader.HasRows)
            {
                // Loop para carregar a lista de retorno do metodo
                while (mySqlDataReader.Read())
                {
                    Regiao regiao = new Regiao();
                    //As verificações abaixo checam quais dados devem ser retornados na consulta,
                    //baseado nos campos do filtro passado como parâmetro. Depois checa se o valor do banco
                    //é diferente de nulo para não ocorrer problemas na hora da converção.
                    //----------------------------------------------------------------------------------

                    if (filtro["Id"])
                    {
                        if (mySqlDataReader["Id"] != DBNull.Value)
                            regiao.ID = Convert.ToInt32(mySqlDataReader["Id"]);
                    }

                    


                    if (filtro["Nome"])
                    {
                        if (mySqlDataReader["Nome"] != DBNull.Value)
                            regiao.Nome = Convert.ToString(mySqlDataReader["Nome"]);
                    }

                    if (filtro["Sigla"])
                    {
                        if (mySqlDataReader["Sigla"] != DBNull.Value)
                            regiao.Sigla = Convert.ToString(mySqlDataReader["Sigla"]);
                    }
                    regiaoList.Add(regiao);
                }

            }
            if (mySqlDataReader != null && !mySqlDataReader.IsClosed)
                mySqlDataReader.Close();
            return regiaoList;
        }



        #endregion

       
    }
}