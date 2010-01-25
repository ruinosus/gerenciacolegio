using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloProfessorDisciplinaSala.Excecoes;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloBasico.VOs;

namespace Negocios.ModuloProfessorDisciplinaSala.Repositorios
{
    public class ProfessorDisciplinaSalaRepositorio : IProfessorDisciplinaSalaRepositorio
    {
        #region Atributos

        ColegioDB db;

        #endregion

        #region Métodos da Interface

        public List<ProfessorDisciplinaSala> Consultar()
        {
            return db.ProfessorDisciplinaSala.ToList();
        }

        public List<ProfessorDisciplinaSala> Consultar(ProfessorDisciplinaSala professorDisciplinaSala, TipoPesquisa tipoPesquisa)
        {
            List<ProfessorDisciplinaSala> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (professorDisciplinaSala.ID != 0)
                        {

                            resultado = ((from pds in resultado
                                          where
                                          pds.ID == professorDisciplinaSala.ID
                                          select pds).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (professorDisciplinaSala.DataPeriodo.HasValue && professorDisciplinaSala.DataPeriodo.Value != default(DateTime))
                        {

                            resultado = ((from pds in resultado
                                          where
                                          pds.DataPeriodo.HasValue && pds.DataPeriodo.Value == professorDisciplinaSala.DataPeriodo.Value
                                          select pds).ToList());

                            resultado = resultado.Distinct().ToList();
                        }
                        if (professorDisciplinaSala.DisciplinaID.HasValue)
                        {


                            resultado = ((from pds in resultado
                                          where
                                          pds.DisciplinaID.HasValue && pds.DisciplinaID.Value == professorDisciplinaSala.DisciplinaID.Value
                                          select pds).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (professorDisciplinaSala.FuncionarioID.HasValue)
                        {

                            resultado = ((from pds in resultado
                                          where
                                          pds.FuncionarioID.HasValue && pds.FuncionarioID.Value == professorDisciplinaSala.FuncionarioID.Value
                                          select pds).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (professorDisciplinaSala.SalaPeriodoID.HasValue)
                        {

                            resultado = ((from pds in resultado
                                          where
                                          pds.SalaPeriodoID.HasValue && pds.SalaPeriodoID.Value == professorDisciplinaSala.SalaPeriodoID.Value
                                          select pds).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (professorDisciplinaSala.Status.HasValue)
                        {

                            resultado = ((from pds in resultado
                                          where
                                          pds.Status.HasValue && pds.Status.Value == professorDisciplinaSala.Status.Value
                                          select pds).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        break;
                    }
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                        if (professorDisciplinaSala.ID != 0)
                        {

                            resultado.AddRange((from pds in Consultar()
                                                where
                                                pds.ID == professorDisciplinaSala.ID
                                                select pds).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (professorDisciplinaSala.DataPeriodo.HasValue && professorDisciplinaSala.DataPeriodo.Value != default(DateTime))
                        {

                            resultado.AddRange((from pds in Consultar()
                                                where
                                                pds.DataPeriodo.HasValue && pds.DataPeriodo.Value == professorDisciplinaSala.DataPeriodo.Value
                                                select pds).ToList());

                            resultado = resultado.Distinct().ToList();
                        }
                        if (professorDisciplinaSala.DisciplinaID.HasValue)
                        {


                            resultado.AddRange((from pds in Consultar()
                                                where
                                                pds.DisciplinaID.HasValue && pds.DisciplinaID.Value == professorDisciplinaSala.DisciplinaID.Value
                                                select pds).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (professorDisciplinaSala.FuncionarioID.HasValue)
                        {

                            resultado.AddRange((from pds in Consultar()
                                                where
                                                pds.FuncionarioID.HasValue && pds.FuncionarioID.Value == professorDisciplinaSala.FuncionarioID.Value
                                                select pds).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (professorDisciplinaSala.SalaPeriodoID.HasValue)
                        {

                            resultado.AddRange((from pds in Consultar()
                                                where
                                                pds.SalaPeriodoID.HasValue && pds.SalaPeriodoID.Value == professorDisciplinaSala.SalaPeriodoID.Value
                                                select pds).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (professorDisciplinaSala.Status.HasValue)
                        {

                            resultado.AddRange((from pds in Consultar()
                                                where
                                                pds.Status.HasValue && pds.Status.Value == professorDisciplinaSala.Status.Value
                                                select pds).ToList());

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

        public void Incluir(ProfessorDisciplinaSala professorDisciplinaSala)
        {
            try
            {
                db.ProfessorDisciplinaSala.InsertOnSubmit(professorDisciplinaSala);
            }
            catch (Exception)
            {

                throw new ProfessorDisciplinaSalaNaoIncluidaExcecao();
            }
        }

        public void Excluir(ProfessorDisciplinaSala professorDisciplinaSala)
        {
            try
            {
                ProfessorDisciplinaSala professorDisciplinaSalaAux = new ProfessorDisciplinaSala();
                professorDisciplinaSalaAux.ID = professorDisciplinaSala.ID;

                List<ProfessorDisciplinaSala> resultado = this.Consultar(professorDisciplinaSalaAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new ProfessorDisciplinaSalaNaoExcluidaExcecao();

                professorDisciplinaSalaAux = resultado[0];

                db.ProfessorDisciplinaSala.DeleteOnSubmit(professorDisciplinaSalaAux);

            }
            catch (Exception)
            {

                throw new ProfessorDisciplinaSalaNaoExcluidaExcecao();
            }
        }

        public void Alterar(ProfessorDisciplinaSala professorDisciplinaSala)
        {
            try
            {
                ProfessorDisciplinaSala professorDisciplinaSalaAux = new ProfessorDisciplinaSala();
                professorDisciplinaSalaAux.ID = professorDisciplinaSala.ID;

                List<ProfessorDisciplinaSala> resultado = this.Consultar(professorDisciplinaSalaAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new ProfessorDisciplinaSalaNaoAlteradaExcecao();

                professorDisciplinaSalaAux = resultado[0];

                professorDisciplinaSalaAux.DataPeriodo = professorDisciplinaSala.DataPeriodo;
                professorDisciplinaSalaAux.DisciplinaID = professorDisciplinaSala.DisciplinaID;
                professorDisciplinaSalaAux.FuncionarioID = professorDisciplinaSala.FuncionarioID;
                professorDisciplinaSalaAux.SalaPeriodoID = professorDisciplinaSala.SalaPeriodoID;
                professorDisciplinaSalaAux.Status = professorDisciplinaSala.Status;
                Confirmar();
            }
            catch (Exception)
            {

                throw new ProfessorDisciplinaSalaNaoAlteradaExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion

        #region Construtor
        public ProfessorDisciplinaSalaRepositorio()
        {
            Conexao conexao = new Conexao();
            db = new ColegioDB(new MySqlConnection(conexao.ToString()));

        }
        #endregion



    }
}