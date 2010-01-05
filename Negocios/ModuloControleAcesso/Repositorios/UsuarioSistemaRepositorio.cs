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
using System.Collections.Generic;
using Negocios.ModuloAuxiliar.BaseFiltro;
using MySql.Data.MySqlClient;
using Negocios.ModuloAuxuliar.Enums;
using Negocios.ModuloControleAcesso.Filtros;
using Negocios.ModuloControleAcesso.Processos;
using Negocios.ModuloAuxuliar.VOs;
using Negocios.ModuloAuxuliar.Filtros;
using Negocios.ModuloControleAcesso.Excecoes;
using Negocios.ModuloAuxiliar.Excecoes;
using Negocios.ModuloAuxiliar.Processos;
using Negocios.ModuloControleAcesso.VOs;


namespace Negocios.ModuloControleAcesso.Repositorios
{
    /// <summary>
    /// Summary description for UsuarioSistemaRepositorio
    /// </summary>
    public class UsuarioSistemaRepositorio : BaseRepositorioInicial, IUsuarioSistemaRepositorio
    {
        #region Construtor

        public UsuarioSistemaRepositorio()
            : base()
        { }

        #endregion

        #region Metodos da Interface

        public void Incluir(UsuarioSistemaVO usuarioSistemaVO)
        {
            AdicionarParametro("CidadeId", usuarioSistemaVO.Endereco.Cidade.ID);
            AdicionarParametro("Nome", usuarioSistemaVO.Nome);
            AdicionarParametro("NomeOrganizador", usuarioSistemaVO.NomeOrganizador);
            AdicionarParametro("StatusUsuario", usuarioSistemaVO.StatusUsuarioSistema);
            AdicionarParametro("Email", usuarioSistemaVO.Email);
            AdicionarParametro("Site", usuarioSistemaVO.Site);
            AdicionarParametro("Cpf", usuarioSistemaVO.CPF);
            AdicionarParametro("DataNascimento", usuarioSistemaVO.DataNascimento);
            AdicionarParametro("Sexo", usuarioSistemaVO.Sexo);
            AdicionarParametro("Rg", usuarioSistemaVO.Rg.Numero);
            AdicionarParametro("DataExpedicao", usuarioSistemaVO.Rg.DataExpedicao);
            AdicionarParametro("OrgaoExpeditor", usuarioSistemaVO.Rg.OrgaoExpeditor);
            AdicionarParametro("Logradouro", usuarioSistemaVO.Endereco.Logradouro);
            AdicionarParametro("Bairro", usuarioSistemaVO.Endereco.Bairro);
            AdicionarParametro("Complemento", usuarioSistemaVO.Endereco.Complemento);
            AdicionarParametro("Cep", usuarioSistemaVO.Endereco.Cep);
            AdicionarParametro("Numero", usuarioSistemaVO.Endereco.Numero);
            AdicionarParametro("Descricao", usuarioSistemaVO.Descricao);
            AdicionarParametro("Login", usuarioSistemaVO.Login);
            AdicionarParametro("Senha", usuarioSistemaVO.Senha);
            AdicionarParametro("Administrador", usuarioSistemaVO.IsAdministrador);
            AdicionarParametro("Aviso", usuarioSistemaVO.Aviso);
            AdicionarParametro("LogradouroAtua", usuarioSistemaVO.EnderecoAtua.Logradouro);
            AdicionarParametro("BairroAtua", usuarioSistemaVO.EnderecoAtua.Bairro);
            AdicionarParametro("ComplementoAtua", usuarioSistemaVO.EnderecoAtua.Complemento);
            AdicionarParametro("CepAtua", usuarioSistemaVO.EnderecoAtua.Cep);
            AdicionarParametro("NumeroAtua", usuarioSistemaVO.EnderecoAtua.Numero);
            AdicionarParametro("CidadeIdAtua", usuarioSistemaVO.EnderecoAtua.Cidade.ID);
            AdicionarParametro("Telefone", usuarioSistemaVO.Telefone);
            AdicionarParametro("Celular", usuarioSistemaVO.Celular);

            if (usuarioSistemaVO.Imagem != null)
            {
                AdicionarParametro("Imagem", usuarioSistemaVO.Imagem);
            }
            else
                AdicionarParametro("Imagem", DBNull.Value);
            //Criação da sql que sérá usada para incluir
            string sqlTexto = @"INSERT INTO Usuario
                             (CidadeId,Nome,NomeOrganizador
                             ,StatusUsuario,Email,Site,Cpf,DataNascimento,Sexo
                             ,Rg,DataExpedicao,OrgaoExpeditor,Logradouro,Bairro
                             ,Complemento,Cep,Numero,Descricao,Login,Senha,Administrador,Aviso,CidadeIdAtua,Telefone,Celular,LogradouroAtua,BairroAtua
                             ,ComplementoAtua,CepAtua,NumeroAtua,Imagem)
                             VALUES
                             (@CidadeId,@Nome,@NomeOrganizador
                             ,@StatusUsuario,@Email,@Site,@Cpf,@DataNascimento,@Sexo
                             ,@Rg,@DataExpedicao,@OrgaoExpeditor,@Logradouro,@Bairro
                             ,@Complemento,@Cep,@Numero,@Descricao,@Login,@Senha,@Administrador,@Aviso,@CidadeIdAtua,@Telefone,@Celular,@LogradouroAtua,@BairroAtua
                             ,@ComplementoAtua,@CepAtua,@NumeroAtua,@Imagem)";
            try
            {
                /// Verifica se o INSERT foi executado corretamente
                if (ExecuteNonQuery(sqlTexto) == 0)
                {
                    throw new UsuarioSistemaNaoIncluidoExcecao();
                }
            }
            catch (GenericException)
            {
                //Caso ocorra algum erro de FK no momento da inclusão no SQL Server.
                // throw new CoordenadorJaCadastradoExcecao();
            }
        }

