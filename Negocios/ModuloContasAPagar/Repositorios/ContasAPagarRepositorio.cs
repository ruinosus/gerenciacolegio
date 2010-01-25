using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloContasAPagar.Excecoes;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloBasico.VOs;

namespace Negocios.ModuloContasAPagar.Repositorios
{
    public class ContasAPagarRepositorio : IContasAPagarRepositorio
    {
        #region Atributos

        ColegioDB db;

        #endregion

        #region Métodos da Interface

        public List<ContasAPagar> Consultar()
        {
            return db.ContasAPagar.ToList();
        }

        public List<ContasAPagar> Consultar(ContasAPagar contasAPagar, TipoPesquisa tipoPesquisa)
        {
            List<ContasAPagar> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (contasAPagar.ID != 0)
                        {

                            resultado = ((from cp in resultado
                                          where
                                          cp.ID == contasAPagar.ID
                                          select cp).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (contasAPagar.DataPagamento.HasValue && contasAPagar.DataPagamento.Value != default(DateTime))
                        {

                            resultado = ((from cp in resultado
                                          where
                                          cp.DataPagamento.HasValue && cp.DataPagamento.Value == contasAPagar.DataPagamento.Value
                                          select cp).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (contasAPagar.DataVencimento != default(DateTime))
                        {

                            resultado = ((from cp in resultado
                                          where
                                          cp.DataVencimento == contasAPagar.DataVencimento
                                          select cp).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (contasAPagar.Desconto.HasValue)
                        {

                            resultado = ((from cp in resultado
                                          where
                                          cp.Desconto.HasValue && cp.Desconto.Value == contasAPagar.Desconto.Value
                                          select cp).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(contasAPagar.Descricao))
                        {

                            resultado = ((from cp in resultado
                                          where
                                          cp.Descricao.Contains(contasAPagar.Descricao)
                                          select cp).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (contasAPagar.Multa.HasValue)
                        {

                            resultado = ((from cp in resultado
                                          where
                                          cp.Multa.HasValue && cp.Multa.Value == contasAPagar.Multa.Value
                                          select cp).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (contasAPagar.Parcela.HasValue)
                        {



                            resultado = ((from cp in resultado
                                          where
                                          cp.Parcela.HasValue && cp.Parcela.Value == contasAPagar.Parcela.Value
                                          select cp).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (contasAPagar.Status.HasValue)
                        {

                            resultado = ((from cp in resultado
                                          where
                                          cp.Status.HasValue && cp.Status.Value == contasAPagar.Status.Value
                                          select cp).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (contasAPagar.Valor.HasValue)
                        {

                            resultado = ((from cp in resultado
                                          where
                                          cp.Valor.HasValue && cp.Valor.Value == contasAPagar.Valor.Value
                                          select cp).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        break;
                    }
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                        if (contasAPagar.ID != 0)
                        {

                            resultado.AddRange((from cp in Consultar()
                                                where
                                                cp.ID == contasAPagar.ID
                                                select cp).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (contasAPagar.DataPagamento.HasValue && contasAPagar.DataPagamento.Value != default(DateTime))
                        {

                            resultado.AddRange((from cp in Consultar()
                                                where
                                                cp.DataPagamento.HasValue && cp.DataPagamento.Value == contasAPagar.DataPagamento.Value
                                                select cp).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (contasAPagar.DataVencimento != default(DateTime))
                        {

                            resultado.AddRange((from cp in Consultar()
                                                where
                                                cp.DataVencimento == contasAPagar.DataVencimento
                                                select cp).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (contasAPagar.Desconto.HasValue)
                        {

                            resultado.AddRange((from cp in Consultar()
                                                where
                                                cp.Desconto.HasValue && cp.Desconto.Value == contasAPagar.Desconto.Value
                                                select cp).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(contasAPagar.Descricao))
                        {

                            resultado.AddRange((from cp in Consultar()
                                                where
                                                cp.Descricao.Contains(contasAPagar.Descricao)
                                                select cp).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (contasAPagar.Multa.HasValue)
                        {

                            resultado.AddRange((from cp in Consultar()
                                                where
                                                cp.Multa.HasValue && cp.Multa.Value == contasAPagar.Multa.Value
                                                select cp).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (contasAPagar.Parcela.HasValue)
                        {


                            resultado.AddRange((from cp in Consultar()
                                                where
                                                cp.Parcela.HasValue && cp.Parcela.Value == contasAPagar.Parcela.Value
                                                select cp).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (contasAPagar.Status.HasValue)
                        {

                            resultado.AddRange((from cp in Consultar()
                                                where
                                                cp.Status.HasValue && cp.Status.Value == contasAPagar.Status.Value
                                                select cp).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (contasAPagar.Valor.HasValue)
                        {

                            resultado.AddRange((from cp in Consultar()
                                                where
                                                cp.Valor.HasValue && cp.Valor.Value == contasAPagar.Valor.Value
                                                select cp).ToList());

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

        public void Incluir(ContasAPagar contasAPagar)
        {
            try
            {
                db.ContasAPagar.InsertOnSubmit(contasAPagar);
            }
            catch (Exception)
            {

                throw new ContasAPagarNaoIncluidaExcecao();
            }
        }

        public void Excluir(ContasAPagar contasAPagar)
        {
            try
            {
                ContasAPagar contasAPagarAux = new ContasAPagar();
                contasAPagarAux.ID = contasAPagar.ID;


                List<ContasAPagar> resultado = this.Consultar(contasAPagarAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new ContasAPagarNaoExcluidaExcecao();

                contasAPagarAux = resultado[0];

                db.ContasAPagar.DeleteOnSubmit(contasAPagarAux);

            }
            catch (Exception)
            {

                throw new ContasAPagarNaoExcluidaExcecao();
            }
        }

        public void Alterar(ContasAPagar contasAPagar)
        {
            try
            {
                ContasAPagar contasAPagarAux = new ContasAPagar();
                contasAPagarAux.ID = contasAPagar.ID;

                List<ContasAPagar> resultado = this.Consultar(contasAPagarAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new ContasAPagarNaoAlteradaExcecao();

                contasAPagarAux = resultado[0];

                contasAPagarAux.DataPagamento = contasAPagar.DataPagamento;
                contasAPagarAux.DataVencimento = contasAPagar.DataVencimento;
                contasAPagarAux.Desconto = contasAPagar.Desconto;
                contasAPagarAux.Descricao = contasAPagar.Descricao;
                contasAPagarAux.Multa = contasAPagar.Multa;
                contasAPagarAux.Parcela = contasAPagar.Parcela;
                contasAPagarAux.Status = contasAPagar.Status;
                contasAPagarAux.Valor = contasAPagar.Valor;

                Confirmar();
            }
            catch (Exception)
            {

                throw new ContasAPagarNaoAlteradaExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion

        #region Construtor
        public ContasAPagarRepositorio()
        {
            Conexao conexao = new Conexao();
            db = new ColegioDB(new MySqlConnection(conexao.ToString()));

        }
        #endregion



    }
}