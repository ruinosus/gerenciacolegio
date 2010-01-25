using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloSalaPeriodo.Excecoes;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloBasico.VOs;

namespace Negocios.ModuloSalaPeriodo.Repositorios
{
    public class SalaPeriodoRepositorio : ISalaPeriodoRepositorio
    {
        #region Atributos

        ColegioDB db;

        #endregion

        #region Métodos da Interface

        public List<SalaPeriodo> Consultar()
        {
            return db.SalaPeriodo.ToList();
        }

        public List<SalaPeriodo> Consultar(SalaPeriodo salaPeriodo, TipoPesquisa tipoPesquisa)
        {
            List<SalaPeriodo> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (salaPeriodo.ID != 0)
                        {

                            resultado = ((from sp in resultado
                                          where
                                          sp.ID == salaPeriodo.ID
                                          select sp).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (salaPeriodo.Ano.HasValue)
                        {

                            resultado = ((from sp in resultado
                                          where
                                          sp.Ano.HasValue && sp.Ano.Value == salaPeriodo.Ano.Value
                                          select sp).ToList());

                            resultado = resultado.Distinct().ToList();
                        }



                        break;
                    }
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                        if (salaPeriodo.ID != 0)
                        {
                            resultado.AddRange((from sp in Consultar()
                                                where
                                                sp.ID == salaPeriodo.ID
                                                select sp).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (salaPeriodo.Ano.HasValue)
                        {
                            resultado.AddRange((from sp in Consultar()
                                                where
                                                sp.Ano.HasValue && sp.Ano.Value == salaPeriodo.Ano.Value
                                                select sp).ToList());
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

        public void Incluir(SalaPeriodo salaPeriodo)
        {
            try
            {
                db.SalaPeriodo.InsertOnSubmit(salaPeriodo);
            }
            catch (Exception)
            {

                throw new SalaPeriodoNaoIncluidaExcecao();
            }
        }

        public void Excluir(SalaPeriodo salaPeriodo)
        {
            try
            {
                SalaPeriodo salaPeriodoAux = new SalaPeriodo();
                salaPeriodoAux.ID = salaPeriodo.ID;

                List<SalaPeriodo> resultado = this.Consultar(salaPeriodoAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new SalaPeriodoNaoExcluidaExcecao();

                salaPeriodoAux = resultado[0];

                db.SalaPeriodo.DeleteOnSubmit(salaPeriodoAux);

            }
            catch (Exception)
            {

                throw new SalaPeriodoNaoExcluidaExcecao();
            }
        }

        public void Alterar(SalaPeriodo salaPeriodo)
        {
            try
            {
                SalaPeriodo salaPeriodoAux = new SalaPeriodo();
                salaPeriodoAux.ID = salaPeriodo.ID;

                List<SalaPeriodo> resultado = this.Consultar(salaPeriodoAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new SalaPeriodoNaoAlteradaExcecao();

                salaPeriodoAux = resultado[0];

                salaPeriodoAux.Ano = salaPeriodo.Ano;
                salaPeriodoAux.Sala = salaPeriodo.Sala;
                salaPeriodoAux.SalaID = salaPeriodo.SalaID;

                Confirmar();
            }
            catch (Exception)
            {

                throw new SalaPeriodoNaoAlteradaExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion


        #region Construtor
        public SalaPeriodoRepositorio()
        {
            Conexao conexao = new Conexao();
            db = new ColegioDB(new MySqlConnection(conexao.ToString()));

        }
        #endregion
    }
}