        public void Excluir(UsuarioSistemaVO usuarioSistemaVO)
        {
            AdicionarParametro("id", usuarioSistemaVO.ID);
            string sqlTexto = string.Concat(" DELETE FROM Usuario",
                                            " WHERE Id = @id");

            try
            {
                /// Verifica se o DELETE foi executado corretamente
                if (ExecuteNonQuery(sqlTexto) == 0)
                {
                    throw new UsuarioSistemaNaoExcluidoExcecao();
                }
            }
            catch (GenericException)
            {
                //Caso ocorra algum erro de FK no momento da exclusão no SQL Server.
                //throw new CoordenadorJaUtilizadoExcecao();
            }
        }

        public void Alterar(UsuarioSistemaVO usuarioSistemaVO)
        {
            bool adicionar = false;


            //Criação da sql que sérá usada para incluir
            string sqlTexto = " UPDATE Usuario SET ";

            if (usuarioSistemaVO.Endereco.Cidade.ID != 0)
            {
                AdicionarParametro("CidadeId", usuarioSistemaVO.Endereco.Cidade.ID);
                sqlTexto += " CidadeId=@CidadeId ";
                adicionar = true;
            }

            if (!string.IsNullOrEmpty(usuarioSistemaVO.Nome))
            {
                if (adicionar)
                {
                    sqlTexto += ",";
                    adicionar = false;
                }
                AdicionarParametro("Nome", usuarioSistemaVO.Nome);
                sqlTexto += " Nome=@Nome ";
                adicionar = true;
            }

            if (!string.IsNullOrEmpty(usuarioSistemaVO.NomeOrganizador))
            {
                if (adicionar)
                {
                    sqlTexto += ",";
                    adicionar = false;
                }
                AdicionarParametro("NomeOrganizador", usuarioSistemaVO.NomeOrganizador);
                sqlTexto += " NomeOrganizador=@NomeOrganizador ";
                adicionar = true;
            }

            if (usuarioSistemaVO.StatusUsuarioSistema != StatusUsuarioSistema.NaoAlterar)
            {
                if (adicionar)
                {
                    sqlTexto += ",";
                    adicionar = false;
                }
                AdicionarParametro("StatusUsuario", usuarioSistemaVO.StatusUsuarioSistema);
                sqlTexto += " StatusUsuario=@StatusUsuario ";
                adicionar = true;
            }

            if (!string.IsNullOrEmpty(usuarioSistemaVO.Email))
            {
                if (adicionar)
                {
                    sqlTexto += ",";
                    adicionar = false;
                }
                AdicionarParametro("Email", usuarioSistemaVO.Email);
                sqlTexto += " Email=@Email ";
                adicionar = true;
            }
            if (!string.IsNullOrEmpty(usuarioSistemaVO.Site))
            {
                if (adicionar)
                {
                    sqlTexto += ",";
                    adicionar = false;
                }
                AdicionarParametro("Site", usuarioSistemaVO.Site);
                sqlTexto += " Site=@Site ";
                adicionar = true;
            }

            if (!string.IsNullOrEmpty(usuarioSistemaVO.CPF))
            {
                if (adicionar)
                {
                    sqlTexto += ",";
                    adicionar = false;
                }
                AdicionarParametro("Cpf", usuarioSistemaVO.CPF);
                sqlTexto += " Cpf=@Cpf ";
                adicionar = true;
            }
            if (usuarioSistemaVO.DataNascimento != default(DateTime))
            {
                if (adicionar)
                {
                    sqlTexto += ",";
                    adicionar = false;
                }

                AdicionarParametro("DataNascimento", usuarioSistemaVO.DataNascimento);
                sqlTexto += " DataNascimento=@DataNascimento ";
                adicionar = true;
            }
            if (!string.IsNullOrEmpty(usuarioSistemaVO.Sexo.ToString()))
            {
                if (adicionar)
                {
                    sqlTexto += ",";
                    adicionar = false;
                }
                AdicionarParametro("Sexo", usuarioSistemaVO.Sexo);
                sqlTexto += " Sexo=@Sexo ";
                adicionar = true;
            }

            if (!string.IsNullOrEmpty(usuarioSistemaVO.Rg.Numero))
            {
                if (adicionar)
                {
                    sqlTexto += ",";
                    adicionar = false;
                }
                AdicionarParametro("Rg", usuarioSistemaVO.Rg.Numero);
                sqlTexto += " Rg=@Rg ";
                adicionar = true;
            }

            if (usuarioSistemaVO.Rg.DataExpedicao != default(DateTime))
            {
                if (adicionar)
                {
                    sqlTexto += ",";
                    adicionar = false;
                }

                AdicionarParametro("DataExpedicao", usuarioSistemaVO.Rg.DataExpedicao);
                sqlTexto += " DataExpedicao=@DataExpedicao ";
                adicionar = true;
            }
            if (!string.IsNullOrEmpty(usuarioSistemaVO.Rg.OrgaoExpeditor))
            {
                if (adicionar)
                {
                    sqlTexto += ",";
                    adicionar = false;
                }
                AdicionarParametro("OrgaoExpeditor", usuarioSistemaVO.Rg.OrgaoExpeditor);
                sqlTexto += " OrgaoExpeditor=@OrgaoExpeditor ";
                adicionar = true;
            }

            if (!string.IsNullOrEmpty(usuarioSistemaVO.Endereco.Logradouro))
            {
                if (adicionar)
                {
                    sqlTexto += ",";
                    adicionar = false;
                }
                AdicionarParametro("Logradouro", usuarioSistemaVO.Endereco.Logradouro);
                sqlTexto += " Logradouro=@Logradouro ";
                adicionar = true;
            }
            if (!string.IsNullOrEmpty(usuarioSistemaVO.Endereco.Bairro))
            {
                if (adicionar)
                {
                    sqlTexto += ",";
                    adicionar = false;
                }
                AdicionarParametro("Bairro", usuarioSistemaVO.Endereco.Bairro);
                sqlTexto += " Bairro=@Bairro ";
                adicionar = true;
            }

            if (!string.IsNullOrEmpty(usuarioSistemaVO.Endereco.Complemento))
            {
                if (adicionar)
                {
                    sqlTexto += ",";
                    adicionar = false;
                }
                AdicionarParametro("Complemento", usuarioSistemaVO.Endereco.Complemento);
                sqlTexto += " Complemento=@Complemento ";
                adicionar = true;
            }
            if (!string.IsNullOrEmpty(usuarioSistemaVO.Endereco.Cep))
            {
                if (adicionar)
                {
                    sqlTexto += ",";
                    adicionar = false;
                }
                AdicionarParametro("Cep", usuarioSistemaVO.Endereco.Cep);
                sqlTexto += " Cep=@Cep ";
                adicionar = true;
            }
            if (!string.IsNullOrEmpty(usuarioSistemaVO.Endereco.Numero))
            {
                if (adicionar)
                {
                    sqlTexto += ",";
                    adicionar = false;
                }
                AdicionarParametro("Numero", usuarioSistemaVO.Endereco.Numero);
                sqlTexto += " Numero=@Numero ";
                adicionar = true;
            }
            if (!string.IsNullOrEmpty(usuarioSistemaVO.Descricao))
            {
                if (adicionar)
                {
                    sqlTexto += ",";
                    adicionar = false;
                }
                AdicionarParametro("Descricao", usuarioSistemaVO.Descricao);
                sqlTexto += " Descricao=@Descricao ";
                adicionar = true;
            }

            if (!string.IsNullOrEmpty(usuarioSistemaVO.Login))
            {
                if (adicionar)
                {
                    sqlTexto += ",";
                    adicionar = false;
                }
                AdicionarParametro("Login", usuarioSistemaVO.Login);
                sqlTexto += " Login=@Login ";
                adicionar = true;
            }
            if (!string.IsNullOrEmpty(usuarioSistemaVO.Senha))
            {
                if (adicionar)
                {
                    sqlTexto += ",";
                    adicionar = false;
                }
                AdicionarParametro("Senha", usuarioSistemaVO.Senha);
                sqlTexto += " Senha=@Senha ";
                adicionar = true;
            }

            if (!string.IsNullOrEmpty(usuarioSistemaVO.Aviso))
            {
                if (adicionar)
                {
                    sqlTexto += ",";
                    adicionar = false;
                }
                AdicionarParametro("Aviso", usuarioSistemaVO.Aviso);
                sqlTexto += " Aviso=@Aviso ";
                adicionar = true;
            }

            if (!string.IsNullOrEmpty(usuarioSistemaVO.Telefone))
            {
                if (adicionar)
                {
                    sqlTexto += ",";
                    adicionar = false;
                }

                AdicionarParametro("Telefone", usuarioSistemaVO.Telefone);
                sqlTexto += " Telefone=@Telefone ";
                adicionar = true;
            }
            if (!string.IsNullOrEmpty(usuarioSistemaVO.Celular))
            {
                if (adicionar)
                {
                    sqlTexto += ",";
                    adicionar = false;
                }
                AdicionarParametro("Celular", usuarioSistemaVO.Celular);
                sqlTexto += " Celular=@Celular ";
                adicionar = true;
            }

            if (usuarioSistemaVO.EnderecoAtua.Cidade.ID != 0)
            {
                if (adicionar)
                {
                    sqlTexto += ",";
                    adicionar = false;
                }
                AdicionarParametro("CidadeIdAtua", usuarioSistemaVO.EnderecoAtua.Cidade.ID);
                sqlTexto += " CidadeIdAtua=@CidadeIdAtua ";
                adicionar = true;
            }

            if (!string.IsNullOrEmpty(usuarioSistemaVO.EnderecoAtua.Logradouro))
            {
                if (adicionar)
                {
                    sqlTexto += ",";
                    adicionar = false;
                }
                AdicionarParametro("LogradouroAtua", usuarioSistemaVO.EnderecoAtua.Logradouro);
                sqlTexto += " LogradouroAtua=@LogradouroAtua ";
                adicionar = true;
            }
            if (!string.IsNullOrEmpty(usuarioSistemaVO.EnderecoAtua.Bairro))
            {
                if (adicionar)
                {
                    sqlTexto += ",";
                    adicionar = false;
                }
                AdicionarParametro("BairroAtua", usuarioSistemaVO.EnderecoAtua.Bairro);
                sqlTexto += " BairroAtua=@BairroAtua ";
                adicionar = true;
            }

            if (!string.IsNullOrEmpty(usuarioSistemaVO.EnderecoAtua.Complemento))
            {
                if (adicionar)
                {
                    sqlTexto += ",";
                    adicionar = false;
                }
                AdicionarParametro("ComplementoAtua", usuarioSistemaVO.EnderecoAtua.Complemento);
                sqlTexto += " ComplementoAtua=@ComplementoAtua ";
                adicionar = true;
            }
            if (!string.IsNullOrEmpty(usuarioSistemaVO.EnderecoAtua.Cep))
            {
                if (adicionar)
                {
                    sqlTexto += ",";
                    adicionar = false;
                }
                AdicionarParametro("CepAtua", usuarioSistemaVO.EnderecoAtua.Cep);
                sqlTexto += " CepAtua=@CepAtua ";
                adicionar = true;
            }
            if (!string.IsNullOrEmpty(usuarioSistemaVO.EnderecoAtua.Numero))
            {
                if (adicionar)
                {
                    sqlTexto += ",";
                    adicionar = false;
                }
                AdicionarParametro("NumeroAtua", usuarioSistemaVO.EnderecoAtua.Numero);
                sqlTexto += " NumeroAtua=@NumeroAtua ";
                adicionar = true;
            }
            if (usuarioSistemaVO.Imagem != null)
            {

                if (adicionar)
                {
                    sqlTexto += ",";
                    adicionar = false;
                }
                AdicionarParametro("Imagem", usuarioSistemaVO.Imagem);
                sqlTexto += " Imagem=@Imagem";
                adicionar = true;
            }
            if (adicionar)
            {
                sqlTexto += ",";
                sqlTexto += " Administrador=@Administrador ";
                AdicionarParametro("Administrador", usuarioSistemaVO.IsAdministrador);

            }



            AdicionarParametro("ID", usuarioSistemaVO.ID);
            sqlTexto += " WHERE Id=@ID ";
            try
            {
                /// Verifica se o INSERT foi executado corretamente
                if (ExecuteNonQuery(sqlTexto) == 0)
                {
                    throw new UsuarioSistemaNaoAlteradoExcecao();
                }
            }
            catch (GenericException)
            {
                //Caso ocorra algum erro de FK no momento da inclusão no SQL Server.
                // throw new CoordenadorJaCadastradoExcecao();
            }
        }

