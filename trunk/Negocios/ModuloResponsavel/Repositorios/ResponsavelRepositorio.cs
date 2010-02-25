using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloResponsavel.Excecoes;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloBasico.VOs;

namespace Negocios.ModuloResponsavel.Repositorios
{
    public class ResponsavelRepositorio : IResponsavelRepositorio
    {
        #region Atributos

        ColegioDB db;

        #endregion

        #region Métodos da Interface

        public List<Responsavel> Consultar()
        {
            return db.Responsavel.ToList();
        }

        public List<Responsavel> Consultar(Responsavel responsavel, TipoPesquisa tipoPesquisa)
        {

            List<Responsavel> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (responsavel.ID != 0)
                        {

                            resultado = ((from r in resultado
                                          where
                                          r.ID == responsavel.ID
                                          select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (responsavel.Nascimento.HasValue && responsavel.Nascimento.Value != default(DateTime))
                        {

                            resultado = ((from r in resultado
                                          where
                                          r.Nascimento.HasValue && r.Nascimento.Value == responsavel.Nascimento.Value
                                          select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.LocalTrabalho))
                        {

                            resultado = ((from r in resultado
                                          where
                                          r.LocalTrabalho.Contains(responsavel.LocalTrabalho)
                                          select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.Cpf))
                        {

                            resultado = ((from r in resultado
                                          where
                                        r.Cpf != null && r.Cpf.Contains(responsavel.Cpf)
                                          select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.Bairro))
                        {

                            resultado = ((from r in resultado
                                          where
                                          r.Bairro.Contains(responsavel.Bairro)
                                          select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.Cep))
                        {


                            resultado = ((from r in resultado
                                          where
                                          r.Cep.Contains(responsavel.Cep)
                                          select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.Cidade))
                        {

                            resultado = ((from r in resultado
                                          where
                                          r.Cidade.Contains(responsavel.Cidade)
                                          select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.ComplementoEndereco))
                        {

                            resultado = ((from r in resultado
                                          where
                                          r.ComplementoEndereco.Contains(responsavel.ComplementoEndereco)
                                          select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.Profissao))
                        {

                            resultado = ((from r in resultado
                                          where
                                          r.Profissao.Contains(responsavel.Profissao)
                                          select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.Rg))
                        {


                            resultado = ((from r in resultado
                                          where
                                          r.Rg.Contains(responsavel.Rg)
                                          select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }



                        if (!string.IsNullOrEmpty(responsavel.Email))
                        {

                            resultado = ((from r in resultado
                                          where
                                          r.Email.Contains(responsavel.Email)
                                          select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }



                        if (!string.IsNullOrEmpty(responsavel.Fone))
                        {


                            resultado = ((from r in resultado
                                          where
                                          r.Fone.Contains(responsavel.Fone)
                                          select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.FoneTrabalho))
                        {

                            resultado = ((from r in resultado
                                          where
                                          r.FoneTrabalho.Contains(responsavel.FoneTrabalho)
                                          select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.Login))
                        {

                            resultado = ((from r in resultado
                                          where
                                          r.Login.Contains(responsavel.Login)
                                          select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.Logradouro))
                        {

                            resultado = ((from r in resultado
                                          where
                                          r.Logradouro.Contains(responsavel.Logradouro)
                                          select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }


                        if (responsavel.Nascimento.HasValue && responsavel.Nascimento.Value != default(DateTime))
                        {

                            resultado = ((from r in resultado
                                          where
                                          r.Nascimento.HasValue && r.Nascimento.Value == responsavel.Nascimento
                                          select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }



                        if (!string.IsNullOrEmpty(responsavel.Nome))
                        {

                            resultado = ((from r in resultado
                                          where
                                          r.Nome.Contains(responsavel.Nome)
                                          select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }


                        if (responsavel.PerfilID!= null && responsavel.PerfilID != 0)
                        {

                            resultado = ((from r in resultado
                                          where
                                          r.PerfilID == responsavel.PerfilID
                                          select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.Senha))
                        {

                            resultado = ((from r in resultado
                                          where
                                          r.Senha.Contains(responsavel.Senha)
                                          select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (responsavel.Sexo.HasValue)
                        {

                            resultado = ((from r in resultado
                                          where
                                          r.Sexo.HasValue && r.Sexo.Value == responsavel.Sexo.Value
                                          select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.Uf))
                        {

                            resultado = ((from r in resultado
                                          where
                                          r.Uf.Contains(responsavel.Uf)
                                          select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.FoneOpcional))
                        {

                            resultado = ((from r in resultado
                                          where
                                          r.FoneOpcional.Contains(responsavel.FoneOpcional)
                                          select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (responsavel.Status.HasValue)
                        {

                            resultado = ((from r in resultado
                                          where
                                          r.Status.HasValue && r.Status.Value == responsavel.Status.Value
                                          select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        break;
                    }
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                        if (responsavel.ID != 0)
                        {


                            resultado.AddRange((from r in Consultar()
                                                where
                                                r.ID == responsavel.ID
                                                select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (responsavel.Nascimento.HasValue && responsavel.Nascimento.Value != default(DateTime))
                        {

                            resultado.AddRange((from r in Consultar()
                                                where
                                                r.Nascimento.HasValue && r.Nascimento.Value == responsavel.Nascimento.Value
                                                select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.LocalTrabalho))
                        {

                            resultado.AddRange((from r in Consultar()
                                                where
                                                r.LocalTrabalho.Contains(responsavel.LocalTrabalho)
                                                select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.Cpf))
                        {

                            resultado.AddRange((from r in Consultar()
                                                where
                                                r.Cpf.Contains(responsavel.Cpf)
                                                select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.Bairro))
                        {

                            resultado.AddRange((from r in Consultar()
                                                where
                                                r.Bairro.Contains(responsavel.Bairro)
                                                select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.Cep))
                        {

                            resultado.AddRange((from r in Consultar()
                                                where
                                                r.Cep.Contains(responsavel.Cep)
                                                select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.Cidade))
                        {

                            resultado.AddRange((from r in Consultar()
                                                where
                                                r.Cidade.Contains(responsavel.Cidade)
                                                select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.ComplementoEndereco))
                        {

                            resultado.AddRange((from r in Consultar()
                                                where
                                                r.ComplementoEndereco.Contains(responsavel.ComplementoEndereco)
                                                select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.Profissao))
                        {

                            resultado.AddRange((from r in Consultar()
                                                where
                                                r.Profissao.Contains(responsavel.Profissao)
                                                select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.Rg))
                        {

                            resultado.AddRange((from r in Consultar()
                                                where
                                                r.Rg.Contains(responsavel.Rg)
                                                select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }



                        if (!string.IsNullOrEmpty(responsavel.Email))
                        {

                            resultado.AddRange((from r in Consultar()
                                                where
                                                r.Email.Contains(responsavel.Email)
                                                select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }



                        if (!string.IsNullOrEmpty(responsavel.Fone))
                        {


                            resultado.AddRange((from r in Consultar()
                                                where
                                                r.Fone.Contains(responsavel.Fone)
                                                select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.FoneTrabalho))
                        {

                            resultado.AddRange((from r in Consultar()
                                                where
                                                r.FoneTrabalho.Contains(responsavel.FoneTrabalho)
                                                select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.Login))
                        {

                            resultado.AddRange((from r in Consultar()
                                                where
                                                r.Login.Contains(responsavel.Login)
                                                select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.Logradouro))
                        {

                            resultado.AddRange((from r in Consultar()
                                                where
                                                r.Logradouro.Contains(responsavel.Logradouro)
                                                select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }


                        if (responsavel.Nascimento.HasValue && responsavel.Nascimento.Value != default(DateTime))
                        {

                            resultado.AddRange((from r in Consultar()
                                                where
                                                r.Nascimento.HasValue && r.Nascimento.Value == responsavel.Nascimento
                                                select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }


                        if (!string.IsNullOrEmpty(responsavel.Nome))
                        {

                            resultado.AddRange((from r in Consultar()
                                                where
                                                r.Nome.Contains(responsavel.Nome)
                                                select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }


                        if (responsavel.PerfilID != 0)
                        {

                            resultado.AddRange((from r in Consultar()
                                                where
                                                r.PerfilID == responsavel.PerfilID
                                                select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.Senha))
                        {
                            resultado.AddRange((from r in Consultar()
                                                where
                                                r.Senha.Contains(responsavel.Senha)
                                                select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (responsavel.Sexo.HasValue)
                        {

                            resultado.AddRange((from r in Consultar()
                                                where
                                                r.Sexo.HasValue && r.Sexo.Value == responsavel.Sexo.Value
                                                select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.Uf))
                        {

                            resultado.AddRange((from r in Consultar()
                                                where
                                                r.Uf.Contains(responsavel.Uf)
                                                select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.FoneOpcional))
                        {

                            resultado.AddRange((from r in Consultar()
                                                where
                                                r.FoneOpcional.Contains(responsavel.FoneOpcional)
                                                select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (responsavel.Status.HasValue)
                        {

                            resultado.AddRange((from r in Consultar()
                                                where
                                                r.Status.HasValue && r.Status.Value == responsavel.Status.Value
                                                select r).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        break;
                    }
                #endregion

                default:
                    break;
            }

            return resultado;

        }

        public void Incluir(Responsavel responsavel)
        {
            try
            {
                db.Responsavel.InsertOnSubmit(responsavel);
            }
            catch (Exception)
            {

                throw new ResponsavelNaoIncluidoExcecao();
            }
        }

        public void Excluir(Responsavel responsavel)
        {
            try
            {
                Responsavel responsavelAux = new Responsavel();
                responsavelAux.ID = responsavel.ID;


                List<Responsavel> resultado = this.Consultar(responsavelAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new ResponsavelNaoExcluidoExcecao();

                responsavelAux = resultado[0];

                db.Responsavel.DeleteOnSubmit(responsavelAux);

            }
            catch (Exception)
            {

                throw new ResponsavelNaoExcluidoExcecao();
            }
        }

        public void Alterar(Responsavel responsavel)
        {
            try
            {
                Responsavel responsavelAux = new Responsavel();
                responsavelAux.ID = responsavel.ID;


                List<Responsavel> resultado = this.Consultar(responsavelAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new ResponsavelNaoAlteradoExcecao();

                responsavelAux = resultado[0];

                responsavelAux.Bairro = responsavel.Bairro;
                responsavelAux.Cep = responsavel.Cep;
                responsavelAux.Cidade = responsavel.Cidade;
                responsavelAux.ComplementoEndereco = responsavel.ComplementoEndereco;
                responsavelAux.Cpf = responsavel.Cpf;
                responsavelAux.Email = responsavel.Email;
                responsavelAux.Fone = responsavel.Fone;
                responsavelAux.FoneTrabalho = responsavel.FoneTrabalho;
                responsavelAux.Imagem = responsavel.Imagem;
                responsavelAux.LocalTrabalho = responsavel.LocalTrabalho;
                responsavelAux.Login = responsavel.Login;
                responsavelAux.Logradouro = responsavel.Logradouro;
                responsavelAux.Nascimento = responsavel.Nascimento;
                responsavelAux.Nome = responsavel.Nome;
                responsavelAux.PerfilID = responsavel.PerfilID;
                responsavelAux.Profissao = responsavel.Profissao;
                responsavelAux.Rg = responsavel.Rg;
                responsavelAux.Senha = responsavel.Senha;
                responsavelAux.Sexo = responsavel.Sexo;
                responsavelAux.Status = responsavel.Status;
                responsavelAux.Uf = responsavel.Uf;
                responsavelAux.FoneOpcional = responsavel.FoneOpcional;


                Confirmar();
            }
            catch (Exception)
            {

                throw new ResponsavelNaoAlteradoExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion

        #region Construtor
        public ResponsavelRepositorio()
        {
            Conexao conexao = new Conexao();
            db = new ColegioDB(new MySqlConnection(conexao.ToString()));

        }
        #endregion

    }
}