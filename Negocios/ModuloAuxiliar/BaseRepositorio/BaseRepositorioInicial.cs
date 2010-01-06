using System;
using System.Web;
using System.Data;
using System.Collections;
using System.Configuration;
using System.Collections.Generic;
using Negocios.ModuloConexao;
using MySql.Data.MySqlClient;



namespace Negocios.ModuloAuxiliar.BaseRepositorio
{
    public class BaseRepositorioInicial
    {
        #region Atributos

        /// <summary>
        /// Atributo do Tipo SqlCommand usado para executar os comandos SQL.
        /// </summary>
        protected MySqlCommand sqlCommand;

        /// <summary>
        /// Atributo do Tipo SqlTransaction usado para manter as transa��es.
        /// </summary>
        protected MySqlTransaction sqlTransaction;

        #endregion

        #region Construtor

        /// <summary>
        /// Construtor da Classe
        /// </summary>
        public BaseRepositorioInicial()
        {
        }

        #endregion

        #region Destrutor

        /// <summary>
        /// Destrutor da Classe
        /// </summary>
        ~BaseRepositorioInicial()
        {
            if (sqlCommand != null)
            {
                sqlCommand.Dispose();
            }

            if (sqlTransaction != null)
            {
                sqlTransaction.Dispose();
            }
        }

        #endregion

        #region M�todos de Manipula��o de Parametros SQL

        /// <summary>
        /// Adiciona um par�metro ao sqlCommand
        /// </summary>
        /// <param name="nome">Nome do par�metro</param>
        /// <param name="valor">Valor do par�metro</param>
        protected void AdicionarParametro(string nome, object valor)
        {
            if (sqlCommand == null)
                    CriarSqlCommand();
           // CriarSqlCommand();

            MySqlParameter sqlParameter = new MySqlParameter();

            sqlParameter.ParameterName = nome;
            sqlParameter.Value = valor;

            sqlCommand.Parameters.Add(sqlParameter);
        }

        /// <summary>
        /// Adiciona um par�metro ao sqlCommand.
        /// </summary>
        /// <param name="parameter">SqlParameter que ser� passado.</param>
        protected void AdicionarParametro(MySqlParameter parameter)
        {
            CriarSqlCommand();

            sqlCommand.Parameters.Add(parameter);
        }

        /// <summary>
        /// Remove um espec�fico pram�tro do sqlCommand
        /// </summary>
        /// <param name="nome">Nome do par�metro que ser� removido</param>
        protected void RemoverParametro(string nome)
        {
            if (sqlCommand.Parameters[nome] != null)
            {
                sqlCommand.Parameters.Remove(sqlCommand.Parameters[nome]);
            }
        }

        /// <summary>
        /// Remove todos os par�metros do sqlCommand
        /// </summary>
        protected void RemoverParametros()
        {
            if (sqlCommand != null && sqlCommand.Parameters.Count > 0)
                sqlCommand.Parameters.Clear();
        }

        #endregion

        #region M�todos de Execu��o de Comandos SQL

        /// <summary>
        /// Executa um comando SQL que n�o retorna um conjunto dados
        /// </summary>
        /// <param name="command">O comando SQL que ser� executado</param>
        /// <returns>Quantidade de registros afetados</returns>
        protected int ExecuteNonQuery(string command)
        {
            int quantidadeRegistrosAfetados;

            try
            {
                sqlCommand.CommandText = command;
                quantidadeRegistrosAfetados = sqlCommand.ExecuteNonQuery();

                return quantidadeRegistrosAfetados;
            }
            catch (Exception ex)
            {
                //Checa se o erro veio do SQL Server.
                if (ex is MySqlException)
                {
                    String message = null;
                    MySqlException exSql = ex as MySqlException;

                    // Captura exce��es pelo n�mero
                    switch (exSql.Number)
                    {
                        case 547: // erro de FK de exclus�o.
                            message = Negocios.ModuloAuxiliar.Excecoes.GenericExceptionMessages.ERRO_FK_EXCLUSAO;
                            throw new Negocios.ModuloAuxiliar.Excecoes.GenericException(message);
                        case 2627: // erro de FK de inclus�o.
                            message = Negocios.ModuloAuxiliar.Excecoes.GenericExceptionMessages.ERRO_FK_INCLUSAO;
                            throw new Negocios.ModuloAuxiliar.Excecoes.GenericException(message);
                        case 2601: // erro de FK de inclus�o.
                            message = Negocios.ModuloAuxiliar.Excecoes.GenericExceptionMessages.ERRO_FK_INCLUSAO;
                            throw new Negocios.ModuloAuxiliar.Excecoes.GenericException(message);
                        default:
                            quantidadeRegistrosAfetados = 0;
                            break;
                    }
                }
                else
                {
                    quantidadeRegistrosAfetados = 0;
                }

                return quantidadeRegistrosAfetados;
            }
            finally
            {
                RemoverParametros();

                DestruirSqlCommand();
            }
        }

