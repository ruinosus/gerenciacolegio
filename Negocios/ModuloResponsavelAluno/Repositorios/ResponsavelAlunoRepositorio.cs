using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloResponsavelAluno.Excecoes;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloBasico.VOs;

namespace Negocios.ModuloResponsavelAluno.Repositorios
{
    public class ResponsavelAlunoRepositorio : IResponsavelAlunoRepositorio
    {
        #region Atributos

        ColegioDB db;

        #endregion

        #region Métodos da Interface

        public List<ResponsavelAluno> Consultar()
        {
            return db.ResponsavelAluno.ToList();
        }

        public List<ResponsavelAluno> Consultar(ResponsavelAluno responsavelAluno, TipoPesquisa tipoPesquisa)
        {
            List<ResponsavelAluno> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (responsavelAluno.ID != 0)
                        {

                            resultado = ((from ra in resultado
                                          where
                                          ra.ID == responsavelAluno.ID
                                          select ra).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (responsavelAluno.AlunoID != 0)
                        {

                            resultado = ((from ra in resultado
                                          where
                                          ra.AlunoID == responsavelAluno.AlunoID
                                          select ra).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (responsavelAluno.Aluno != null && !string.IsNullOrEmpty(responsavelAluno.Aluno.Nome))
                        {

                            resultado = ((from ra in resultado
                                          where
                                          ra.Aluno.Nome.Contains(responsavelAluno.Aluno.Nome)
                                          select ra).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (responsavelAluno.Responsavel != null && !string.IsNullOrEmpty(responsavelAluno.Responsavel.Nome))
                        {

                            resultado = ((from ra in resultado
                                          where
                                          ra.Responsavel.Nome.Contains(responsavelAluno.Responsavel.Nome)
                                          select ra).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (responsavelAluno.ResponsavelID != 0)
                        {

                            resultado = ((from ra in resultado
                                          where
                                          ra.ResponsavelID == responsavelAluno.ResponsavelID
                                          select ra).ToList());

                            resultado = resultado.Distinct().ToList();
                        }



                        if (!string.IsNullOrEmpty(responsavelAluno.Restricoes))
                        {

                            resultado = ((from ra in resultado
                                          where
                                           ra.Restricoes!=null && ra.Restricoes.Contains(responsavelAluno.Restricoes)
                                          select ra).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (responsavelAluno.Status.HasValue)
                        {

                            resultado = ((from ra in resultado
                                          where
                                          ra.Status.HasValue && ra.Status.Value == responsavelAluno.Status.Value
                                          select ra).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (responsavelAluno.ResideCom.HasValue)
                        {

                            resultado = ((from ra in resultado
                                          where
                                          ra.ResideCom.HasValue && ra.ResideCom.Value == responsavelAluno.ResideCom.Value
                                          select ra).ToList());

                            resultado = resultado.Distinct().ToList();
                        }


                        break;
                    }
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                        if (responsavelAluno.ID != 0)
                        {

                            resultado.AddRange((from ra in Consultar()
                                                where
                                                ra.ID == responsavelAluno.ID
                                                select ra).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (responsavelAluno.Aluno != null && !string.IsNullOrEmpty(responsavelAluno.Aluno.Nome))
                        {

                            resultado.AddRange((from ra in Consultar()
                                                where
                                                ra.Aluno.Nome.Contains(responsavelAluno.Aluno.Nome)
                                                select ra).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (responsavelAluno.Responsavel != null && !string.IsNullOrEmpty(responsavelAluno.Responsavel.Nome))
                        {

                            resultado.AddRange((from ra in Consultar()
                                                where
                                                ra.Responsavel.Nome.Contains(responsavelAluno.Responsavel.Nome)
                                                select ra).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (responsavelAluno.AlunoID != 0)
                        {

                            resultado.AddRange((from ra in Consultar()
                                                where
                                                ra.AlunoID == responsavelAluno.AlunoID
                                                select ra).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (responsavelAluno.ResponsavelID != 0)
                        {

                            resultado.AddRange((from ra in Consultar()
                                                where
                                                ra.ResponsavelID == responsavelAluno.ResponsavelID
                                                select ra).ToList());

                            resultado = resultado.Distinct().ToList();
                        }



                        if (!string.IsNullOrEmpty(responsavelAluno.Restricoes))
                        {

                            resultado.AddRange((from ra in Consultar()
                                                where
                                                ra.Restricoes!= null && ra.Restricoes.Contains(responsavelAluno.Restricoes)
                                                select ra).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (responsavelAluno.Status.HasValue)
                        {

                            resultado.AddRange((from ra in Consultar()
                                                where
                                                ra.Status.HasValue && ra.Status.Value == responsavelAluno.Status.Value
                                                select ra).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (responsavelAluno.ResideCom.HasValue)
                        {

                            resultado.AddRange((from ra in Consultar()
                                                where
                                                ra.ResideCom.HasValue && ra.ResideCom.Value == responsavelAluno.ResideCom.Value
                                                select ra).ToList());

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

        public void Incluir(ResponsavelAluno responsavelAluno)
        {
            try
            {
                db.ResponsavelAluno.InsertOnSubmit(responsavelAluno);
            }
            catch (Exception)
            {

                throw new ResponsavelAlunoNaoIncluidoExcecao();
            }
        }

        public void Excluir(ResponsavelAluno responsavelAluno)
        {
            try
            {
                ResponsavelAluno responsavelAlunoAux = new ResponsavelAluno();
                responsavelAlunoAux.ID = responsavelAluno.ID;


                List<ResponsavelAluno> resultado = this.Consultar(responsavelAlunoAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new ResponsavelAlunoNaoExcluidoExcecao();

                responsavelAlunoAux = resultado[0];

                db.ResponsavelAluno.DeleteOnSubmit(responsavelAlunoAux);
            }
            catch (Exception)
            {

                throw new ResponsavelAlunoNaoExcluidoExcecao();
            }
        }

        public void Alterar(ResponsavelAluno responsavelAluno)
        {
            try
            {
                ResponsavelAluno responsavelAlunoAux = new ResponsavelAluno();
                responsavelAlunoAux.ID = responsavelAluno.ID;

                List<ResponsavelAluno> resultado = this.Consultar(responsavelAlunoAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new ResponsavelAlunoNaoAlteradoExcecao();

                responsavelAlunoAux = resultado[0];

                responsavelAlunoAux.AlunoID = responsavelAluno.AlunoID;
                responsavelAlunoAux.ResponsavelID = responsavelAluno.ResponsavelID;
                responsavelAlunoAux.GrauParentesco = responsavelAluno.GrauParentesco;
                responsavelAlunoAux.ResideCom = responsavelAluno.ResideCom;
                responsavelAlunoAux.ResponsavelID = responsavelAluno.ResponsavelID;
                responsavelAlunoAux.Restricoes = responsavelAluno.Restricoes;
                responsavelAlunoAux.Status = responsavelAluno.Status;

            }
            catch (Exception)
            {

                throw new ResponsavelAlunoNaoAlteradoExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion

        #region Construtor
        public ResponsavelAlunoRepositorio()
        {
            Conexao conexao = new Conexao();
            db = new ColegioDB(new MySqlConnection(conexao.ToString()));

        }
        #endregion




    }
}