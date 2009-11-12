using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAuxiliar.BaseRepositorio;
using MySql.Data.MySqlClient;
using Negocios.ModuloPostagem.VOs;
using Negocios.ModuloAuxuliar.Enuns;
using Negocios.ModuloPostagem.Filtros;
using Negocios.ModuloPostagem.Excecoes;
using Negocios.ModuloAuxiliar.Excecoes;


namespace Negocios.ModuloPostagem.Repositorios
{
    /// <summary>
    /// Summary description for PostagemRepositorio
    /// </summary>
    public class PostagemRepositorio : BaseRepositorioInicial, IPostagemRepositorio
    {

        #region Construtor
        public PostagemRepositorio()
        {

            //
            // TODO: Add constructor logic here
            //
        } 
        #endregion

        #region Métodos da Interface

        public void Incluir(PostagemVO postagemVO)
        {
            AdicionarParametro("UsuarioId", postagemVO.Usuario.ID);

            if (!string.IsNullOrEmpty(postagemVO.Preview))
            {
                AdicionarParametro("Preview", postagemVO.Preview);
            } else
                AdicionarParametro("Preview", DBNull.Value);

            if (!string.IsNullOrEmpty(postagemVO.Titulo))
            {
                AdicionarParametro("Titulo", postagemVO.Titulo);
            }
            else
                AdicionarParametro("Titulo", DBNull.Value);

            if (!string.IsNullOrEmpty(postagemVO.SubTitulo))
            {
                AdicionarParametro("SubTitulo", postagemVO.SubTitulo);
            }
            else
                AdicionarParametro("SubTitulo", DBNull.Value);

            if (!string.IsNullOrEmpty(postagemVO.Corpo))
            {
                AdicionarParametro("Corpo", postagemVO.Corpo);
            }
            else
                AdicionarParametro("Corpo", DBNull.Value);

            if (postagemVO.Imagem !=null )
            {
                AdicionarParametro("Imagem", postagemVO.Imagem);
            }
            else
                AdicionarParametro("Imagem", DBNull.Value);

            AdicionarParametro("StatusPostagem", postagemVO.StatusPostagem);
            AdicionarParametro("LocalPostagem", postagemVO.LocalPostagem);
            AdicionarParametro("TipoPostagem", postagemVO.TipoPostagem);

            AdicionarParametro("DataCriacao", postagemVO.DataCriacao);

            if (!(postagemVO.DataInicioVigencia == default(DateTime)))
            {
                AdicionarParametro("DataInicioVigencia", postagemVO.DataInicioVigencia);
            }
            else
                AdicionarParametro("DataInicioVigencia", DBNull.Value);

            if (!(postagemVO.DataFinalVigencia == default(DateTime)))
            {
                AdicionarParametro("DataFinalVigencia", postagemVO.DataFinalVigencia);
            }
            else
                AdicionarParametro("DataFinalVigencia", DBNull.Value);

            string sqlTexto = string.Concat("INSERT INTO Postagem ",
                                            "(UsuarioId,Preview,Titulo,SubTitulo,Corpo,Imagem,StatusPostagem,",
                                            "LocalPostagem,TipoPostagem,DataCriacao,DataInicioVigencia,DataFinalVigencia)",
                                            "VALUES",
                                            "(@UsuarioId,@Preview,@Titulo,@SubTitulo,@Corpo,@Imagem,@StatusPostagem,",
                                            "@LocalPostagem,@TipoPostagem,@DataCriacao,@DataInicioVigencia,@DataFinalVigencia)");

            try
            {
                /// Verifica se o INSERT foi executado corretamente
                if (ExecuteNonQuery(sqlTexto) == 0)
                {
                    throw new PostagemNaoIncluidaExcecao();
                }
            }
            catch (GenericException)
            {
                //Caso ocorra algum erro de FK no momento da inclusão no SQL Server.
                // throw new CoordenadorJaCadastradoExcecao();
            }

        }

        public void Excluir(PostagemVO postagemVO)
        {
            AdicionarParametro("id", postagemVO.ID);
            string sqlTexto = string.Concat(" DELETE FROM Postagem",
                                            " WHERE Id = @id");

            try
            {
                /// Verifica se o DELETE foi executado corretamente
                if (ExecuteNonQuery(sqlTexto) == 0)
                {
                    throw new PostagemNaoExcluidaExcecao();
                }
            }
            catch (GenericException)
            {
                //Caso ocorra algum erro de FK no momento da exclusão no SQL Server.
                //throw new CoordenadorJaUtilizadoExcecao();
            }
        }