        /// <summary>
        /// Executa um comando SQL que n�o retorna um conjunto dados.
        /// </summary>
        /// <param name="command">O comando SQL que ser� executado</param>
        /// <returns>Id do registro na tabela.</returns>
        protected int ExecuteNonQuery_ID(string command)
        {
            return ExecuteNonQuery_ID(command, true);
        }

        /// <summary>
        /// Executa um comando SQL que n�o retorna um conjunto dados.
        /// </summary>
        /// <param name="command">O comando SQL que ser� executado</param>
        /// <param name="OnErrorResumeNext">Ativar ou desativar tratamento de exce��es.</param>
        /// <returns>Id do registro na tabela.</returns>
        protected int ExecuteNonQuery_ID(string command, bool OnErrorResumeNext)
        {
            int ID;

            try
            {
                command = command.Insert(command.Length, " SELECT SCOPE_IDENTITY()");

                ID = Convert.ToInt32(ExecuteScalar(command, OnErrorResumeNext));

                return ID;
            }
            catch (Exception ex)
            {
                //Checa se o erro veio do SQL Server.
                if (ex is MySqlException)
                {
                    String message = null;
                    MySqlException exSql = ex as MySqlException;

                    // Captura exce��es pelo n�mero
                    switch (exSql.Number)
                    {
                        case 547: // erro de FK de exclus�o.
                            message = Negocios.ModuloAuxiliar.Excecoes.GenericExceptionMessages.ERRO_FK_EXCLUSAO;
                            throw new Negocios.ModuloAuxiliar.Excecoes.GenericException(message);
                        case 2627: // erro de FK de inclus�o.
                            message = Negocios.ModuloAuxiliar.Excecoes.GenericExceptionMessages.ERRO_FK_INCLUSAO;
                            throw new Negocios.ModuloAuxiliar.Excecoes.GenericException(message);
                        default:
                            ID = 0;
                            break;
                    }
                }
                else if (ex is Negocios.ModuloAuxiliar.Excecoes.GenericException & !OnErrorResumeNext)
                {
                    throw new Negocios.ModuloAuxiliar.Excecoes.GenericException(ex.Message);
                }
                else
                {
                    ID = 0;
                }
                return ID;
            }
        }

        /// <summary>
        /// Executa um comando SQL  que retorna um conjunto de dados
        /// </summary>
        /// <param name="command">O comando SQL  que ser� executado</param>
        /// <returns>Conjunto de dados retornado pelo comando ou null em caso de erro na consulta</returns>
        public MySqlDataReader ExecuteReader(string command)
        {
            MySqlDataReader sqlDataReader = null;
            try
            {
                if (sqlCommand == null)
                    CriarSqlCommand();

                sqlCommand.CommandText = command;
                if (!String.IsNullOrEmpty(sqlCommand.CommandText))
                    sqlDataReader = sqlCommand.ExecuteReader();
                return sqlDataReader;
            }
            catch(Exception)
            {
                return sqlDataReader;
            }
            finally
            {
                RemoverParametros();

                DestruirSqlCommand();
            }
        }