        public List<UsuarioSistemaVO> Consultar(UsuarioSistemaVO usuarioSistemaVO, UsuarioSistemaFiltroConsulta usuarioSistemaFiltroConsulta, bool lazy)
        {
            string sqlTexto = "SELECT " + usuarioSistemaFiltroConsulta.GetCampos() + " FROM Usuario ";

            if (usuarioSistemaVO != null)
            {
                if (usuarioSistemaVO.ID != 0)
                {
                    AdicionarParametro("ID", usuarioSistemaVO.ID);
                    sqlTexto += " WHERE Usuario.Id=@ID ";

                    return this.Consultar(sqlTexto, usuarioSistemaFiltroConsulta, lazy);
                }
                else if (!string.IsNullOrEmpty(usuarioSistemaVO.Login) && !string.IsNullOrEmpty(usuarioSistemaVO.Senha))
                {
                    AdicionarParametro("Login", usuarioSistemaVO.Login);
                    AdicionarParametro("Senha", usuarioSistemaVO.Senha);
                    sqlTexto += " WHERE Usuario.Login=@Login AND Usuario.Senha=@Senha ";

                    return this.Consultar(sqlTexto, usuarioSistemaFiltroConsulta, lazy);
                }
                else if (!string.IsNullOrEmpty(usuarioSistemaVO.Login))
                {
                    AdicionarParametro("Login", usuarioSistemaVO.Login);
                    sqlTexto += " WHERE Usuario.Login=@Login ";

                    return this.Consultar(sqlTexto, usuarioSistemaFiltroConsulta, lazy);

                }
                else if (!string.IsNullOrEmpty(usuarioSistemaVO.Nome))
                {
                    AdicionarParametro("Nome", "%" + usuarioSistemaVO.Nome + "%");
                    sqlTexto += " WHERE Usuario.Nome like @Nome";

                    return this.Consultar(sqlTexto, usuarioSistemaFiltroConsulta, lazy);

                }
                else if (usuarioSistemaVO.EnderecoAtua.Cidade.Estado.ID != 0)
                {
                    AdicionarParametro("EstadoId", usuarioSistemaVO.EnderecoAtua.Cidade.Estado.ID);
                    sqlTexto += @" INNER JOIN Cidade C on C.Id = Usuario.CidadeIdAtua 
                                    INNER JOIN Estado E ON E.Id=C.EstadoId                                   
                                    WHERE E.Id = @EstadoId ";

                    return this.Consultar(sqlTexto, usuarioSistemaFiltroConsulta, lazy);

                }

                else
                {
                    AdicionarParametro("StatusUsuario", usuarioSistemaVO.StatusUsuarioSistema);
                    sqlTexto += " WHERE Usuario.StatusUsuario = @StatusUsuario";

                    return this.Consultar(sqlTexto, usuarioSistemaFiltroConsulta, lazy);

                }
            }

            return this.Consultar(sqlTexto, usuarioSistemaFiltroConsulta, lazy);
        }

