using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloNota.Excecoes;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloNota.Repositorios
{
    public class NotaRepositorio : INotaRepositorio
    {
        #region Atributos

        ColegioDB db = new ColegioDB(new MySqlConnection(BasicoConstantes.CONEXAO));

        #endregion

        #region Métodos da Interface

        public List<Nota> Consultar()
        {
            return db.Nota.ToList();
        }

        public List<Nota> Consultar(Nota nota, TipoPesquisa tipoPesquisa)
        {
            List<Nota> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (nota.ID != 0)
                        {
                            resultado.AddRange((from d in resultado
                                                where
                                                d.ID == nota.ID
                                                select d).ToList());
                            resultado = resultado.Distinct().ToList();
                        }



                        if (nota.Aprovado.HasValue)
                        {
                            resultado.AddRange((from d in resultado
                                                where
                                                d.Aprovado.HasValue && d.Aprovado.Value == nota.Aprovado.Value
                                                select d).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (nota.ProfessorDisciplinaSalaID.HasValue)
                        {
                            resultado.AddRange((from d in resultado
                                                where
                                                d.ProfessorDisciplinaSalaID.HasValue && d.ProfessorDisciplinaSalaID.Value == nota.ProfessorDisciplinaSalaID.Value
                                                select d).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (nota.Rec.HasValue)
                        {
                            resultado.AddRange((from d in resultado
                                                where
                                                d.Rec.HasValue && d.Rec.Value == nota.Rec.Value
                                                select d).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (nota.RecFinal.HasValue)
                        {
                            resultado.AddRange((from d in resultado
                                                where
                                                d.RecFinal.HasValue && d.RecFinal.Value == nota.RecFinal.Value
                                                select d).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (nota.Vp.HasValue)
                        {
                            resultado.AddRange((from d in resultado
                                                where
                                                d.Vp.HasValue && d.Vp.Value == nota.Vp.Value
                                                select d).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (nota.Vc1 <= 0)
                        {
                            resultado.AddRange((from d in resultado
                                                where
                                                d.Vc1 == nota.Vc1
                                                select d).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (nota.Vc2 <= 0)
                        {
                            resultado.AddRange((from d in resultado
                                                where
                                                d.Vc2 == nota.Vc2
                                                select d).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        break;
                    }
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                        if (nota.ID != 0)
                        {
                            resultado.AddRange((from d in Consultar()
                                                where
                                                d.ID == nota.ID
                                                select d).ToList());
                            resultado = resultado.Distinct().ToList();
                        }



                        if (nota.Aprovado.HasValue)
                        {
                            resultado.AddRange((from d in Consultar()
                                                where
                                                d.Aprovado.HasValue && d.Aprovado.Value == nota.Aprovado.Value
                                                select d).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (nota.ProfessorDisciplinaSalaID.HasValue)
                        {
                            resultado.AddRange((from d in Consultar()
                                                where
                                                d.ProfessorDisciplinaSalaID.HasValue && d.ProfessorDisciplinaSalaID.Value == nota.ProfessorDisciplinaSalaID.Value
                                                select d).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (nota.Rec.HasValue)
                        {
                            resultado.AddRange((from d in Consultar()
                                                where
                                                d.Rec.HasValue && d.Rec.Value == nota.Rec.Value
                                                select d).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (nota.RecFinal.HasValue)
                        {
                            resultado.AddRange((from d in Consultar()
                                                where
                                                d.RecFinal.HasValue && d.RecFinal.Value == nota.RecFinal.Value
                                                select d).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (nota.Vp.HasValue)
                        {
                            resultado.AddRange((from d in Consultar()
                                                where
                                                d.Vp.HasValue && d.Vp.Value == nota.Vp.Value
                                                select d).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (nota.Vc1 <= 0)
                        {
                            resultado.AddRange((from d in Consultar()
                                                where
                                                d.Vc1 == nota.Vc1
                                                select d).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (nota.Vc2 <= 0)
                        {
                            resultado.AddRange((from d in Consultar()
                                                where
                                                d.Vc2 == nota.Vc2
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

        public void Incluir(Nota nota)
        {
            try
            {
                db.Nota.InsertOnSubmit(nota);
            }
            catch (Exception)
            {

                throw new NotaNaoIncluidaExcecao();
            }
        }

        public void Excluir(Nota nota)
        {
            try
            {
                db.Nota.DeleteOnSubmit(nota);
            }
            catch (Exception)
            {

                throw new NotaNaoExcluidaExcecao();
            }
        }

        public void Alterar(Nota nota)
        {
            try
            {
                db.Nota.InsertOnSubmit(nota);
            }
            catch (Exception)
            {

                throw new NotaNaoAlteradaExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion


    }
}