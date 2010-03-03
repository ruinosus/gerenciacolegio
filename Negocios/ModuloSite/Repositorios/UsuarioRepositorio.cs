using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloBasico.VOs;
using MySql.Data.MySqlClient;
using Negocios.ModuloBasico.Singleton;

namespace Negocios.ModuloSite.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        #region Atributos

        SiteColegioDB db;

        #endregion

        #region Métodos da Interface

        public void Incluir(Usuario usuario)
        {
            db.Usuario.InsertOnSubmit(usuario);
        }

        public void Excluir(Usuario usuario)
        {
            Usuario usuarioAux = new Usuario();
            usuarioAux.ID = usuario.ID;
            List<Usuario> resultado = this.Consultar(usuarioAux, TipoPesquisa.E);
            usuarioAux = resultado[0];

            db.Usuario.DeleteOnSubmit(usuarioAux);
        }

        public void Alterar(Usuario usuario)
        {
            Usuario usuarioAux = new Usuario();
            usuarioAux.ID = usuario.ID;
            List<Usuario> resultado = this.Consultar(usuarioAux, TipoPesquisa.E);
            usuarioAux = resultado[0];


            usuarioAux = resultado[0];
            //usuarioAux.Nome = usuario.Nome;
            usuarioAux.Login = usuario.Login;
            usuarioAux.Senha = usuario.Senha;
           

            Confirmar();
        }

        public List<Usuario> Consultar(Usuario usuario, TipoPesquisa tipoPesquisa)
        {
            List<Usuario> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (usuario.ID != 0)
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.ID == usuario.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                       // if (!string.IsNullOrEmpty(usuario.Nome))
                       // {

                       //     resultado = ((from p in resultado
                       //                   where
                       //                   p.Nome.Contains(usuario.Nome)
                       //                   select p).ToList());


                       //     resultado = resultado.Distinct().ToList();
                       //}   
					   
					   if (!string.IsNullOrEmpty(usuario.Login) && !string.IsNullOrEmpty(usuario.Senha) )
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Login.Equals(usuario.Login) && p.Senha.Equals(usuario.Senha) 
                                          select p).ToList());
                            resultado = resultado.Distinct().ToList();
                       } else 
					   {
						if (!string.IsNullOrEmpty(usuario.Login))
							{

								resultado = ((from p in resultado
											  where
											  p.Login.Equals(usuario.Login)
											  select p).ToList());
								resultado = resultado.Distinct().ToList();
						   }
					   }
                       break;
                    } 
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                         if (usuario.ID != 0)
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.ID == usuario.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }                

                       // if (!string.IsNullOrEmpty(usuario.Nome))
                       // {

                       //     resultado.AddRange((from p in resultado
                       //                   where
                       //                   p.Nome.Contains(usuario.Nome)
                       //                   select p).ToList());


                       //     resultado = resultado.Distinct().ToList();
                       //}   
					   
					   if (!string.IsNullOrEmpty(usuario.Login) && !string.IsNullOrEmpty(usuario.Senha) )
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.Login.Equals(usuario.Login) && p.Senha.Equals(usuario.Senha) 
                                          select p).ToList());
                            resultado = resultado.Distinct().ToList();
                       } else 
					   {
						if (!string.IsNullOrEmpty(usuario.Login))
							{

								resultado.AddRange((from p in resultado
											  where
											  p.Login.Equals(usuario.Login)
											  select p).ToList());
								resultado = resultado.Distinct().ToList();
						   }
					   }
                       break;
                    }
                #endregion
            }

            return resultado;
        }

        public List<Usuario> Consultar()
        {
            return db.Usuario.ToList();
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion

        #region Construtor
        public UsuarioRepositorio()
        {
            ConexaoSite conexao = new ConexaoSite();
            db = new SiteColegioDB(new MySqlConnection(conexao.ToString()));

        }
        #endregion
    }
}