        public List<UsuarioSistemaVO> Consultar(UsuarioSistemaFiltroConsulta usuarioSistemaFiltroConsulta, bool lazy)
        {
            string sqlTexto = "SELECT " + usuarioSistemaFiltroConsulta.GetCampos() + " FROM Usuario";

            return this.Consultar(sqlTexto, usuarioSistemaFiltroConsulta, lazy);
        }

        #endregion

        #region Funcoes Utilitárias

        /// <summary>
        /// Consulta que recebe uma SQL em texto, à executa e preenche uma lista to tipo variavel 
        /// </summary>
        /// <param name="sqlTexto"> O Sql texto como parametro de consulta</param>
        /// <param name="marcaFiltroProduto"> O filtro da consulta</param>
        /// <returns></returns>
        private List<UsuarioSistemaVO> Consultar(string sqlTexto, UsuarioSistemaFiltroConsulta filtro, bool lazy)
        {
            List<UsuarioSistemaVO> usuariolist = new List<UsuarioSistemaVO>();

            MySqlDataReader mySqlDataReader = ExecuteReader(sqlTexto);

            // Verifica se foram retornados dados da consulta
            if (mySqlDataReader != null && mySqlDataReader.HasRows)
            {
                // Loop para carregar a lista de retorno do metodo
                while (mySqlDataReader.Read())
                {
                    UsuarioSistemaVO usuario = new UsuarioSistemaVO();
                    //As verificações abaixo checam quais dados devem ser retornados na consulta,
                    //baseado nos campos do filtro passado como parâmetro. Depois checa se o valor do banco
                    //é diferente de nulo para não ocorrer problemas na hora da converção.
                    //----------------------------------------------------------------------------------

                    if (filtro["Usuario.Id"])
                    {
                        if (mySqlDataReader["Id"] != DBNull.Value)
                            usuario.ID = Convert.ToInt32(mySqlDataReader["Id"]);
                    }

                    if (filtro["Usuario.Cpf"])
                    {
                        if (mySqlDataReader["Cpf"] != DBNull.Value)
                            usuario.CPF = Convert.ToString(mySqlDataReader["Cpf"]);
                    }
                    if (filtro["Usuario.DataNascimento"])
                    {
                        if (mySqlDataReader["DataNascimento"] != DBNull.Value)
                            usuario.DataNascimento = Convert.ToDateTime(mySqlDataReader["DataNascimento"]);
                    }
                    if (filtro["Usuario.Email"])
                    {
                        if (mySqlDataReader["Email"] != DBNull.Value)
                            usuario.Email = Convert.ToString(mySqlDataReader["Email"]);
                    }
                    if (filtro["Usuario.Site"])
                    {
                        if (mySqlDataReader["Site"] != DBNull.Value)
                            usuario.Site = Convert.ToString(mySqlDataReader["Site"]);
                    }

                    if (filtro["Usuario.Nome"])
                    {
                        if (mySqlDataReader["Nome"] != DBNull.Value)
                            usuario.Nome = Convert.ToString(mySqlDataReader["Nome"]);
                    }

                    if (filtro["Usuario.NomeOrganizador"])
                    {
                        if (mySqlDataReader["NomeOrganizador"] != DBNull.Value)
                            usuario.NomeOrganizador = Convert.ToString(mySqlDataReader["NomeOrganizador"]);
                    }


                    if (filtro["Usuario.Sexo"])
                    {
                        if (mySqlDataReader["Sexo"] != DBNull.Value)
                            usuario.Sexo = Convert.ToChar(mySqlDataReader["Sexo"]);
                    }

                    if (filtro["Usuario.Rg"])
                    {
                        if (mySqlDataReader["Rg"] != DBNull.Value)
                            usuario.Rg.Numero = Convert.ToString(mySqlDataReader["Rg"]);
                    }

                    if (filtro["Usuario.DataExpedicao"])
                    {
                        if (mySqlDataReader["DataExpedicao"] != DBNull.Value)
                            usuario.Rg.DataExpedicao = Convert.ToDateTime(mySqlDataReader["DataExpedicao"]);
                    }

                    if (filtro["Usuario.OrgaoExpeditor"])
                    {
                        if (mySqlDataReader["OrgaoExpeditor"] != DBNull.Value)
                            usuario.Rg.OrgaoExpeditor = Convert.ToString(mySqlDataReader["OrgaoExpeditor"]);
                    }

                    if (filtro["Usuario.StatusUsuario"])
                    {
                        if (mySqlDataReader["StatusUsuario"] != DBNull.Value)
                            usuario.StatusUsuarioSistema = (StatusUsuarioSistema)Convert.ToInt32(mySqlDataReader["StatusUsuario"]);
                    }
                    if (filtro["Usuario.Logradouro"])
                    {
                        if (mySqlDataReader["Logradouro"] != DBNull.Value)
                            usuario.Endereco.Logradouro = Convert.ToString(mySqlDataReader["Logradouro"]);
                    }

                    if (filtro["Usuario.Cep"])
                    {
                        if (mySqlDataReader["Cep"] != DBNull.Value)
                            usuario.Endereco.Cep = Convert.ToString(mySqlDataReader["Cep"]);
                    }

                    if (filtro["Usuario.Bairro"])
                    {
                        if (mySqlDataReader["Bairro"] != DBNull.Value)
                            usuario.Endereco.Bairro = Convert.ToString(mySqlDataReader["Bairro"]);
                    }

                    if (filtro["Usuario.Complemento"])
                    {
                        if (mySqlDataReader["Complemento"] != DBNull.Value)
                            usuario.Endereco.Complemento = Convert.ToString(mySqlDataReader["Complemento"]);
                    }

                    if (filtro["Usuario.CidadeId"])
                    {
                        if (mySqlDataReader["CidadeId"] != DBNull.Value)
                            usuario.Endereco.Cidade.ID = Convert.ToInt32(mySqlDataReader["CidadeId"]);
                    }

                    if (filtro["Usuario.Numero"])
                    {
                        if (mySqlDataReader["Numero"] != DBNull.Value)
                            usuario.Endereco.Numero = Convert.ToString(mySqlDataReader["Numero"]);
                    }

                    if (filtro["Usuario.LogradouroAtua"])
                    {
                        if (mySqlDataReader["LogradouroAtua"] != DBNull.Value)
                            usuario.EnderecoAtua.Logradouro = Convert.ToString(mySqlDataReader["LogradouroAtua"]);
                    }

                    if (filtro["Usuario.CepAtua"])
                    {
                        if (mySqlDataReader["CepAtua"] != DBNull.Value)
                            usuario.EnderecoAtua.Cep = Convert.ToString(mySqlDataReader["CepAtua"]);
                    }

                    if (filtro["Usuario.BairroAtua"])
                    {
                        if (mySqlDataReader["BairroAtua"] != DBNull.Value)
                            usuario.EnderecoAtua.Bairro = Convert.ToString(mySqlDataReader["BairroAtua"]);
                    }

                    if (filtro["Usuario.ComplementoAtua"])
                    {
                        if (mySqlDataReader["ComplementoAtua"] != DBNull.Value)
                            usuario.EnderecoAtua.Complemento = Convert.ToString(mySqlDataReader["ComplementoAtua"]);
                    }

                    if (filtro["Usuario.CidadeIdAtua"])
                    {
                        if (mySqlDataReader["CidadeIdAtua"] != DBNull.Value)
                            usuario.EnderecoAtua.Cidade.ID = Convert.ToInt32(mySqlDataReader["CidadeIdAtua"]);
                    }

                    if (filtro["Usuario.NumeroAtua"])
                    {
                        if (mySqlDataReader["NumeroAtua"] != DBNull.Value)
                            usuario.EnderecoAtua.Numero = Convert.ToString(mySqlDataReader["NumeroAtua"]);
                    }

                    if (filtro["Usuario.Descricao"])
                    {
                        if (mySqlDataReader["Descricao"] != DBNull.Value)
                            usuario.Descricao = Convert.ToString(mySqlDataReader["Descricao"]);
                    }

                    if (filtro["Usuario.Aviso"])
                    {
                        if (mySqlDataReader["Aviso"] != DBNull.Value)
                            usuario.Aviso = Convert.ToString(mySqlDataReader["Aviso"]);
                    }

                    if (filtro["Usuario.Administrador"])
                    {
                        if (mySqlDataReader["Administrador"] != DBNull.Value)
                            usuario.IsAdministrador = Convert.ToBoolean(mySqlDataReader["Administrador"]);
                    }

                    if (filtro["Usuario.Login"])
                    {
                        if (mySqlDataReader["Login"] != DBNull.Value)
                            usuario.Login = Convert.ToString(mySqlDataReader["Login"]);
                    }

                    if (filtro["Usuario.Senha"])
                    {
                        if (mySqlDataReader["Senha"] != DBNull.Value)
                            usuario.Senha = Convert.ToString(mySqlDataReader["Senha"]);
                    }

                    if (filtro["Usuario.Telefone"])
                    {
                        if (mySqlDataReader["Telefone"] != DBNull.Value)
                            usuario.Telefone = Convert.ToString(mySqlDataReader["Telefone"]);
                    }

                    if (filtro["Usuario.Celular"])
                    {
                        if (mySqlDataReader["Celular"] != DBNull.Value)
                            usuario.Celular = Convert.ToString(mySqlDataReader["Celular"]);
                    }

                    if (filtro["Usuario.Imagem"])
                    {
                        if (mySqlDataReader["Imagem"] != DBNull.Value)
                            usuario.Imagem = (byte[])mySqlDataReader["Imagem"];
                    }

                    usuariolist.Add(usuario);
                }

            }
            if (mySqlDataReader != null && !mySqlDataReader.IsClosed)
                mySqlDataReader.Close();
            return usuariolist;
        }
        #endregion
    }
}