        public void Alterar(PostagemVO postagemVO)
        {
            //bool adicionar = false;

            AdicionarParametro("UsuarioId", postagemVO.Usuario.ID);

            if (!string.IsNullOrEmpty(postagemVO.Preview))
            {
                AdicionarParametro("Preview", postagemVO.Preview);
            }
            else
                AdicionarParametro("Preview", DBNull.Value);

            if (!string.IsNullOrEmpty(postagemVO.Titulo))
            {
                AdicionarParametro("Titulo", postagemVO.Titulo);
            }
            else
                AdicionarParametro("Titulo", DBNull.Value);

            if (!string.IsNullOrEmpty(postagemVO.SubTitulo))
            {
                AdicionarParametro("SubTitulo", postagemVO.SubTitulo);
            }
            else
                AdicionarParametro("SubTitulo", DBNull.Value);

            if (!string.IsNullOrEmpty(postagemVO.Corpo))
            {
                AdicionarParametro("Corpo", postagemVO.Corpo);
            }
            else
                AdicionarParametro("Corpo", DBNull.Value);

            if (postagemVO.Imagem != null)
            {
                AdicionarParametro("Imagem", postagemVO.Imagem);
            }
            else
                AdicionarParametro("Imagem", DBNull.Value);

            AdicionarParametro("StatusPostagem", postagemVO.StatusPostagem);
            AdicionarParametro("LocalPostagem", postagemVO.LocalPostagem);
            AdicionarParametro("TipoPostagem", postagemVO.TipoPostagem);

          
            if (!(postagemVO.DataInicioVigencia == default(DateTime)))
            {
                AdicionarParametro("DataInicioVigencia", postagemVO.DataInicioVigencia);
            }
            else
                AdicionarParametro("DataInicioVigencia", DBNull.Value);

            if (!(postagemVO.DataFinalVigencia == default(DateTime)))
            {
                AdicionarParametro("DataFinalVigencia", postagemVO.DataFinalVigencia);
            }
            else
                AdicionarParametro("DataFinalVigencia", DBNull.Value);

            AdicionarParametro("ID", postagemVO.ID);

            //Criação da sql que sérá usada para incluir
            string sqlTexto = string.Concat(" UPDATE Postagem SET ",
                                            "UsuarioId=@UsuarioId, Preview=@Preview, Titulo=@Titulo, ",
                                            "SubTitulo=@SubTitulo, Corpo=@Corpo, Imagem=@Imagem, ",
                                            "StatusPostagem=@StatusPostagem, LocalPostagem=@LocalPostagem, ",
                                            "TipoPostagem=@TipoPostagem, ",
                                            "DataInicioVigencia=@DataInicioVigencia, ",
                                            "DataFinalVigencia=@DataFinalVigencia ",
                                            "WHERE ID=@ID");

            #region Alterar dinamico
            //if (!string.IsNullOrEmpty(postagemVO.Corpo))
            //{
            //    if (adicionar)
            //    {
            //        sqlTexto += ",";
            //        adicionar = false;
            //    }
            //    AdicionarParametro("Corpo", postagemVO.Corpo);
            //    sqlTexto += " Corpo=@Corpo ";
            //    adicionar = true;
            //}

            //if (postagemVO.DataFinalVigencia == default(DateTime))
            //{
            //    if (adicionar)
            //    {
            //        sqlTexto += ",";
            //        adicionar = false;
            //    }
            //    AdicionarParametro("DataFinalVigencia", postagemVO.DataFinalVigencia);
            //    sqlTexto += " DataFinalVigencia=@DataFinalVigencia ";
            //    adicionar = true;
            //}

            //if (postagemVO.DataInicioVigencia != default(DateTime))
            //{
            //    if (adicionar)
            //    {
            //        sqlTexto += ",";
            //        adicionar = false;
            //    }
            //    AdicionarParametro("DataInicioVigencia", postagemVO.DataInicioVigencia);
            //    sqlTexto += " DataInicioVigencia=@DataInicioVigencia ";
            //    adicionar = true;
            //}


            //if (postagemVO.StatusPostagem != StatusPostagem.NaoAlterar)
            //{
            //    if (adicionar)
            //    {
            //        sqlTexto += ",";
            //        adicionar = false;
            //    }
            //    AdicionarParametro("StatusPostagem", postagemVO.StatusPostagem);
            //    sqlTexto += " StatusPostagem=@StatusPostagem ";
            //    adicionar = true;
            //}

            //if (postagemVO.LocalPostagem != LocalPostagem.NaoAlterar)
            //{
            //    if (adicionar)
            //    {
            //        sqlTexto += ",";
            //        adicionar = false;
            //    }
            //    AdicionarParametro("LocalPostagem", postagemVO.LocalPostagem);
            //    sqlTexto += " LocalPostagem=@LocalPostagem ";
            //    adicionar = true;
            //}

            //if (!string.IsNullOrEmpty(postagemVO.Preview))
            //{
            //    if (adicionar)
            //    {
            //        sqlTexto += ",";
            //        adicionar = false;
            //    }
            //    AdicionarParametro("Preview", postagemVO.Preview);
            //    sqlTexto += " Preview=@Preview ";
            //    adicionar = true;
            //}

            //if (!string.IsNullOrEmpty(postagemVO.SubTitulo))
            //{
            //    if (adicionar)
            //    {
            //        sqlTexto += ",";
            //        adicionar = false;
            //    }
            //    AdicionarParametro("SubTitulo", postagemVO.SubTitulo);
            //    sqlTexto += " SubTitulo=@SubTitulo ";
            //    adicionar = true;
            //}

            //if (!string.IsNullOrEmpty(postagemVO.Titulo))
            //{
            //    if (adicionar)
            //    {
            //        sqlTexto += ",";
            //        adicionar = false;
            //    }
            //    AdicionarParametro("Titulo", postagemVO.Titulo);
            //    sqlTexto += " Titulo=@Titulo ";
            //    adicionar = true;
            //}


            //if (adicionar)
            //{
            //    sqlTexto += ",";
            //    AdicionarParametro("Imagem", postagemVO.Imagem);
            //    sqlTexto += " Imagem=@Imagem ";
            //    AdicionarParametro("ID", postagemVO.ID);
            //    sqlTexto += " WHERE Id=@ID ";
            //} 
            #endregion


            try
            {
                /// Verifica se o INSERT foi executado corretamente
                if (ExecuteNonQuery(sqlTexto) == 0)
                {
                    throw new PostagemNaoAlteradaExcecao();
                }
            }
            catch (GenericException)
            {
                //Caso ocorra algum erro de FK no momento da inclusão no SQL Server.
                // throw new CoordenadorJaCadastradoExcecao();
            }
        }

