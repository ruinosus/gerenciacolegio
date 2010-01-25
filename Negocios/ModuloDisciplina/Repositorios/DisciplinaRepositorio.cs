using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloDisciplina.Excecoes;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloBasico.VOs;

namespace Negocios.ModuloDisciplina.Repositorios
{
    public class DisciplinaRepositorio : IDisciplinaRepositorio
    {
        #region Atributos

        ColegioDB db;

        #endregion

        #region Métodos da Interface

        public List<Disciplina> Consultar()
        {
            return db.Disciplina.ToList();
        }

        public List<Disciplina> Consultar(Disciplina disciplina, TipoPesquisa tipoPesquisa)
        {
            List<Disciplina> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (disciplina.ID != 0)
                        {


                            resultado = ((from d in resultado
                                          where
                                          d.ID == disciplina.ID
                                          select d).ToList());

                            resultado = resultado.Distinct().ToList();
                        }


                        if (disciplina.TipoAvaliacao.HasValue)
                        {


                            resultado = ((from d in resultado
                                          where
                                          d.TipoAvaliacao.HasValue && d.TipoAvaliacao.Value == disciplina.TipoAvaliacao.Value
                                          select d).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(disciplina.Nome))
                        {

                            resultado = ((from d in resultado
                                          where
                                          d.Nome.Contains(disciplina.Nome)
                                          select d).ToList());

                            resultado = resultado.Distinct().ToList();
                        }


                        if (disciplina.Status.HasValue)
                        {

                            resultado = ((from d in resultado
                                          where
                                          d.Status.HasValue && d.Status.Value == disciplina.Status.Value
                                          select d).ToList());

                            resultado = resultado.Distinct().ToList();
                        }


                        break;
                    }
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                        if (disciplina.ID != 0)
                        {

                            resultado.AddRange((from d in Consultar()
                                                where
                                                d.ID == disciplina.ID
                                                select d).ToList());

                            resultado = resultado.Distinct().ToList();
                        }


                        if (disciplina.TipoAvaliacao.HasValue)
                        {


                            resultado.AddRange((from d in Consultar()
                                                where
                                                d.TipoAvaliacao.HasValue && d.TipoAvaliacao.Value == disciplina.TipoAvaliacao.Value
                                                select d).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(disciplina.Nome))
                        {

                            resultado.AddRange((from d in Consultar()
                                                where
                                                d.Nome.Contains(disciplina.Nome)
                                                select d).ToList());

                            resultado = resultado.Distinct().ToList();
                        }


                        if (disciplina.Status.HasValue)
                        {

                            resultado.AddRange((from d in Consultar()
                                                where
                                                d.Status.HasValue && d.Status.Value == disciplina.Status.Value
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

        public void Incluir(Disciplina disciplina)
        {
            try
            {
                db.Disciplina.InsertOnSubmit(disciplina);
            }
            catch (Exception)
            {

                throw new DisciplinaNaoIncluidaExcecao();
            }
        }

        public void Excluir(Disciplina disciplina)
        {
            try
            {
                Disciplina disciplinaAux = new Disciplina();
                disciplinaAux.ID = disciplina.ID;


                List<Disciplina> resultado = this.Consultar(disciplinaAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new DisciplinaNaoExcluidaExcecao();

                disciplinaAux = resultado[0];

                db.Disciplina.DeleteOnSubmit(disciplinaAux);

            }
            catch (Exception)
            {

                throw new DisciplinaNaoExcluidaExcecao();
            }
        }

        public void Alterar(Disciplina disciplina)
        {
            try
            {
                Disciplina disciplinaAux = new Disciplina();
                disciplinaAux.ID = disciplina.ID;


                List<Disciplina> resultado = this.Consultar(disciplinaAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new DisciplinaNaoExcluidaExcecao();

                disciplinaAux = resultado[0];

                disciplinaAux.Nome = disciplina.Nome;
                disciplinaAux.Status = disciplina.Status;
                disciplinaAux.TipoAvaliacao = disciplina.TipoAvaliacao;

                Confirmar();

            }
            catch (Exception)
            {
                throw new DisciplinaNaoAlteradaExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion

        #region Construtor
        public DisciplinaRepositorio()
        {
            Conexao conexao = new Conexao();
            db = new ColegioDB(new MySqlConnection(conexao.ToString()));

        }
        #endregion
    }
}