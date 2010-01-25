using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloTurno.Excecoes;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloBasico.VOs;

namespace Negocios.ModuloTurno.Repositorios
{
    public class TurnoRepositorio : ITurnoRepositorio
    {
        #region Atributos

        ColegioDB db;

        #endregion

        #region Métodos da Interface

        public List<Turno> Consultar()
        {
            return db.Turno.ToList();
        }

        public List<Turno> Consultar(Turno turno, TipoPesquisa tipoPesquisa)
        {
            List<Turno> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (turno.ID != 0)
                        {

                            resultado = ((from t in resultado
                                          where
                                          t.ID == turno.ID
                                          select t).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(turno.Nome))
                        {

                            resultado = ((from t in resultado
                                          where
                                          t.Nome.Contains(turno.Nome)
                                          select t).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (turno.Status.HasValue)
                        {

                            resultado = ((from t in resultado
                                          where
                                          t.Status.HasValue && t.Status.Value == turno.Status.Value
                                          select t).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        break;
                    }
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                        if (turno.ID != 0)
                        {

                            resultado.AddRange((from t in Consultar()
                                                where
                                                t.ID == turno.ID
                                                select t).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(turno.Nome))
                        {

                            resultado.AddRange((from t in Consultar()
                                                where
                                                t.Nome.Contains(turno.Nome)
                                                select t).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (turno.Status.HasValue)
                        {

                            resultado.AddRange((from t in Consultar()
                                                where
                                                t.Status.HasValue && t.Status.Value == turno.Status.Value
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

        public void Incluir(Turno turno)
        {
            try
            {
                db.Turno.InsertOnSubmit(turno);
            }
            catch (Exception)
            {

                throw new TurnoNaoIncluidoExcecao();
            }
        }

        public void Excluir(Turno turno)
        {
            try
            {
                Turno turnoAux = new Turno();
                turnoAux.ID = turno.ID;

                List<Turno> resultado = this.Consultar(turnoAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new TurnoNaoExcluidoExcecao();

                turnoAux = resultado[0];

                db.Turno.DeleteOnSubmit(turnoAux);

            }
            catch (Exception)
            {

                throw new TurnoNaoExcluidoExcecao();
            }
        }

        public void Alterar(Turno turno)
        {
            try
            {
                Turno turnoAux = new Turno();
                turnoAux.ID = turno.ID;

                List<Turno> resultado = this.Consultar(turnoAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new TurnoNaoAlteradoExcecao();

                turnoAux = resultado[0];
                turnoAux.Nome = turno.Nome;
                turnoAux.Status = turno.Status;

                Confirmar();
            }
            catch (Exception)
            {

                throw new TurnoNaoAlteradoExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion

        #region Construtor
        public TurnoRepositorio()
        {
            Conexao conexao = new Conexao();
            db = new ColegioDB(new MySqlConnection(conexao.ToString()));

        }
        #endregion


    }
}