        public List<PostagemVO> Consultar(PostagemVO postagemVO, PostagemFiltroConsulta postagemFiltroConsulta, bool lazy)
        {
            string sqlTexto = "SELECT " + postagemFiltroConsulta.GetCampos() + " FROM Postagem ";

            if (postagemVO.ID != 0)
            {
                AdicionarParametro("ID", postagemVO.ID);
                sqlTexto += " WHERE Id=@ID ";

                return this.Consultar(sqlTexto, postagemFiltroConsulta, lazy);
            }
            else if (!string.IsNullOrEmpty(postagemVO.Preview) && !string.IsNullOrEmpty(postagemVO.Corpo) 
                     && !string.IsNullOrEmpty(postagemVO.SubTitulo) && !string.IsNullOrEmpty(postagemVO.Titulo))
                     
            {
                AdicionarParametro("Preview", postagemVO.Preview);
                AdicionarParametro("Corpo", postagemVO.Corpo);
                AdicionarParametro("SubTitulo", postagemVO.SubTitulo);
                AdicionarParametro("Titulo", postagemVO.Titulo);
                sqlTexto += " WHERE Preview like @Preview OR Corpo like @Corpo OR SubTitulo like @SubTitulo OR Titulo like @Titulo";
                if (postagemVO.TipoPostagem != TipoPostagem.NaoAlterar)
                {
                    AdicionarParametro("TipoPostagem", postagemVO.TipoPostagem);
                    sqlTexto += " AND TipoPostagem=@TipoPostagem ";
                }

                return this.Consultar(sqlTexto, postagemFiltroConsulta, lazy);
            }
            else if (!string.IsNullOrEmpty(postagemVO.Titulo))
            {
                AdicionarParametro("Titulo","%"+ postagemVO.Titulo +"%");
                sqlTexto += " WHERE Titulo like @Titulo";

                return this.Consultar(sqlTexto, postagemFiltroConsulta, lazy);
            }
            else if (postagemVO.TipoPostagem != TipoPostagem.NaoAlterar &&
                    postagemVO.LocalPostagem != LocalPostagem.NaoAlterar )
            {
                AdicionarParametro("TipoPostagem", postagemVO.TipoPostagem);
                AdicionarParametro("LocalPostagem", postagemVO.LocalPostagem);
                sqlTexto += " WHERE TipoPostagem=@TipoPostagem AND LocalPostagem=@LocalPostagem";

                return this.Consultar(sqlTexto, postagemFiltroConsulta, lazy);
            }
            else if (postagemVO.TipoPostagem != TipoPostagem.NaoAlterar)
            {
                AdicionarParametro("TipoPostagem", postagemVO.TipoPostagem);
                sqlTexto += " WHERE TipoPostagem=@TipoPostagem ";

                return this.Consultar(sqlTexto, postagemFiltroConsulta, lazy);


            }

            return this.Consultar(sqlTexto, postagemFiltroConsulta, lazy);
        }

        public List<PostagemVO> Consultar(PostagemFiltroConsulta postagemFiltroConsulta, bool lazy)
        {
            string sqlTexto = "SELECT " + postagemFiltroConsulta.GetCampos() + " FROM Postagem";

            return this.Consultar(sqlTexto, postagemFiltroConsulta, lazy);
        
        }

