using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloAluno.Excecoes;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloBasico.VOs;

namespace Negocios.ModuloAluno.Repositorios
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        #region Atributos

        ColegioDB db;

        #endregion

        #region Métodos da Interface

        public List<Aluno> Consultar()
        {
            return db.Aluno.ToList();
        }

        public List<Aluno> Consultar(Aluno aluno, TipoPesquisa tipoPesquisa)
        {
            List<Aluno> resultado = Consultar();
          
            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (aluno.ID != 0)
                        {

                            resultado = ((from a in resultado
                                          where
                                          a.ID == aluno.ID
                                          select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (aluno.Nascimento.HasValue && aluno.Nascimento.Value != default(DateTime))
                        {

                            resultado = ((from a in resultado
                                          where
                                          a.Nascimento.HasValue && a.Nascimento.Value == aluno.Nascimento.Value
                                          select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Alergico))
                        {

                            resultado = ((from a in resultado
                                          where
                                          a.Alergico.Contains(aluno.Alergico)
                                          select a).ToList());


                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Bairro))
                        {


                            resultado = ((from a in resultado
                                          where
                                          a.Bairro.Contains(aluno.Bairro)
                                          select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Cep))
                        {

                            resultado = ((from a in resultado
                                          where
                                          a.Cep.Contains(aluno.Cep)
                                          select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Cidade))
                        {

                            resultado = ((from a in resultado
                                          where
                                          a.Cidade.Contains(aluno.Cidade)
                                          select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.ComplementoEndereco))
                        {

                            resultado = ((from a in resultado
                                          where
                                          a.ComplementoEndereco.Contains(aluno.ComplementoEndereco)
                                          select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }


                        if (!string.IsNullOrEmpty(aluno.DescricaoMedica))
                        {

                            resultado = ((from a in resultado
                                          where
                                          a.DescricaoMedica.Contains(aluno.DescricaoMedica)
                                          select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Email))
                        {

                            resultado = ((from a in resultado
                                          where
                                          a.Email.Contains(aluno.Email)
                                          select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (aluno.FatorRh.HasValue)
                        {

                            resultado = ((from a in resultado
                                          where
                                          a.FatorRh.HasValue && a.FatorRh.Value == aluno.FatorRh.Value
                                          select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.FoneAluno))
                        {

                            resultado = ((from a in resultado
                                          where
                                          a.FoneAluno.Contains(aluno.FoneAluno)
                                          select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.FoneEmergencia))
                        {

                            resultado = ((from a in resultado
                                          where
                                          a.FoneEmergencia.Contains(aluno.FoneEmergencia)
                                          select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.FoneMedico))
                        {

                            resultado = ((from a in resultado
                                          where
                                          a.FoneMedico.Contains(aluno.FoneMedico)
                                          select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.FoneResidencia))
                        {

                            resultado = ((from a in resultado
                                          where
                                          a.FoneResidencia.Contains(aluno.FoneResidencia)
                                          select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.GrupoSanguineo))
                        {

                            resultado = ((from a in resultado
                                          where
                                          a.GrupoSanguineo.Contains(aluno.GrupoSanguineo)
                                          select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Hospital))
                        {

                            resultado = ((from a in resultado
                                          where
                                          a.Hospital.Contains(aluno.Hospital)
                                          select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Login))
                        {

                            resultado = ((from a in resultado
                                          where
                                          a.Login.Contains(aluno.Login)
                                          select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Logradouro))
                        {


                            resultado = ((from a in resultado
                                          where
                                          a.Logradouro.Contains(aluno.Logradouro)
                                          select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Nacionalidade))
                        {

                            resultado = ((from a in resultado
                                          where
                                          a.Nacionalidade.Contains(aluno.Nacionalidade)
                                          select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (aluno.Nascimento.HasValue && aluno.Nascimento.Value != default(DateTime))
                        {

                            resultado = ((from a in resultado
                                          where
                                          a.Nascimento.HasValue && a.Nascimento.Value == aluno.Nascimento
                                          select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Naturalidade))
                        {


                            resultado = ((from a in resultado
                                          where
                                          a.Naturalidade.Contains(aluno.Naturalidade)
                                          select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Nome))
                        {

                            resultado = ((from a in resultado
                                          where
                                           a.Nome.ToUpper().Contains(aluno.Nome.ToUpper())
                                          select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.NomeMedico))
                        {

                            resultado = ((from a in resultado
                                          where
                                          a.NomeMedico.Contains(aluno.NomeMedico)
                                          select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (aluno.PerfilID != 0 && aluno.PerfilID != null)
                        {

                            resultado = ((from a in resultado
                                          where
                                          a.PerfilID == aluno.PerfilID
                                          select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }



                        if (!string.IsNullOrEmpty(aluno.PlanoSaude))
                        {

                            resultado = ((from a in resultado
                                          where
                                          a.PlanoSaude.Contains(aluno.PlanoSaude)
                                          select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Senha))
                        {

                            resultado = ((from a in resultado
                                          where
                                          a.Senha.Contains(aluno.Senha)
                                          select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (aluno.Sexo.HasValue)
                        {

                            resultado = ((from a in resultado
                                          where
                                          a.Sexo.HasValue && a.Sexo.Value == aluno.Sexo.Value
                                          select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.SituacaoEspecial))
                        {

                            resultado = ((from a in resultado
                                          where
                                          a.SituacaoEspecial.Contains(aluno.SituacaoEspecial)
                                          select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Uf))
                        {

                            resultado = ((from a in resultado
                                          where
                                          a.Uf.Contains(aluno.Uf)
                                          select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Contato))
                        {

                            resultado = ((from a in resultado
                                          where
                                          a.Contato.Contains(aluno.Contato)
                                          select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }


                        if (aluno.Status.HasValue)
                        {

                            resultado = ((from a in resultado
                                          where
                                          a.Status.HasValue && a.Status.Value == aluno.Status.Value
                                          select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        break;
                    }
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                        if (aluno.ID != 0)
                        {

                            resultado.AddRange((from a in Consultar()
                                                where
                                                a.ID == aluno.ID
                                                select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (aluno.Nascimento.HasValue && aluno.Nascimento.Value != default(DateTime))
                        {

                            resultado.AddRange((from a in Consultar()
                                                where
                                                a.Nascimento.HasValue && a.Nascimento.Value == aluno.Nascimento.Value
                                                select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Alergico))
                        {

                            resultado.AddRange((from a in Consultar()
                                                where
                                                a.Alergico.Contains(aluno.Alergico)
                                                select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Bairro))
                        {

                            resultado.AddRange((from a in Consultar()
                                                where
                                                a.Bairro.Contains(aluno.Bairro)
                                                select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Cep))
                        {

                            resultado.AddRange((from a in Consultar()
                                                where
                                                a.Cep.Contains(aluno.Cep)
                                                select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Cidade))
                        {

                            resultado.AddRange((from a in Consultar()
                                                where
                                                a.Cidade.Contains(aluno.Cidade)
                                                select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.ComplementoEndereco))
                        {

                            resultado.AddRange((from a in Consultar()
                                                where
                                                a.ComplementoEndereco.Contains(aluno.ComplementoEndereco)
                                                select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }



                        if (!string.IsNullOrEmpty(aluno.DescricaoMedica))
                        {

                            resultado.AddRange((from a in Consultar()
                                                where
                                                a.DescricaoMedica.Contains(aluno.DescricaoMedica)
                                                select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Email))
                        {

                            resultado.AddRange((from a in Consultar()
                                                where
                                                a.Email.Contains(aluno.Email)
                                                select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (aluno.FatorRh.HasValue)
                        {
                            resultado.AddRange((from a in Consultar()
                                                where
                                                a.FatorRh.HasValue && a.FatorRh.Value == aluno.FatorRh.Value
                                                select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.FoneAluno))
                        {

                            resultado.AddRange((from a in Consultar()
                                                where
                                                a.FoneAluno.Contains(aluno.FoneAluno)
                                                select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.FoneEmergencia))
                        {
                            resultado.AddRange((from a in Consultar()
                                                where
                                                a.FoneEmergencia.Contains(aluno.FoneEmergencia)
                                                select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.FoneMedico))
                        {

                            resultado.AddRange((from a in Consultar()
                                                where
                                                a.FoneMedico.Contains(aluno.FoneMedico)
                                                select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.FoneResidencia))
                        {

                            resultado.AddRange((from a in Consultar()
                                                where
                                                a.FoneResidencia.Contains(aluno.FoneResidencia)
                                                select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.GrupoSanguineo))
                        {

                            resultado.AddRange((from a in Consultar()
                                                where
                                                a.GrupoSanguineo.Contains(aluno.GrupoSanguineo)
                                                select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Hospital))
                        {

                            resultado.AddRange((from a in Consultar()
                                                where
                                                a.Hospital.Contains(aluno.Hospital)
                                                select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Login))
                        {

                            resultado.AddRange((from a in Consultar()
                                                where
                                                a.Login.Contains(aluno.Login)
                                                select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Logradouro))
                        {


                            resultado.AddRange((from a in Consultar()
                                                where
                                                a.Logradouro.Contains(aluno.Logradouro)
                                                select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Nacionalidade))
                        {

                            resultado.AddRange((from a in Consultar()
                                                where
                                                a.Nacionalidade.Contains(aluno.Nacionalidade)
                                                select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (aluno.Nascimento.HasValue && aluno.Nascimento.Value != default(DateTime))
                        {

                            resultado.AddRange((from a in Consultar()
                                                where
                                                a.Nascimento.HasValue && a.Nascimento.Value == aluno.Nascimento
                                                select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Naturalidade))
                        {

                            resultado.AddRange((from a in Consultar()
                                                where
                                                a.Naturalidade.Contains(aluno.Naturalidade)
                                                select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Nome))
                        {

                            resultado.AddRange((from a in Consultar()
                                                where
                                                a.Nome.ToUpper().Contains(aluno.Nome.ToUpper())
                                                select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.NomeMedico))
                        {

                            resultado.AddRange((from a in Consultar()
                                                where
                                                a.NomeMedico.Contains(aluno.NomeMedico)
                                                select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (aluno.PerfilID != 0 && aluno.PerfilID != null)
                        {

                            resultado.AddRange((from a in Consultar()
                                                where
                                                a.PerfilID == aluno.PerfilID
                                                select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.PlanoSaude))
                        {

                            resultado.AddRange((from a in Consultar()
                                                where
                                                a.PlanoSaude.Contains(aluno.PlanoSaude)
                                                select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Senha))
                        {

                            resultado.AddRange((from a in Consultar()
                                                where
                                                a.Senha.Contains(aluno.Senha)
                                                select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (aluno.Sexo.HasValue)
                        {

                            resultado.AddRange((from a in Consultar()
                                                where
                                                a.Sexo.HasValue && a.Sexo.Value == aluno.Sexo.Value
                                                select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.SituacaoEspecial))
                        {

                            resultado.AddRange((from a in Consultar()
                                                where
                                                a.SituacaoEspecial.Contains(aluno.SituacaoEspecial)
                                                select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Uf))
                        {

                            resultado.AddRange((from a in Consultar()
                                                where
                                                a.Uf.Contains(aluno.Uf)
                                                select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Contato))
                        {

                            resultado.AddRange((from a in Consultar()
                                                where
                                                a.Contato.Contains(aluno.Contato)
                                                select a).ToList());

                            resultado = resultado.Distinct().ToList();
                        }


                        if (aluno.Status.HasValue)
                        {

                            resultado.AddRange((from a in Consultar()
                                                where
                                                a.Status.HasValue && a.Status.Value == aluno.Status.Value
                                                select a).ToList());

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

        public void Incluir(Aluno aluno)
        {
            try
            {
                db.Aluno.InsertOnSubmit(aluno);
            }
            catch (Exception)
            {

                throw new AlunoNaoIncluidoExcecao();
            }
        }

        public void Excluir(Aluno aluno)
        {
            try
            {
                Aluno alunoAux = new Aluno();
                alunoAux.ID = aluno.ID;


                List<Aluno> resultado = this.Consultar(alunoAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new AlunoNaoExcluidoExcecao();

                alunoAux = resultado[0];

                db.Aluno.DeleteOnSubmit(alunoAux);

            }
            catch (Exception)
            {

                throw new AlunoNaoExcluidoExcecao();
            }
        }

        public void Alterar(Aluno aluno)
        {
            try
            {
                Aluno alunoAux = new Aluno();
                alunoAux.ID = aluno.ID;


                List<Aluno> resultado = this.Consultar(alunoAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new AlunoNaoAlteradoExcecao();

                alunoAux = resultado[0];
                alunoAux.Alergico = aluno.Alergico;
                alunoAux.Bairro = aluno.Bairro;
                alunoAux.Cep = aluno.Cep;
                alunoAux.Cidade = aluno.Cidade;
                alunoAux.ComplementoEndereco = aluno.ComplementoEndereco;
                alunoAux.Contato = aluno.Contato;

                alunoAux.DescricaoMedica = aluno.DescricaoMedica;
                alunoAux.Email = aluno.Email;
                alunoAux.FatorRh = aluno.FatorRh;
                alunoAux.FoneAluno = aluno.FoneAluno;
                alunoAux.FoneEmergencia = aluno.FoneEmergencia;
                alunoAux.FoneMedico = aluno.FoneMedico;
                alunoAux.FoneResidencia = aluno.FoneResidencia;
                alunoAux.GrupoSanguineo = aluno.GrupoSanguineo;
                alunoAux.Hospital = aluno.Hospital;
                alunoAux.Imagem = aluno.Imagem;
                alunoAux.Login = aluno.Login;
                alunoAux.Logradouro = aluno.Logradouro;
                alunoAux.Nacionalidade = aluno.Nacionalidade;
                alunoAux.Nascimento = aluno.Nascimento;
                alunoAux.Naturalidade = aluno.Naturalidade;
                alunoAux.Nome = aluno.Nome;
                alunoAux.NomeMedico = aluno.NomeMedico;
                alunoAux.PerfilID = aluno.PerfilID;
                alunoAux.PlanoSaude = aluno.PlanoSaude;
                alunoAux.Senha = aluno.Senha;
                alunoAux.Sexo = aluno.Sexo;
                alunoAux.SituacaoEspecial = aluno.SituacaoEspecial;
                alunoAux.Status = aluno.Status;
                alunoAux.Uf = aluno.Uf;
                alunoAux.SerieAtual = aluno.SerieAtual;
                alunoAux.Edificio = aluno.Edificio;

                Confirmar();
            }
            catch (Exception)
            {

                throw new AlunoNaoAlteradoExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion

        #region Construtor
        public AlunoRepositorio()
        {
            Conexao conexao = new Conexao();
            db = new ColegioDB(new MySqlConnection(conexao.ToString()));

        }
        #endregion


    }
}