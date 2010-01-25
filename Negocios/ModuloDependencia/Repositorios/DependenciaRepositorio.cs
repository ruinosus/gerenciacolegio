using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloDependencia.Excecoes;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloBasico.VOs;

namespace Negocios.ModuloDependencia.Repositorios
{
    public class DependenciaRepositorio : IDependenciaRepositorio
    {
        #region Atributos

        ColegioDB db;
        #endregion

        #region Métodos da Interface

        public List<Dependencia> Consultar()
        {
            return db.Dependencia.ToList();
        }

        public List<Dependencia> Consultar(Dependencia dependencia, TipoPesquisa tipoPesquisa)
        {
            List<Dependencia> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (dependencia.ID != 0)
                        {

                            resultado = ((from d in resultado
                                          where
                                          d.ID == dependencia.ID
                                          select d).ToList());

                            resultado = resultado.Distinct().ToList();
                        }



                        if (dependencia.Aprovado.HasValue)
                        {

                            resultado = ((from d in resultado
                                          where
                                          d.Aprovado.HasValue && d.Aprovado.Value == dependencia.Aprovado.Value
                                          select d).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (dependencia.ProfessorDisciplinaSalaID.HasValue)
                        {

                            resultado = ((from d in resultado
                                          where
                                          d.ProfessorDisciplinaSalaID.HasValue && d.ProfessorDisciplinaSalaID.Value == dependencia.ProfessorDisciplinaSalaID.Value
                                          select d).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (dependencia.Rec.HasValue)
                        {

                            resultado = ((from d in resultado
                                          where
                                          d.Rec.HasValue && d.Rec.Value == dependencia.Rec.Value
                                          select d).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (dependencia.RecFinal.HasValue)
                        {

                            resultado = ((from d in resultado
                                          where
                                          d.RecFinal.HasValue && d.RecFinal.Value == dependencia.RecFinal.Value
                                          select d).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (dependencia.Vp.HasValue)
                        {

                            resultado = ((from d in resultado
                                          where
                                          d.Vp.HasValue && d.Vp.Value == dependencia.Vp.Value
                                          select d).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (dependencia.Vc1 <= 0)
                        {

                            resultado = ((from d in resultado
                                          where
                                          d.Vc1 == dependencia.Vc1
                                          select d).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (dependencia.Vc2 <= 0)
                        {

                            resultado = ((from d in resultado
                                          where
                                          d.Vc2 == dependencia.Vc2
                                          select d).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (dependencia.Status.HasValue)
                        {

                            resultado = ((from d in resultado
                                          where
                                          d.Status.HasValue && d.Rec.Value == dependencia.Status.Value
                                          select d).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        break;
                    }
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                        if (dependencia.ID != 0)
                        {

                            resultado.AddRange((from d in Consultar()
                                                where
                                                d.ID == dependencia.ID
                                                select d).ToList());

                            resultado = resultado.Distinct().ToList();
                        }



                        if (dependencia.Aprovado.HasValue)
                        {

                            resultado.AddRange((from d in Consultar()
                                                where
                                                d.Aprovado.HasValue && d.Aprovado.Value == dependencia.Aprovado.Value
                                                select d).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (dependencia.ProfessorDisciplinaSalaID.HasValue)
                        {

                            resultado.AddRange((from d in Consultar()
                                                where
                                                d.ProfessorDisciplinaSalaID.HasValue && d.ProfessorDisciplinaSalaID.Value == dependencia.ProfessorDisciplinaSalaID.Value
                                                select d).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (dependencia.Rec.HasValue)
                        {

                            resultado.AddRange((from d in Consultar()
                                                where
                                                d.Rec.HasValue && d.Rec.Value == dependencia.Rec.Value
                                                select d).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (dependencia.RecFinal.HasValue)
                        {

                            resultado.AddRange((from d in Consultar()
                                                where
                                                d.RecFinal.HasValue && d.RecFinal.Value == dependencia.RecFinal.Value
                                                select d).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (dependencia.Vp.HasValue)
                        {

                            resultado.AddRange((from d in Consultar()
                                                where
                                                d.Vp.HasValue && d.Vp.Value == dependencia.Vp.Value
                                                select d).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (dependencia.Vc1 <= 0)
                        {

                            resultado.AddRange((from d in Consultar()
                                                where
                                                d.Vc1 == dependencia.Vc1
                                                select d).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (dependencia.Vc2 <= 0)
                        {

                            resultado.AddRange((from d in Consultar()
                                                where
                                                d.Vc2 == dependencia.Vc2
                                                select d).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (dependencia.Status.HasValue)
                        {

                            resultado.AddRange((from d in Consultar()
                                                where
                                                d.Status.HasValue && d.Rec.Value == dependencia.Status.Value
                                                select d).ToList());

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

        public void Incluir(Dependencia dependencia)
        {
            try
            {
                db.Dependencia.InsertOnSubmit(dependencia);
            }
            catch (Exception)
            {

                throw new DependenciaNaoIncluidaExcecao();
            }
        }

        public void Excluir(Dependencia dependencia)
        {
            try
            {
                Dependencia dependenciaAux = new Dependencia();
                dependenciaAux.ID = dependencia.ID;

                List<Dependencia> resultado = this.Consultar(dependenciaAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new DependenciaNaoExcluidaExcecao();

                dependenciaAux = resultado[0];

                db.Dependencia.DeleteOnSubmit(dependenciaAux);
            }
            catch (Exception)
            {

                throw new DependenciaNaoAlteradaExcecao();
            }
        }

        public void Alterar(Dependencia dependencia)
        {
            try
            {
                Dependencia dependenciaAux = new Dependencia();
                dependenciaAux.ID = dependencia.ID;

                List<Dependencia> resultado = this.Consultar(dependenciaAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new DependenciaNaoAlteradaExcecao();

                dependenciaAux = resultado[0];

                dependenciaAux.ProfessorDisciplinaSalaID = dependencia.ProfessorDisciplinaSalaID;
                dependenciaAux.Aprovado = dependencia.Aprovado;
                dependenciaAux.Rec = dependencia.Rec;
                dependenciaAux.RecFinal = dependencia.RecFinal;
                dependenciaAux.Vc1 = dependencia.Vc1;
                dependenciaAux.Vc2 = dependencia.Vc2;
                dependenciaAux.Vp = dependencia.Vp;
                dependenciaAux.Status = dependencia.Status;
                Confirmar();

            }
            catch (Exception)
            {

                throw new DependenciaNaoAlteradaExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion

        #region Construtor
        public DependenciaRepositorio()
        {
            Conexao conexao = new Conexao();
            db = new ColegioDB(new MySqlConnection(conexao.ToString()));

        }
        #endregion


    }
}