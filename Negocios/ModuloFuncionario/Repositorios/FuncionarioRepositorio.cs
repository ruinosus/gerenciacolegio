using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloFuncionario.Excecoes;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloFuncionario.Repositorios
{
    public class FuncionarioRepositorio: IFuncionarioRepositorio
    {
		#region Atributos
		
        ColegioDB db = new ColegioDB(new MySqlConnection(BasicoConstantes.CONEXAO));
		
		#endregion      
		
        #region M�todos da Interface

        public List<Funcionario> Consultar()
        {
            return db.Funcionario.ToList();
        }

        public List<Funcionario> Consultar(Funcionario funcionario, TipoPesquisa tipoPesquisa)
        {
            List<Funcionario> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (funcionario.ID != 0)
                        {
                            resultado.AddRange((from f in resultado
                                                where
                                                f.ID == funcionario.ID
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (funcionario.DataEfetivacao.HasValue && funcionario.DataEfetivacao.Value != default(DateTime))
                        {
                            resultado.AddRange((from f in resultado
                                                where
                                                f.DataEfetivacao.HasValue && f.DataEfetivacao.Value == funcionario.DataEfetivacao.Value
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(funcionario.Alergico))
                        {
                            resultado.AddRange((from f in resultado
                                                where
                                                f.Alergico.Contains(funcionario.Alergico)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(funcionario.Bairro))
                        {
                            resultado.AddRange((from f in resultado
                                                where
                                                f.Bairro.Contains(funcionario.Bairro)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(funcionario.Cep))
                        {
                            resultado.AddRange((from f in resultado
                                                where
                                                f.Cep.Contains(funcionario.Cep)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(funcionario.Cidade))
                        {
                            resultado.AddRange((from f in resultado
                                                where
                                                f.Cidade.Contains(funcionario.Cidade)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(funcionario.ComplementoEndereco))
                        {
                            resultado.AddRange((from f in resultado
                                                where
                                                f.ComplementoEndereco.Contains(funcionario.ComplementoEndereco)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(funcionario.Cargo))
                        {
                            resultado.AddRange((from f in resultado
                                                where
                                                f.Cargo.Contains(funcionario.Cargo)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(funcionario.ContatoEmergencia))
                        {
                            resultado.AddRange((from f in resultado
                                                where
                                                f.ContatoEmergencia.Contains(funcionario.ContatoEmergencia)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }



                        if (!string.IsNullOrEmpty(funcionario.Email))
                        {
                            resultado.AddRange((from f in resultado
                                                where
                                                f.Email.Contains(funcionario.Email)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }



                        if (!string.IsNullOrEmpty(funcionario.FoneEmergencia))
                        {
                            resultado.AddRange((from f in resultado
                                                where
                                                f.FoneEmergencia.Contains(funcionario.FoneEmergencia)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(funcionario.Ctps))
                        {
                            resultado.AddRange((from f in resultado
                                                where
                                                f.Ctps.Contains(funcionario.Ctps)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(funcionario.Login))
                        {
                            resultado.AddRange((from f in resultado
                                                where
                                                f.Login.Contains(funcionario.Login)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(funcionario.Logradouro))
                        {
                            resultado.AddRange((from f in resultado
                                                where
                                                f.Logradouro.Contains(funcionario.Logradouro)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        //if (!string.IsNullOrEmpty(funcionario.Nacionalidade))
                        //{
                        //    resultado.AddRange((from f in resultado
                        //                        where
                        //                        f.Nacionalidade.Contains(funcionario.Nacionalidade)
                        //                        select f).ToList());
                        //    resultado = resultado.Distinct().ToList();
                        //}

                        if (funcionario.Nascimento.HasValue && funcionario.Nascimento.Value != default(DateTime))
                        {
                            resultado.AddRange((from f in resultado
                                                where
                                                f.Nascimento.HasValue && f.Nascimento.Value == funcionario.Nascimento
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(funcionario.Naturalidade))
                        {
                            resultado.AddRange((from f in resultado
                                                where
                                                f.Naturalidade.Contains(funcionario.Naturalidade)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(funcionario.Nome))
                        {
                            resultado.AddRange((from f in resultado
                                                where
                                                f.Nome.Contains(funcionario.Nome)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }


                        if (funcionario.PerfilID != 0)
                        {
                            resultado.AddRange((from f in resultado
                                                where
                                                f.PerfilID == funcionario.PerfilID
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(funcionario.Senha))
                        {
                            resultado.AddRange((from f in resultado
                                                where
                                                f.Senha.Contains(funcionario.Senha)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (funcionario.Sexo.HasValue)
                        {
                            resultado.AddRange((from f in resultado
                                                where
                                                f.Sexo.HasValue && f.Sexo.Value == funcionario.Sexo.Value
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(funcionario.Uf))
                        {
                            resultado.AddRange((from f in resultado
                                                where
                                                f.Uf.Contains(funcionario.Uf)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(funcionario.Serie))
                        {
                            resultado.AddRange((from f in resultado
                                                where
                                                f.Serie.Contains(funcionario.Serie)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(funcionario.Pis))
                        {
                            resultado.AddRange((from f in resultado
                                                where
                                                f.Pis.Contains(funcionario.Pis)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(funcionario.Filiacao))
                        {
                            resultado.AddRange((from f in resultado
                                                where
                                                f.Filiacao.Contains(funcionario.Filiacao)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(funcionario.Emisor))
                        {
                            resultado.AddRange((from f in resultado
                                                where
                                                f.Emisor.Contains(funcionario.Emisor)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(funcionario.Cpf))
                        {
                            resultado.AddRange((from f in resultado
                                                where
                                                f.Cpf.Contains(funcionario.Cpf)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (funcionario.Status.HasValue)
                        {
                            resultado.AddRange((from f in resultado
                                                where
                                                f.Status.HasValue && f.Status.Value == funcionario.Status.Value
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        break;
                    }
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                        if (funcionario.ID != 0)
                        {
                            resultado.AddRange((from f in Consultar()
                                                where
                                                f.ID == funcionario.ID
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (funcionario.DataEfetivacao.HasValue && funcionario.DataEfetivacao.Value != default(DateTime))
                        {
                            resultado.AddRange((from f in Consultar()
                                                where
                                                f.DataEfetivacao.HasValue && f.DataEfetivacao.Value == funcionario.DataEfetivacao.Value
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(funcionario.Alergico))
                        {
                            resultado.AddRange((from f in Consultar()
                                                where
                                                f.Alergico.Contains(funcionario.Alergico)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(funcionario.Bairro))
                        {
                            resultado.AddRange((from f in Consultar()
                                                where
                                                f.Bairro.Contains(funcionario.Bairro)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(funcionario.Cep))
                        {
                            resultado.AddRange((from f in Consultar()
                                                where
                                                f.Cep.Contains(funcionario.Cep)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(funcionario.Cidade))
                        {
                            resultado.AddRange((from f in Consultar()
                                                where
                                                f.Cidade.Contains(funcionario.Cidade)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(funcionario.ComplementoEndereco))
                        {
                            resultado.AddRange((from f in Consultar()
                                                where
                                                f.ComplementoEndereco.Contains(funcionario.ComplementoEndereco)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(funcionario.Cargo))
                        {
                            resultado.AddRange((from f in Consultar()
                                                where
                                                f.Cargo.Contains(funcionario.Cargo)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(funcionario.ContatoEmergencia))
                        {
                            resultado.AddRange((from f in Consultar()
                                                where
                                                f.ContatoEmergencia.Contains(funcionario.ContatoEmergencia)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }



                        if (!string.IsNullOrEmpty(funcionario.Email))
                        {
                            resultado.AddRange((from f in Consultar()
                                                where
                                                f.Email.Contains(funcionario.Email)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }



                        if (!string.IsNullOrEmpty(funcionario.FoneEmergencia))
                        {
                            resultado.AddRange((from f in Consultar()
                                                where
                                                f.FoneEmergencia.Contains(funcionario.FoneEmergencia)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(funcionario.Ctps))
                        {
                            resultado.AddRange((from f in Consultar()
                                                where
                                                f.Ctps.Contains(funcionario.Ctps)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(funcionario.Login))
                        {
                            resultado.AddRange((from f in Consultar()
                                                where
                                                f.Login.Contains(funcionario.Login)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(funcionario.Logradouro))
                        {
                            resultado.AddRange((from f in Consultar()
                                                where
                                                f.Logradouro.Contains(funcionario.Logradouro)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        //if (!string.IsNullOrEmpty(funcionario.Nacionalidade))
                        //{
                        //    resultado.AddRange((from f in Consultar()
                        //                        where
                        //                        f.Nacionalidade.Contains(funcionario.Nacionalidade)
                        //                        select f).ToList());
                        //    resultado = resultado.Distinct().ToList();
                        //}

                        if (funcionario.Nascimento.HasValue && funcionario.Nascimento.Value != default(DateTime))
                        {
                            resultado.AddRange((from f in Consultar()
                                                where
                                                f.Nascimento.HasValue && f.Nascimento.Value == funcionario.Nascimento
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(funcionario.Naturalidade))
                        {
                            resultado.AddRange((from f in Consultar()
                                                where
                                                f.Naturalidade.Contains(funcionario.Naturalidade)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(funcionario.Nome))
                        {
                            resultado.AddRange((from f in Consultar()
                                                where
                                                f.Nome.Contains(funcionario.Nome)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }


                        if (funcionario.PerfilID != 0)
                        {
                            resultado.AddRange((from f in Consultar()
                                                where
                                                f.PerfilID == funcionario.PerfilID
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(funcionario.Senha))
                        {
                            resultado.AddRange((from f in Consultar()
                                                where
                                                f.Senha.Contains(funcionario.Senha)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (funcionario.Sexo.HasValue)
                        {
                            resultado.AddRange((from f in Consultar()
                                                where
                                                f.Sexo.HasValue && f.Sexo.Value == funcionario.Sexo.Value
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(funcionario.Uf))
                        {
                            resultado.AddRange((from f in Consultar()
                                                where
                                                f.Uf.Contains(funcionario.Uf)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(funcionario.Serie))
                        {
                            resultado.AddRange((from f in Consultar()
                                                where
                                                f.Serie.Contains(funcionario.Serie)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(funcionario.Pis))
                        {
                            resultado.AddRange((from f in Consultar()
                                                where
                                                f.Pis.Contains(funcionario.Pis)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(funcionario.Filiacao))
                        {
                            resultado.AddRange((from f in Consultar()
                                                where
                                                f.Filiacao.Contains(funcionario.Filiacao)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(funcionario.Emisor))
                        {
                            resultado.AddRange((from f in Consultar()
                                                where
                                                f.Emisor.Contains(funcionario.Emisor)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(funcionario.Cpf))
                        {
                            resultado.AddRange((from f in Consultar()
                                                where
                                                f.Cpf.Contains(funcionario.Cpf)
                                                select f).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (funcionario.Status.HasValue)
                        {
                            resultado.AddRange((from f in Consultar()
                                                where
                                                f.Status.HasValue && f.Status.Value == funcionario.Status.Value
                                                select f).ToList());
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

        public void Incluir(Funcionario funcionario)
        {
            try
            {
                db.Funcionario.InsertOnSubmit(funcionario);
            }
            catch (Exception)
            {
                
                throw new FuncionarioNaoIncluidoExcecao();
            }
        }

        public void Excluir(Funcionario funcionario)
        {
            try
            {
                Funcionario funcionarioAux = new Funcionario();
                funcionarioAux.ID = funcionario.ID;


                List<Funcionario> resultado = this.Consultar(funcionarioAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new FuncionarioNaoExcluidoExcecao();

                funcionarioAux = resultado[0];

                db.Funcionario.DeleteOnSubmit(funcionarioAux);
            
            }
            catch (Exception)
            {
                
             throw new FuncionarioNaoExcluidoExcecao();
            }
        }

        public void Alterar(Funcionario funcionario)
        {
            try
            {
                Funcionario funcionarioAux = new Funcionario();
                funcionarioAux.ID = funcionario.ID;


                List<Funcionario> resultado = this.Consultar(funcionarioAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new FuncionarioNaoAlteradoExcecao();

                funcionarioAux = resultado[0];

                funcionarioAux.Alergico = funcionario.Alergico;
                funcionarioAux.Bairro = funcionario.Bairro;
                funcionarioAux.Cargo= funcionario.Cargo;
                funcionarioAux.Cep = funcionario.Cep;
                funcionarioAux.Cidade = funcionario.Cidade;
                funcionarioAux.ComplementoEndereco= funcionario.ComplementoEndereco;
                funcionarioAux.ContatoEmergencia= funcionario.ContatoEmergencia;
                funcionarioAux.Cpf= funcionario.Cpf;
                funcionarioAux.Ctps= funcionario.Ctps;
                funcionarioAux.DataEfetivacao= funcionario.DataEfetivacao;
                funcionarioAux.Email= funcionario.Email;
                funcionarioAux.Emisor = funcionario.Emisor;
                funcionarioAux.Filiacao = funcionario.Filiacao;
                funcionarioAux.FoneEmergencia = funcionario.FoneEmergencia;
                funcionarioAux.Imagem= funcionario.Imagem;
                funcionarioAux.Login= funcionario.Login;
                funcionarioAux.Logradouro= funcionario.Logradouro;
                funcionarioAux.Nascimento = funcionario.Nascimento;
                funcionarioAux.Naturalidade = funcionario.Naturalidade;
                funcionarioAux.Nome = funcionario.Nome;
                funcionarioAux.PerfilID= funcionario.PerfilID;
                funcionarioAux.Pis= funcionario.Pis;
                funcionarioAux.Senha = funcionario.Senha;
                funcionarioAux.Serie = funcionario.Serie;
                funcionarioAux.Sexo = funcionario.Sexo;
                funcionarioAux.Status = funcionario.Status;
                funcionarioAux.Uf = funcionario.Uf;

                Confirmar();
            }
            catch (Exception)
            {
                
               throw new FuncionarioNaoAlteradoExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion      
 

    }
}