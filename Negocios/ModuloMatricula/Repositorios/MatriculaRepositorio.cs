using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloMatricula.Excecoes;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloBasico.VOs;

namespace Negocios.ModuloMatricula.Repositorios
{
    public class MatriculaRepositorio : IMatriculaRepositorio
    {
        #region Atributos

        ColegioDB db;

        #endregion

        #region Métodos da Interface

        public List<Matricula> Consultar()
        {
            return db.Matricula.ToList();
        }

        public List<Matricula> Consultar(Matricula matricula, TipoPesquisa tipoPesquisa)
        {
            List<Matricula> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (matricula.ID != 0)
                        {

                            resultado = ((from m in resultado
                                          where
                                          m.ID == matricula.ID
                                          select m).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (matricula.DataMatricula.HasValue && matricula.DataMatricula.Value != default(DateTime))
                        {

                            resultado = ((from m in resultado
                                          where
                                          m.DataMatricula.HasValue && m.DataMatricula.Value == matricula.DataMatricula.Value
                                          select m).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (matricula.AlunoID.HasValue && matricula.AlunoID.Value != 0)
                        {

                            resultado = ((from m in resultado
                                          where
                                          m.AlunoID.HasValue && m.AlunoID.Value == matricula.AlunoID.Value
                                          select m).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (matricula.Aluno != null)
                        {


                            resultado = ((from m in resultado
                                          where
                                          m.Aluno.Nome.ToLower().Contains(matricula.Aluno.Nome.ToLower())
                                          select m).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (matricula.DescontoID.HasValue)
                        {

                            resultado = ((from m in resultado
                                          where
                                          m.DescontoID.HasValue && m.DescontoID.Value == matricula.DescontoID.Value
                                          select m).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (matricula.SalaPeriodoID.HasValue)
                        {

                            resultado = ((from m in resultado
                                          where
                                          m.SalaPeriodoID.HasValue && m.SalaPeriodoID.Value == matricula.SalaPeriodoID.Value
                                          select m).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (matricula.Valor.HasValue)
                        {

                            resultado = ((from m in resultado
                                          where
                                          m.Valor.HasValue && m.Valor.Value == matricula.Valor.Value
                                          select m).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(matricula.NumMatricula))
                        {

                            resultado = ((from m in resultado
                                          where
                                          m.NumMatricula.Contains(matricula.NumMatricula)
                                          select m).ToList());

                            resultado = resultado.Distinct().ToList();
                        }


                        if (matricula.Status.HasValue)
                        {

                            resultado = ((from m in resultado
                                          where
                                          m.Status.HasValue && m.Status.Value == matricula.Status.Value
                                          select m).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        break;
                    }
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                        if (matricula.ID != 0)
                        {

                            resultado.AddRange((from m in Consultar()
                                                where
                                                m.ID == matricula.ID
                                                select m).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (matricula.DataMatricula.HasValue && matricula.DataMatricula.Value != default(DateTime))
                        {

                            resultado.AddRange((from m in Consultar()
                                                where
                                                m.DataMatricula.HasValue && m.DataMatricula.Value == matricula.DataMatricula.Value
                                                select m).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (matricula.Aluno != null)
                        {

                            resultado.AddRange((from m in Consultar()
                                                where
                                                m.Aluno.Nome.Contains(matricula.Aluno.Nome)
                                                select m).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (matricula.AlunoID.HasValue)
                        {

                            resultado.AddRange((from m in Consultar()
                                                where
                                                m.AlunoID.HasValue && m.AlunoID.Value == matricula.AlunoID.Value
                                                select m).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (matricula.DescontoID.HasValue)
                        {

                            resultado.AddRange((from m in Consultar()
                                                where
                                                m.DescontoID.HasValue && m.DescontoID.Value == matricula.DescontoID.Value
                                                select m).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (matricula.SalaPeriodoID.HasValue)
                        {

                            resultado.AddRange((from m in Consultar()
                                                where
                                                m.SalaPeriodoID.HasValue && m.SalaPeriodoID.Value == matricula.SalaPeriodoID.Value
                                                select m).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (matricula.Valor.HasValue)
                        {

                            resultado.AddRange((from m in Consultar()
                                                where
                                                m.Valor.HasValue && m.Valor.Value == matricula.Valor.Value
                                                select m).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(matricula.NumMatricula))
                        {

                            resultado.AddRange((from m in Consultar()
                                                where
                                                m.NumMatricula.Contains(matricula.NumMatricula)
                                                select m).ToList());

                            resultado = resultado.Distinct().ToList();
                        }


                        if (matricula.Status.HasValue)
                        {

                            resultado.AddRange((from m in Consultar()
                                                where
                                                m.Status.HasValue && m.Status.Value == matricula.Status.Value
                                                select m).ToList());

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

        public void Incluir(Matricula matricula)
        {
            try
            {
                db.Matricula.InsertOnSubmit(matricula);
            }
            catch (Exception)
            {

                throw new MatriculaNaoIncluidaExcecao();
            }
        }

        public void Excluir(Matricula matricula)
        {
            try
            {
                Matricula matriculaAux = new Matricula();
                matriculaAux.ID = matricula.ID;


                List<Matricula> resultado = this.Consultar(matriculaAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new MatriculaNaoExcluidaExcecao();

                matriculaAux = resultado[0];

                db.Matricula.DeleteOnSubmit(matriculaAux);
            }
            catch (Exception)
            {

                throw new MatriculaNaoExcluidaExcecao();
            }
        }

        public void Alterar(Matricula matricula)
        {
            try
            {
                Matricula matriculaAux = new Matricula();
                matriculaAux.ID = matricula.ID;


                List<Matricula> resultado = this.Consultar(matriculaAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new MatriculaNaoAlteradaExcecao();

                matriculaAux = resultado[0];

                matriculaAux.NumMatricula = matricula.NumMatricula;
                matriculaAux.SalaPeriodoID = matricula.SalaPeriodoID;
                matriculaAux.Status = matricula.Status;
                matriculaAux.Valor = matricula.Valor;
                matriculaAux.AlunoID = matricula.AlunoID;
                matriculaAux.BoletoMensalidade = matricula.BoletoMensalidade;
                matriculaAux.DataMatricula = matricula.DataMatricula;
                matriculaAux.DescontoID = matricula.DescontoID;
                matriculaAux.DiaVencimento = matricula.DiaVencimento;
                matriculaAux.Ano = matricula.Ano;
                Confirmar();

            }
            catch (Exception)
            {

                throw new MatriculaNaoAlteradaExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion

        #region Construtor
        public MatriculaRepositorio()
        {
            Conexao conexao = new Conexao();
            db = new ColegioDB(new MySqlConnection(conexao.ToString()));

        }
        #endregion


    }
}