        /// <summary>
        /// Executa um comando SQL que retorna um conjunto de dados
        /// </summary>
        /// <param name="command">O comando SQL que ser� executado</param>
        /// <returns></returns>
        protected IEnumerator ExcecuteReader(string command)
        {
            IEnumerator iEnumerator;
            MySqlDataReader sqlDataReader;

            try
            {
                sqlCommand.CommandText = command;
                sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);

                iEnumerator = sqlDataReader.GetEnumerator();

                sqlDataReader.Close();

                return iEnumerator;
            }
            catch (MySqlException)
            {
                iEnumerator = null;
                return iEnumerator;
            }
            finally
            {
                RemoverParametros();

                DestruirSqlCommand();
            }
        }

        /// <summary>
        /// Executa um comando SQL que retorna apenas um dado.
        /// </summary>
        /// <param name="command">O comando SQL que ser� executado</param>
        /// <returns>Dado retornado pelo comando</returns>
        protected object ExecuteScalar(string command)
        {
            return ExecuteScalar(command, true);
        }

        /// <summary>
        /// Executa um comando SQL que retorna apenas um dado.
        /// </summary>
        /// <param name="command">O comando SQL que ser� executado</param>
        /// <param name="OnErrorResumeNext">Ativar ou desativar tratamento de exce��es.</param>
        /// <returns>Dado retornado pelo comando</returns>
        protected object ExecuteScalar(string command, bool OnErrorResumeNext)
        {
            object dadoDeRetorno;

            try
            {
                if (sqlCommand == null)
                    CriarSqlCommand();

                sqlCommand.CommandText = command;
                dadoDeRetorno = sqlCommand.ExecuteScalar();

                return dadoDeRetorno;
            }
            catch (MySqlException ex)
            {
                if (!OnErrorResumeNext)
                {
                    // Captura exce��es pelo n�mero
                    switch (ex.Number)
                    {
                        case 547: // erro de FK de exclus�o.
                            throw new Negocios.ModuloAuxiliar.Excecoes.GenericException(Negocios.ModuloAuxiliar.Excecoes.GenericExceptionMessages.ERRO_FK_EXCLUSAO);
                        case 2627: // erro de FK de inclus�o.
                            throw new Negocios.ModuloAuxiliar.Excecoes.GenericException(Negocios.ModuloAuxiliar.Excecoes.GenericExceptionMessages.ERRO_FK_INCLUSAO);
                        default:
                            throw new Negocios.ModuloAuxiliar.Excecoes.GenericException(Negocios.ModuloAuxiliar.Excecoes.GenericExceptionMessages.ERRO_GENERICO);
                    }
                }
                dadoDeRetorno = null;
                return dadoDeRetorno;
            }
            finally
            {
                RemoverParametros();

                DestruirSqlCommand();
            }
        }

        #endregion

        #region M�todos de Manipula��o de Transa��es

        /// <summary>
        /// Inicia uma Transa��o
        /// </summary>
        [Obsolete]
        protected void BeginTransaction()
        {
            sqlCommand.Transaction = sqlTransaction;
        }

        /// <summary>
        /// Inicia uma Transa��o
        /// </summary>
        /// <param name="nomeTransacao">Nome da Transa��o</param>
        [Obsolete]
        protected void BeginTransaction(string nomeTransacao)
        {
            sqlCommand.Transaction = sqlTransaction;
        }

        /// <summary>
        /// Comita uma Transa��o
        /// </summary>
        [Obsolete]
        protected void Commit()
        {
            if (sqlTransaction != null)
                sqlTransaction.Commit();
        }

        /// <summary>
        /// Cancela uma Transa��o
        /// </summary>
        [Obsolete]
        protected void Rollback()
        {
            if (sqlTransaction != null)
                sqlTransaction.Rollback();
        }

        #endregion

        #region M�todos Utilit�rios

        /// <summary>
        /// Cria um novo objeto do tipo SqlCommand
        /// </summary>
        protected void CriarSqlCommand()
        {
            if (sqlCommand == null)
            {
                sqlCommand = BancoConexao.GetSqlCommand();
            }
        }

        /// <summary>
        /// Destroi um objeto do tipo SqlCommand
        /// </summary>
        protected void DestruirSqlCommand()
        {
            if (sqlCommand != null)
            {
                sqlCommand.Dispose();
                sqlCommand = null;
            }
        }

        #endregion
    }
}