        #endregion

        #region Funcoes Utilitárias

        /// <summary>
        /// Consulta que recebe uma SQL em texto, à executa e preenche uma lista to tipo variavel 
        /// </summary>
        /// <param name="sqlTexto"> O Sql texto como parametro de consulta</param>
        /// <param name="filtro"> O filtro da consulta</param>
        /// <returns></returns>
        private List<PostagemVO> Consultar(string sqlTexto, PostagemFiltroConsulta filtro, bool lazy)
        {
            List<PostagemVO> postagemlist = new List<PostagemVO>();

            MySqlDataReader mySqlDataReader = ExecuteReader(sqlTexto);

            // Verifica se foram retornados dados da consulta
            if (mySqlDataReader != null && mySqlDataReader.HasRows)
            {
                // Loop para carregar a lista de retorno do metodo
                while (mySqlDataReader.Read())
                {
                    PostagemVO postagem = new PostagemVO();
                    //As verificações abaixo checam quais dados devem ser retornados na consulta,
                    //baseado nos campos do filtro passado como parâmetro. Depois checa se o valor do banco
                    //é diferente de nulo para não ocorrer problemas na hora da converção.
                    //----------------------------------------------------------------------------------

                    if (filtro["Id"])
                    {
                        if (mySqlDataReader["Id"] != DBNull.Value)
                            postagem.ID = Convert.ToInt32(mySqlDataReader["Id"]);
                    }

                   
                    if (filtro["UsuarioId"])
                    {
                        if (mySqlDataReader["UsuarioId"] != DBNull.Value)
                            postagem.Usuario.ID = Convert.ToInt32(mySqlDataReader["UsuarioId"]);
                    }
                    if (filtro["Preview"])
                    {
                        if (mySqlDataReader["Preview"] != DBNull.Value)
                            postagem.Preview = Convert.ToString(mySqlDataReader["Preview"]);
                    }

                    if (filtro["Titulo"])
                    {
                        if (mySqlDataReader["Titulo"] != DBNull.Value)
                            postagem.Titulo = Convert.ToString(mySqlDataReader["Titulo"]);
                    }
                    if (filtro["SubTitulo"])
                    {
                        if (mySqlDataReader["SubTitulo"] != DBNull.Value)
                            postagem.SubTitulo = Convert.ToString(mySqlDataReader["SubTitulo"]);
                    }

                    if (filtro["Corpo"])
                    {
                        if (mySqlDataReader["Corpo"] != DBNull.Value)
                            postagem.Corpo = Convert.ToString(mySqlDataReader["Corpo"]);
                    }

                    if (filtro["Imagem"])
                    {
                        if (mySqlDataReader["Imagem"] != DBNull.Value)
                            postagem.Imagem = (byte[])mySqlDataReader["Imagem"];
                    }


                    if (filtro["StatusPostagem"])
                    {
                        if (mySqlDataReader["StatusPostagem"] != DBNull.Value)
                            postagem.StatusPostagem = (StatusPostagem)Convert.ToInt32(mySqlDataReader["StatusPostagem"]);
                    }

                    if (filtro["LocalPostagem"])
                    {
                        if (mySqlDataReader["LocalPostagem"] != DBNull.Value)
                            postagem.LocalPostagem = (LocalPostagem)Convert.ToInt32(mySqlDataReader["LocalPostagem"]);
                    }

                    if (filtro["TipoPostagem"])
                    {
                        if (mySqlDataReader["TipoPostagem"] != DBNull.Value)
                            postagem.TipoPostagem = (TipoPostagem)Convert.ToInt32(mySqlDataReader["TipoPostagem"]);
                    }

                    if (filtro["DataCriacao"])
                    {
                        if (mySqlDataReader["DataCriacao"] != DBNull.Value)
                            postagem.DataCriacao = Convert.ToDateTime(mySqlDataReader["DataCriacao"]);
                    }

                    if (filtro["DataInicioVigencia"])
                    {
                        if (mySqlDataReader["DataInicioVigencia"] != DBNull.Value)
                            postagem.DataInicioVigencia = Convert.ToDateTime(mySqlDataReader["DataInicioVigencia"]);
                    }

                    if (filtro["DataFinalVigencia"])
                    {
                        if (mySqlDataReader["DataFinalVigencia"] != DBNull.Value)
                            postagem.DataFinalVigencia = Convert.ToDateTime(mySqlDataReader["DataFinalVigencia"]);
                    }

                    postagemlist.Add(postagem);
                }

            }
            if (mySqlDataReader != null && !mySqlDataReader.IsClosed)
                mySqlDataReader.Close();
            return postagemlist;
        }
        #endregion
    }
}