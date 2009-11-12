using System;
using System.Web;
using System.Data;
using System.Configuration;
using System.Web.SessionState;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Negocios.ModuloConexao
{
    public static class BancoConexao
    {
        #region Atributos

        private static Dictionary<string, MySqlConnection> connectionPool = new Dictionary<string, MySqlConnection>();

        #endregion

        #region Gets

        public static MySqlCommand GetSqlCommand()
        {
            try
            {
                return GetSqlConnection().CreateCommand();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static MySqlTransaction GetSqlTransaction()
        {
            try
            {
                return GetSqlConnection().BeginTransaction();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static MySqlTransaction GetSqlTransaction(string nomeTransacao)
        {
            try
            {
                //GetSqlConnection().BeginTransaction(nomeTransacao)
                return GetSqlConnection().BeginTransaction();
            }
            catch (Exception)
            {
                return null;
            }
        }

        #endregion

        #region Métodos Utilitários

        private static MySqlConnection GetSqlConnection()
        {
            try
            {
                if (connectionPool.ContainsKey(Session()))
                {
                    if (!Conectado(connectionPool[Session()]))
                    {
                        Conectar(connectionPool[Session()]);
                    }
                }
                else
                {
                    CreateConnection();
                }

                return connectionPool[Session()];
            }
            catch (Exception)
            {
                return null;
            }
        }

        private static bool Conectado(MySqlConnection sqlConnection)
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                return true;
            }

            return false;
        }

        private static void Conectar(MySqlConnection sqlConnection)
        {
            sqlConnection.Open();
        }

        private static string Session()
        {
            //return HttpContext.Current.Session.SessionID;

            return HttpContext.Current.Request.GetHashCode().ToString();
        }

        #endregion

        #region Métodos Públicos

        public static MySqlConnection CreateConnection()
        {
            try
            {
                MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["Site"].ConnectionString);
                sqlConnection.Open();


                connectionPool.Add(Session(), sqlConnection);

                return sqlConnection;
            }
            catch (Exception)
            {
                ReleaseConnection();
                MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["Site"].ConnectionString);
                sqlConnection.Open();
                connectionPool.Add(Session(), sqlConnection);

                return sqlConnection;
            }


        }

        public static void ReleaseConnection()
        {
            try
            {
                if (connectionPool.ContainsKey(Session()))
                {
                    if (Conectado(connectionPool[Session()]))
                    {
                        connectionPool[Session()].Close();

                        connectionPool[Session()].Dispose();

                        connectionPool.Remove(Session());
                    }
                }
            }
            catch (Exception)
            { }
        }

        #endregion
    }
}