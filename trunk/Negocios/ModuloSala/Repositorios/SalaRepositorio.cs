using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloSala.Excecoes;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloSala.Repositorios
{
    public class SalaRepositorio : ISalaRepositorio
    {
        #region Atributos

        ColegioDB db = new ColegioDB(new MySqlConnection(BasicoConstantes.CONEXAO));

        #endregion

        #region Métodos da Interface

        public List<Sala> Consultar()
        {
            return db.Sala.ToList();
        }

        public List<Sala> Consultar(Sala sala, TipoPesquisa tipoPesquisa)
        {
            List<Sala> resultado = Consultar();
            bool pesquisa = false;
            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (sala.ID != 0)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from s in resultado
                                                    where
                                                    s.ID == sala.ID
                                                    select s).ToList());
                            }
                            else
                            {
                                resultado=((from s in resultado
                                                    where
                                                    s.ID == sala.ID
                                                    select s).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        

                        if (sala.Status.HasValue)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from s in resultado
                                                    where
                                                    s.Status.HasValue && s.Status.Value == sala.Status.Value
                                                    select s).ToList());
                            }
                            else
                            {
                                resultado=((from s in resultado
                                                    where
                                                    s.Status.HasValue && s.Status.Value == sala.Status.Value
                                                    select s).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (sala.SerieID.HasValue)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from s in resultado
                                                    where
                                                    s.SerieID.HasValue && s.SerieID.Value == sala.SerieID.Value
                                                    select s).ToList());

                            }
                            else
                            {
                                resultado=((from s in resultado
                                                    where
                                                    s.SerieID.HasValue && s.SerieID.Value == sala.SerieID.Value
                                                    select s).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (sala.TurmaID.HasValue)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from s in resultado
                                                    where
                                                    s.TurmaID.HasValue && s.TurmaID.Value == sala.TurmaID.Value
                                                    select s).ToList());
                            }
                            else
                            {
                                resultado=((from s in resultado
                                                    where
                                                    s.TurmaID.HasValue && s.TurmaID.Value == sala.TurmaID.Value
                                                    select s).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (sala.TurnoID.HasValue)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from s in resultado
                                                    where
                                                    s.TurnoID.HasValue && s.TurnoID.Value == sala.TurnoID.Value
                                                    select s).ToList());
                            }
                            else
                            {
                                resultado=((from s in resultado
                                                    where
                                                    s.TurnoID.HasValue && s.TurnoID.Value == sala.TurnoID.Value
                                                    select s).ToList());
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
                        if (sala.ID != 0)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from s in Consultar()
                                                    where
                                                    s.ID == sala.ID
                                                    select s).ToList());
                            }
                            else
                            {
                                resultado = ((from s in Consultar()
                                              where
                                              s.ID == sala.ID
                                              select s).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }



                        if (sala.Status.HasValue)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from s in Consultar()
                                                    where
                                                    s.Status.HasValue && s.Status.Value == sala.Status.Value
                                                    select s).ToList());
                            }
                            else
                            {
                                resultado = ((from s in Consultar()
                                              where
                                              s.Status.HasValue && s.Status.Value == sala.Status.Value
                                              select s).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (sala.SerieID.HasValue)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from s in Consultar()
                                                    where
                                                    s.SerieID.HasValue && s.SerieID.Value == sala.SerieID.Value
                                                    select s).ToList());

                            }
                            else
                            {
                                resultado = ((from s in Consultar()
                                              where
                                              s.SerieID.HasValue && s.SerieID.Value == sala.SerieID.Value
                                              select s).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (sala.TurmaID.HasValue)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from s in Consultar()
                                                    where
                                                    s.TurmaID.HasValue && s.TurmaID.Value == sala.TurmaID.Value
                                                    select s).ToList());
                            }
                            else
                            {
                                resultado = ((from s in Consultar()
                                              where
                                              s.TurmaID.HasValue && s.TurmaID.Value == sala.TurmaID.Value
                                              select s).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (sala.TurnoID.HasValue)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from s in Consultar()
                                                    where
                                                    s.TurnoID.HasValue && s.TurnoID.Value == sala.TurnoID.Value
                                                    select s).ToList());
                            }
                            else
                            {
                                resultado = ((from s in Consultar()
                                              where
                                              s.TurnoID.HasValue && s.TurnoID.Value == sala.TurnoID.Value
                                              select s).ToList());
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

        public void Incluir(Sala sala)
        {
            try
            {
                db.Sala.InsertOnSubmit(sala);
            }
            catch (Exception)
            {
                
                throw new SalaNaoIncluidaExcecao();
            }
        }

        public void Excluir(Sala sala)
        {
            try
            {
                Sala salaAux = new Sala();
                salaAux.ID = sala.ID;

                List<Sala> resultado = this.Consultar(salaAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new SalaNaoExcluidaExcecao();

                salaAux = resultado[0];

                db.Sala.DeleteOnSubmit(salaAux);
            }
            catch (Exception)
            {
                
                throw new SalaNaoExcluidaExcecao();
            }
        }

        public void Alterar(Sala sala)
        {
            try
            {
                Sala salaAux = new Sala();
                salaAux.ID = sala.ID;

                List<Sala> resultado = this.Consultar(salaAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new SalaNaoAlteradaExcecao();

                salaAux = resultado[0];

                salaAux.SalaPeriodo = sala.SalaPeriodo;
                salaAux.SerieID = sala.SerieID;
                salaAux.TurmaID= sala.TurmaID;
                salaAux.TurnoID = sala.TurnoID;

                Confirmar();
            }
            catch (Exception)
            {
                
               throw new SalaNaoAlteradaExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion


    }
}