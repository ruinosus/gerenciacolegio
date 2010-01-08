using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloResponsavel.Excecoes;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloResponsavel.Repositorios
{
    public class ResponsavelRepositorio : IResponsavelRepositorio
    {
        #region Atributos

        ColegioDB db = new ColegioDB(new MySqlConnection(BasicoConstantes.CONEXAO));

        #endregion

        #region Métodos da Interface

        public List<Responsavel> Consultar()
        {
            return db.Responsavel.ToList();
        }

        public List<Responsavel> Consultar(Responsavel responsavel, TipoPesquisa tipoPesquisa)
        {

            List<Responsavel> resultado = Consultar();
            bool pesquisa = false;
            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (responsavel.ID != 0)
                        {
                            if (pesquisa)
                            {

                                resultado.AddRange((from r in resultado
                                                    where
                                                    r.ID == responsavel.ID
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado=((from r in resultado
                                                    where
                                                    r.ID == responsavel.ID
                                                    select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (responsavel.Nascimento.HasValue && responsavel.Nascimento.Value != default(DateTime))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from r in resultado
                                                    where
                                                    r.Nascimento.HasValue && r.Nascimento.Value == responsavel.Nascimento.Value
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado =((from r in resultado
                                                    where
                                                    r.Nascimento.HasValue && r.Nascimento.Value == responsavel.Nascimento.Value
                                                    select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.LocalTrabalho))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from r in resultado
                                                    where
                                                    r.LocalTrabalho.Contains(responsavel.LocalTrabalho)
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado =((from r in resultado
                                                    where
                                                    r.LocalTrabalho.Contains(responsavel.LocalTrabalho)
                                                    select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.Cpf))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from r in resultado
                                                    where
                                                    r.Cpf.Contains(responsavel.Cpf)
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado =((from r in resultado
                                                    where
                                                    r.Cpf.Contains(responsavel.Cpf)
                                                    select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.Bairro))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from r in resultado
                                                    where
                                                    r.Bairro.Contains(responsavel.Bairro)
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado = ((from r in resultado
                                                    where
                                                    r.Bairro.Contains(responsavel.Bairro)
                                                    select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.Cep))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from r in resultado
                                                    where
                                                    r.Cep.Contains(responsavel.Cep)
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado =((from r in resultado
                                                    where
                                                    r.Cep.Contains(responsavel.Cep)
                                                    select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.Cidade))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from r in resultado
                                                    where
                                                    r.Cidade.Contains(responsavel.Cidade)
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado =((from r in resultado
                                                    where
                                                    r.Cidade.Contains(responsavel.Cidade)
                                                    select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.ComplementoEndereco))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from r in resultado
                                                    where
                                                    r.ComplementoEndereco.Contains(responsavel.ComplementoEndereco)
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado =((from r in resultado
                                                    where
                                                    r.ComplementoEndereco.Contains(responsavel.ComplementoEndereco)
                                                    select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.Profissao))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from r in resultado
                                                    where
                                                    r.Profissao.Contains(responsavel.Profissao)
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado = ((from r in resultado
                                                    where
                                                    r.Profissao.Contains(responsavel.Profissao)
                                                    select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.Rg))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from r in resultado
                                                    where
                                                    r.Rg.Contains(responsavel.Rg)
                                                    select r).ToList());
                            }
                            else {

                                resultado =((from r in resultado
                                                    where
                                                    r.Rg.Contains(responsavel.Rg)
                                                    select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        

                        if (!string.IsNullOrEmpty(responsavel.Email))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from r in resultado
                                                    where
                                                    r.Email.Contains(responsavel.Email)
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado =((from r in resultado
                                                    where
                                                    r.Email.Contains(responsavel.Email)
                                                    select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        

                        if (!string.IsNullOrEmpty(responsavel.Fone))
                        {

                            if (pesquisa)
                            {
                                resultado.AddRange((from r in resultado
                                                    where
                                                    r.Fone.Contains(responsavel.Fone)
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado =((from r in resultado
                                                    where
                                                    r.Fone.Contains(responsavel.Fone)
                                                    select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.FoneTrabalho))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from r in resultado
                                                    where
                                                    r.FoneTrabalho.Contains(responsavel.FoneTrabalho)
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado =((from r in resultado
                                                    where
                                                    r.FoneTrabalho.Contains(responsavel.FoneTrabalho)
                                                    select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.Login))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from r in resultado
                                                    where
                                                    r.Login.Contains(responsavel.Login)
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado =((from r in resultado
                                                    where
                                                    r.Login.Contains(responsavel.Login)
                                                    select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.Logradouro))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from r in resultado
                                                    where
                                                    r.Logradouro.Contains(responsavel.Logradouro)
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado=((from r in resultado
                                                    where
                                                    r.Logradouro.Contains(responsavel.Logradouro)
                                                    select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        //if (!string.IsNullOrEmpty(responsavel.Nacionalidade))
                        //{
                        //    resultado.AddRange((from r in resultado
                        //                        where
                        //                        r.Nacionalidade.Contains(responsavel.Nacionalidade)
                        //                        select r).ToList());
                        //    resultado = resultado.Distinct().ToList();
                        //}

                        if (responsavel.Nascimento.HasValue && responsavel.Nascimento.Value != default(DateTime))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from r in resultado
                                                    where
                                                    r.Nascimento.HasValue && r.Nascimento.Value == responsavel.Nascimento
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado =((from r in resultado
                                                    where
                                                    r.Nascimento.HasValue && r.Nascimento.Value == responsavel.Nascimento
                                                    select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        //if (!string.IsNullOrEmpty(responsavel.Naturalidade))
                        //{
                        //    resultado.AddRange((from r in resultado
                        //                        where
                        //                        r.Naturalidade.Contains(responsavel.Naturalidade)
                        //                        select r).ToList());
                        //    resultado = resultado.Distinct().ToList();
                        //}

                        if (!string.IsNullOrEmpty(responsavel.Nome))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from r in resultado
                                                    where
                                                    r.Nome.Contains(responsavel.Nome)
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado =((from r in resultado
                                                    where
                                                    r.Nome.Contains(responsavel.Nome)
                                                    select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        
                        if (responsavel.PerfilID != 0)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from r in resultado
                                                    where
                                                    r.PerfilID == responsavel.PerfilID
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado =((from r in resultado
                                                    where
                                                    r.PerfilID == responsavel.PerfilID
                                                    select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                       if (!string.IsNullOrEmpty(responsavel.Senha))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from r in resultado
                                                    where
                                                    r.Senha.Contains(responsavel.Senha)
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado =((from r in resultado
                                                    where
                                                    r.Senha.Contains(responsavel.Senha)
                                                    select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (responsavel.Sexo.HasValue)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from r in resultado
                                                    where
                                                    r.Sexo.HasValue && r.Sexo.Value == responsavel.Sexo.Value
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado =((from r in resultado
                                                    where
                                                    r.Sexo.HasValue && r.Sexo.Value == responsavel.Sexo.Value
                                                    select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.Uf))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from r in resultado
                                                    where
                                                    r.Uf.Contains(responsavel.Uf)
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado =((from r in resultado
                                                    where
                                                    r.Uf.Contains(responsavel.Uf)
                                                    select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (responsavel.Status.HasValue)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from r in resultado
                                                    where
                                                    r.Status.HasValue && r.Status.Value == responsavel.Status.Value
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado =((from r in resultado
                                                    where
                                                    r.Status.HasValue && r.Status.Value == responsavel.Status.Value
                                                    select r).ToList());
                            }
                            pesquisa = true;
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
                            if (pesquisa)
                            {

                                resultado.AddRange((from r in Consultar()
                                                    where
                                                    r.ID == responsavel.ID
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado = ((from r in Consultar()
                                              where
                                              r.ID == responsavel.ID
                                              select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (responsavel.Nascimento.HasValue && responsavel.Nascimento.Value != default(DateTime))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from r in Consultar()
                                                    where
                                                    r.Nascimento.HasValue && r.Nascimento.Value == responsavel.Nascimento.Value
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado = ((from r in Consultar()
                                              where
                                              r.Nascimento.HasValue && r.Nascimento.Value == responsavel.Nascimento.Value
                                              select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.LocalTrabalho))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from r in Consultar()
                                                    where
                                                    r.LocalTrabalho.Contains(responsavel.LocalTrabalho)
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado = ((from r in Consultar()
                                              where
                                              r.LocalTrabalho.Contains(responsavel.LocalTrabalho)
                                              select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.Cpf))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from r in Consultar()
                                                    where
                                                    r.Cpf.Contains(responsavel.Cpf)
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado = ((from r in Consultar()
                                              where
                                              r.Cpf.Contains(responsavel.Cpf)
                                              select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.Bairro))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from r in Consultar()
                                                    where
                                                    r.Bairro.Contains(responsavel.Bairro)
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado = ((from r in Consultar()
                                              where
                                              r.Bairro.Contains(responsavel.Bairro)
                                              select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.Cep))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from r in Consultar()
                                                    where
                                                    r.Cep.Contains(responsavel.Cep)
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado = ((from r in Consultar()
                                              where
                                              r.Cep.Contains(responsavel.Cep)
                                              select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.Cidade))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from r in Consultar()
                                                    where
                                                    r.Cidade.Contains(responsavel.Cidade)
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado = ((from r in Consultar()
                                              where
                                              r.Cidade.Contains(responsavel.Cidade)
                                              select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.ComplementoEndereco))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from r in Consultar()
                                                    where
                                                    r.ComplementoEndereco.Contains(responsavel.ComplementoEndereco)
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado = ((from r in Consultar()
                                              where
                                              r.ComplementoEndereco.Contains(responsavel.ComplementoEndereco)
                                              select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.Profissao))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from r in Consultar()
                                                    where
                                                    r.Profissao.Contains(responsavel.Profissao)
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado = ((from r in Consultar()
                                              where
                                              r.Profissao.Contains(responsavel.Profissao)
                                              select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.Rg))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from r in Consultar()
                                                    where
                                                    r.Rg.Contains(responsavel.Rg)
                                                    select r).ToList());
                            }
                            else
                            {

                                resultado = ((from r in Consultar()
                                              where
                                              r.Rg.Contains(responsavel.Rg)
                                              select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }



                        if (!string.IsNullOrEmpty(responsavel.Email))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from r in Consultar()
                                                    where
                                                    r.Email.Contains(responsavel.Email)
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado = ((from r in Consultar()
                                              where
                                              r.Email.Contains(responsavel.Email)
                                              select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }



                        if (!string.IsNullOrEmpty(responsavel.Fone))
                        {

                            if (pesquisa)
                            {
                                resultado.AddRange((from r in Consultar()
                                                    where
                                                    r.Fone.Contains(responsavel.Fone)
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado = ((from r in Consultar()
                                              where
                                              r.Fone.Contains(responsavel.Fone)
                                              select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.FoneTrabalho))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from r in Consultar()
                                                    where
                                                    r.FoneTrabalho.Contains(responsavel.FoneTrabalho)
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado = ((from r in Consultar()
                                              where
                                              r.FoneTrabalho.Contains(responsavel.FoneTrabalho)
                                              select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.Login))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from r in Consultar()
                                                    where
                                                    r.Login.Contains(responsavel.Login)
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado = ((from r in Consultar()
                                              where
                                              r.Login.Contains(responsavel.Login)
                                              select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.Logradouro))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from r in Consultar()
                                                    where
                                                    r.Logradouro.Contains(responsavel.Logradouro)
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado = ((from r in Consultar()
                                              where
                                              r.Logradouro.Contains(responsavel.Logradouro)
                                              select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        //if (!string.IsNullOrEmpty(responsavel.Nacionalidade))
                        //{
                        //    resultado.AddRange((from r in Consultar()
                        //                        where
                        //                        r.Nacionalidade.Contains(responsavel.Nacionalidade)
                        //                        select r).ToList());
                        //    resultado = resultado.Distinct().ToList();
                        //}

                        if (responsavel.Nascimento.HasValue && responsavel.Nascimento.Value != default(DateTime))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from r in Consultar()
                                                    where
                                                    r.Nascimento.HasValue && r.Nascimento.Value == responsavel.Nascimento
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado = ((from r in Consultar()
                                              where
                                              r.Nascimento.HasValue && r.Nascimento.Value == responsavel.Nascimento
                                              select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        //if (!string.IsNullOrEmpty(responsavel.Naturalidade))
                        //{
                        //    resultado.AddRange((from r in Consultar()
                        //                        where
                        //                        r.Naturalidade.Contains(responsavel.Naturalidade)
                        //                        select r).ToList());
                        //    resultado = resultado.Distinct().ToList();
                        //}

                        if (!string.IsNullOrEmpty(responsavel.Nome))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from r in Consultar()
                                                    where
                                                    r.Nome.Contains(responsavel.Nome)
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado = ((from r in Consultar()
                                              where
                                              r.Nome.Contains(responsavel.Nome)
                                              select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }


                        if (responsavel.PerfilID != 0)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from r in Consultar()
                                                    where
                                                    r.PerfilID == responsavel.PerfilID
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado = ((from r in Consultar()
                                              where
                                              r.PerfilID == responsavel.PerfilID
                                              select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.Senha))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from r in Consultar()
                                                    where
                                                    r.Senha.Contains(responsavel.Senha)
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado = ((from r in Consultar()
                                              where
                                              r.Senha.Contains(responsavel.Senha)
                                              select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (responsavel.Sexo.HasValue)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from r in Consultar()
                                                    where
                                                    r.Sexo.HasValue && r.Sexo.Value == responsavel.Sexo.Value
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado = ((from r in Consultar()
                                              where
                                              r.Sexo.HasValue && r.Sexo.Value == responsavel.Sexo.Value
                                              select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(responsavel.Uf))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from r in Consultar()
                                                    where
                                                    r.Uf.Contains(responsavel.Uf)
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado = ((from r in Consultar()
                                              where
                                              r.Uf.Contains(responsavel.Uf)
                                              select r).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (responsavel.Status.HasValue)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from r in Consultar()
                                                    where
                                                    r.Status.HasValue && r.Status.Value == responsavel.Status.Value
                                                    select r).ToList());
                            }
                            else
                            {
                                resultado = ((from r in Consultar()
                                              where
                                              r.Status.HasValue && r.Status.Value == responsavel.Status.Value
                                              select r).ToList());
                            }
                            pesquisa = true;
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
                responsavelAux.Profissao= responsavel.Profissao;
                responsavelAux.Rg = responsavel.Rg;
                responsavelAux.Senha = responsavel.Senha;
                responsavelAux.Sexo = responsavel.Sexo;
                responsavelAux.Status= responsavel.Status;
                responsavelAux.Uf = responsavel.Uf;


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


    }
}