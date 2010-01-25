using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloDesconto.Excecoes;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloBasico.VOs;

namespace Negocios.ModuloDesconto.Repositorios
{
    public class DescontoRepositorio : IDescontoRepositorio
    {
        #region Atributos
        ColegioDB db;

        #endregion

        #region Métodos da Interface

        public List<Desconto> Consultar()
        {
            return db.Desconto.ToList();
        }

        public List<Desconto> Consultar(Desconto desconto, TipoPesquisa tipoPesquisa)
        {
            List<Desconto> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (desconto.ID != 0)
                        {

                            resultado = ((from d in resultado
                                          where
                                          d.ID == desconto.ID
                                          select d).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(desconto.Descricao))
                        {

                            resultado = ((from d in resultado
                                          where
                                          d.Descricao.Contains(desconto.Descricao)
                                          select d).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (desconto.Status.HasValue)
                        {

                            resultado = ((from d in resultado
                                          where
                                          d.Status.HasValue && d.Status.Value == desconto.Status.Value
                                          select d).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (desconto.Percentual != 0)
                        {

                            resultado = ((from d in resultado
                                          where
                                           d.Percentual == desconto.Percentual
                                          select d).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        break;
                    }
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                        if (desconto.ID != 0)
                        {

                            resultado.AddRange((from d in Consultar()
                                                where
                                                d.ID == desconto.ID
                                                select d).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(desconto.Descricao))
                        {

                            resultado.AddRange((from d in Consultar()
                                                where
                                                d.Descricao.Contains(desconto.Descricao)
                                                select d).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (desconto.Status.HasValue)
                        {

                            resultado.AddRange((from d in Consultar()
                                                where
                                                d.Status.HasValue && d.Status.Value == desconto.Status.Value
                                                select d).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (desconto.Percentual != 0)
                        {

                            resultado.AddRange((from d in Consultar()
                                                where
                                                 d.Percentual == desconto.Percentual
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

        public void Incluir(Desconto desconto)
        {
            try
            {
                db.Desconto.InsertOnSubmit(desconto);
            }
            catch (Exception)
            {

                throw new DescontoNaoIncluidoExcecao();
            }
        }

        public void Excluir(Desconto desconto)
        {
            try
            {
                Desconto descontoAux = new Desconto();
                descontoAux.ID = desconto.ID;

                List<Desconto> resultado = this.Consultar(descontoAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new DescontoNaoExcluidoExcecao();

                descontoAux = resultado[0];

                db.Desconto.DeleteOnSubmit(descontoAux);
            }
            catch (Exception)
            {

                throw new DescontoNaoExcluidoExcecao();
            }
        }

        public void Alterar(Desconto desconto)
        {
            try
            {
                Desconto descontoAux = new Desconto();
                descontoAux.ID = desconto.ID;

                List<Desconto> resultado = this.Consultar(descontoAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new DescontoNaoExcluidoExcecao();

                descontoAux = resultado[0];

                descontoAux.Descricao = desconto.Descricao;
                descontoAux.Percentual = desconto.Percentual;
                descontoAux.Status = desconto.Status;
                Confirmar();
            }
            catch (Exception)
            {

                throw new DescontoNaoAlteradoExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion

        #region Construtor
        public DescontoRepositorio()
        {
            Conexao conexao = new Conexao();
            db = new ColegioDB(new MySqlConnection(conexao.ToString()));
        }


        #endregion
    }
}