using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAuxiliar.BaseRepositorio;
using Negocios.ModuloComentario.VOs;
using Negocios.ModuloComentario.Filtro;
using MySql.Data.MySqlClient;
using Negocios.ModuloComentario.Excecoes;
using Negocios.ModuloAuxiliar.Excecoes;

namespace Negocios.ModuloComentario.Repositorios
{
    /// <summary>
    /// Summary description for ComentarioRepositorio
    /// </summary>
    public class ComentarioRepositorio : BaseRepositorioInicial, IComentarioRepositorio
    {
        #region Construtor
        public ComentarioRepositorio()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion

        #region Métodos da Interface

        public void Incluir(ComentarioVO comentario)
        {
            AdicionarParametro("UsuarioId", comentario.Usuario.ID);
            AdicionarParametro("PostagemId", comentario.Postagem.ID);
            AdicionarParametro("Descricao", comentario.Descricao);
            AdicionarParametro("DataCriacao", comentario.DataCriacao);
            string sqlTexto = @"INSERT INTO Comentario 
                                (UsuarioId,PostagemId,Descricao,DataCriacao)
                                VALUES
                                (@UsuarioId,@PostagemId,@Descricao,@DataCriacao)
                                ";

            /// Verifica se o INSERT foi executado corretamente
            if (ExecuteNonQuery(sqlTexto) == 0)
            {
                throw new ComentarioNaoIncluidoExcecao();
            }

        }

        public void Excluir(ComentarioVO comentario)
        {
            AdicionarParametro("id", comentario.Id);
            string sqlTexto = @"DELETE FROM Comentario
                                WHERE Id=@id";

            /// Verifica se o DELETE foi executado corretamente
            if (ExecuteNonQuery(sqlTexto) == 0)
            {
                throw new ComentarioNaoExcluidoExcecao();
            }

        }

        public void Alterar(ComentarioVO comentario)
        {
            AdicionarParametro("id", comentario.Id);
            AdicionarParametro("UsuarioId", comentario.Usuario.ID);
            AdicionarParametro("PostagemId", comentario.Postagem.ID);
            AdicionarParametro("Descricao", comentario.Descricao);
            AdicionarParametro("DataCriacao", comentario.DataCriacao);
            string sqlTexto = @"UPDATE Comentario SET
                                UsuarioId=@UsuarioId,PostagemId=@PostagemId,Descricao=@Descricao,DataCriacao=@DataCriacao
                                WHERE Id = @id
                                ";

            /// Verifica se o INSERT foi executado corretamente
            if (ExecuteNonQuery(sqlTexto) == 0)
            {
                throw new ComentarioNaoAlteradoExcecao();
            }
        }

        public List<ComentarioVO> Consultar(ComentarioVO comentario, ComentarioFiltroConsulta comentarioFiltroConsulta, bool lazy)
        {
            string sqlTexto = "SELECT " + comentarioFiltroConsulta.GetCampos() + " FROM Comentario ";

            if (comentario.Id != 0)
            {
                AdicionarParametro("ID", comentario.Id);
                sqlTexto += " WHERE Id=@ID ";

                return this.Consultar(sqlTexto, comentarioFiltroConsulta, lazy);
            }
            else if (comentario.Postagem != null && comentario.Postagem.ID != 0 &&
                comentario.Usuario != null && comentario.Usuario.ID != 0)
            {
                AdicionarParametro("UsuarioId", comentario.Usuario.ID);
                AdicionarParametro("PostagemId", comentario.Postagem.ID);
                sqlTexto += " WHERE UsuarioId=@UsuarioId AND PostagemId=@PostagemId ";

                return this.Consultar(sqlTexto, comentarioFiltroConsulta, lazy);

            }
            else if (comentario.Usuario != null && comentario.Usuario.ID != 0)
            {
                AdicionarParametro("UsuarioId", comentario.Usuario.ID);
                sqlTexto += " WHERE UsuarioId=@UsuarioId ";

                return this.Consultar(sqlTexto, comentarioFiltroConsulta, lazy);

            }
            else if (comentario.Postagem != null && comentario.Postagem.ID != 0)
            {
                AdicionarParametro("PostagemId", comentario.Postagem.ID);
                sqlTexto += " WHERE PostagemId=@PostagemId ";

                return this.Consultar(sqlTexto, comentarioFiltroConsulta, lazy);

            }
            return this.Consultar(sqlTexto, comentarioFiltroConsulta, lazy);

        }

        public List<ComentarioVO> Consultar(ComentarioFiltroConsulta comentarioFiltroConsulta, bool lazy)
        {
            string sqlTexto = "SELECT " + comentarioFiltroConsulta.GetCampos() + " FROM Comentario ";
            return this.Consultar(sqlTexto, comentarioFiltroConsulta, lazy);
        }

        #endregion

        #region Funcoes Utilitárias

        /// <summary>
        /// Consulta que recebe uma SQL em texto, à executa e preenche uma lista to tipo variavel 
        /// </summary>
        /// <param name="sqlTexto"> O Sql texto como parametro de consulta</param>
        /// <param name="filtro"> O filtro da consulta</param>
        /// <returns></returns>
        private List<ComentarioVO> Consultar(string sqlTexto, ComentarioFiltroConsulta filtro, bool lazy)
        {
            List<ComentarioVO> comentariolist = new List<ComentarioVO>();

            MySqlDataReader mySqlDataReader = ExecuteReader(sqlTexto);

            // Verifica se foram retornados dados da consulta
            if (mySqlDataReader != null && mySqlDataReader.HasRows)
            {
                // Loop para carregar a lista de retorno do metodo
                while (mySqlDataReader.Read())
                {
                    ComentarioVO comentario = new ComentarioVO();
                    //As verificações abaixo checam quais dados devem ser retornados na consulta,
                    //baseado nos campos do filtro passado como parâmetro. Depois checa se o valor do banco
                    //é diferente de nulo para não ocorrer problemas na hora da converção.
                    //----------------------------------------------------------------------------------

                    if (filtro["Id"])
                    {
                        if (mySqlDataReader["Id"] != DBNull.Value)
                            comentario.Id = Convert.ToInt32(mySqlDataReader["Id"]);
                    }


                    if (filtro["UsuarioId"])
                    {
                        if (mySqlDataReader["UsuarioId"] != DBNull.Value)
                            comentario.Usuario.ID = Convert.ToInt32(mySqlDataReader["UsuarioId"]);
                    }

                    if (filtro["PostagemId"])
                    {
                        if (mySqlDataReader["PostagemId"] != DBNull.Value)
                            comentario.Postagem.ID = Convert.ToInt32(mySqlDataReader["PostagemId"]);
                    }

                    if (filtro["DataCriacao"])
                    {
                        if (mySqlDataReader["DataCriacao"] != DBNull.Value)
                            comentario.DataCriacao = Convert.ToDateTime(mySqlDataReader["DataCriacao"]);
                    }

                    if (filtro["Descricao"])
                    {
                        if (mySqlDataReader["Descricao"] != DBNull.Value)
                            comentario.Descricao = Convert.ToString(mySqlDataReader["Descricao"]);
                    }



                    comentariolist.Add(comentario);
                }

            }
            if (mySqlDataReader != null && !mySqlDataReader.IsClosed)
                mySqlDataReader.Close();
            return comentariolist;
        }
        #endregion
    }
}
