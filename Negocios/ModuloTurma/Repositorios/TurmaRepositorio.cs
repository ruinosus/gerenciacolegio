using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloTurma.Excecoes;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloBasico.VOs;

namespace Negocios.ModuloTurma.Repositorios
{
    public class TurmaRepositorio : ITurmaRepositorio
    {
        #region Atributos

        ColegioDB db;

        #endregion

        #region Métodos da Interface

        public List<Turma> Consultar()
        {
            return db.Turma.ToList();
        }

        public List<Turma> Consultar(Turma turma, TipoPesquisa tipoPesquisa)
        {
            List<Turma> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (turma.ID != 0)
                        {

                            resultado = ((from t in resultado
                                          where
                                          t.ID == turma.ID
                                          select t).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(turma.Nome))
                        {

                            resultado = ((from t in resultado
                                          where
                                          t.Nome.Contains(turma.Nome)
                                          select t).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (turma.Status.HasValue)
                        {

                            resultado = ((from t in resultado
                                          where
                                          t.Status.HasValue && t.Status.Value == turma.Status.Value
                                          select t).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        break;
                    }
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                        if (turma.ID != 0)
                        {

                            resultado.AddRange((from t in Consultar()
                                                where
                                                t.ID == turma.ID
                                                select t).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(turma.Nome))
                        {

                            resultado.AddRange((from t in Consultar()
                                                where
                                                t.Nome.Contains(turma.Nome)
                                                select t).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (turma.Status.HasValue)
                        {

                            resultado.AddRange((from t in Consultar()
                                                where
                                                t.Status.HasValue && t.Status.Value == turma.Status.Value
                                                select t).ToList());

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

        public void Incluir(Turma turma)
        {
            try
            {
                db.Turma.InsertOnSubmit(turma);
            }
            catch (Exception)
            {

                throw new TurmaNaoIncluidaExcecao();
            }
        }

        public void Excluir(Turma turma)
        {
            try
            {
                Turma turmaAux = new Turma();
                turmaAux.ID = turma.ID;

                List<Turma> resultado = this.Consultar(turmaAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new TurmaNaoExcluidaExcecao();

                turmaAux = resultado[0];

                db.Turma.DeleteOnSubmit(turmaAux);
            }
            catch (Exception)
            {

                throw new TurmaNaoExcluidaExcecao();
            }
        }

        public void Alterar(Turma turma)
        {
            try
            {
                Turma turmaAux = new Turma();
                turmaAux.ID = turma.ID;

                List<Turma> resultado = this.Consultar(turmaAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new TurmaNaoAlteradaExcecao();

                turmaAux = resultado[0];
                turmaAux.Nome = turma.Nome;
                turmaAux.Status = turma.Status;


                Confirmar();
            }
            catch (Exception)
            {

                throw new TurmaNaoAlteradaExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion

        #region Construtor
        public TurmaRepositorio()
        {
            Conexao conexao = new Conexao();
            db = new ColegioDB(new MySqlConnection(conexao.ToString()));

        }
        #endregion


    }
}