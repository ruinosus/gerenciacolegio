using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloBoletoMensalidade.Excecoes;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloBasico.VOs;

namespace Negocios.ModuloBoletoMensalidade.Repositorios
{
    public class BoletoMensalidadeRepositorio : IBoletoMensalidadeRepositorio
    {
        #region Atributos

        ColegioDB db;

        #endregion

        #region Métodos da Interface

        public List<BoletoMensalidade> Consultar()
        {
            return db.BoletoMensalidade.ToList();
        }

        public List<BoletoMensalidade> Consultar(BoletoMensalidade boletoMensalidade, TipoPesquisa tipoPesquisa)
        {
            List<BoletoMensalidade> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {

                        if (boletoMensalidade.ID != 0)
                        {

                            resultado = ((from bm in resultado
                                          where
                                          bm.ID == boletoMensalidade.ID
                                          select bm).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (boletoMensalidade.MatriculaID != 0 && boletoMensalidade.MatriculaID != null)
                        {

                            resultado = ((from bm in resultado
                                          where
                                          bm.MatriculaID == boletoMensalidade.MatriculaID
                                          select bm).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (boletoMensalidade.DataEmissao != default(DateTime))
                        {

                            resultado = ((from bm in resultado
                                          where
                                          bm.DataEmissao == boletoMensalidade.DataEmissao
                                          select bm).ToList());

                            resultado = resultado.Distinct().ToList();
                        }


                        if (boletoMensalidade.DataPagamento.HasValue && boletoMensalidade.DataPagamento.Value != default(DateTime))
                        {

                            resultado = ((from bm in resultado
                                          where
                                          bm.DataPagamento.HasValue && bm.DataPagamento.Value == boletoMensalidade.DataPagamento.Value
                                          select bm).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (boletoMensalidade.DataVencimento != default(DateTime))
                        {

                            resultado = ((from bm in resultado
                                          where
                                          bm.DataVencimento == boletoMensalidade.DataVencimento
                                          select bm).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (boletoMensalidade.Desconto.HasValue)
                        {

                            resultado = ((from bm in resultado
                                          where
                                          bm.Desconto.HasValue && bm.Desconto.Value == boletoMensalidade.Desconto.Value
                                          select bm).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(boletoMensalidade.Descricao))
                        {

                            resultado = ((from bm in resultado
                                          where
                                          bm.Descricao.Contains(boletoMensalidade.Descricao)
                                          select bm).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (boletoMensalidade.Multa.HasValue)
                        {

                            resultado = ((from bm in resultado
                                          where
                                          bm.Multa.HasValue && bm.Multa.Value == boletoMensalidade.Multa.Value
                                          select bm).ToList());

                            resultado = resultado.Distinct().ToList();
                        }



                        if (boletoMensalidade.Status.HasValue && boletoMensalidade.Status.Value != default(byte))
                        {

                            resultado = ((from bm in resultado
                                          where
                                          bm.Status.HasValue && bm.Status.Value == boletoMensalidade.Status.Value
                                          select bm).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        break;
                    }
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {

                        if (boletoMensalidade.ID != 0)
                        {

                            resultado.AddRange((from bm in Consultar()
                                                where
                                                bm.ID == boletoMensalidade.ID
                                                select bm).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (boletoMensalidade.DataEmissao != default(DateTime))
                        {

                            resultado.AddRange((from bm in Consultar()
                                                where
                                                bm.DataEmissao == boletoMensalidade.DataEmissao
                                                select bm).ToList());

                            resultado = resultado.Distinct().ToList();
                        }


                        if (boletoMensalidade.DataPagamento.HasValue && boletoMensalidade.DataPagamento.Value != default(DateTime))
                        {

                            resultado.AddRange((from bm in Consultar()
                                                where
                                                bm.DataPagamento.HasValue && bm.DataPagamento.Value == boletoMensalidade.DataPagamento.Value
                                                select bm).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (boletoMensalidade.DataVencimento != default(DateTime))
                        {

                            resultado.AddRange((from bm in Consultar()
                                                where
                                                bm.DataVencimento == boletoMensalidade.DataVencimento
                                                select bm).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (boletoMensalidade.Desconto.HasValue)
                        {

                            resultado.AddRange((from bm in Consultar()
                                                where
                                                bm.Desconto.HasValue && bm.Desconto.Value == boletoMensalidade.Desconto.Value
                                                select bm).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(boletoMensalidade.Descricao))
                        {

                            resultado.AddRange((from bm in Consultar()
                                                where
                                                bm.Descricao.Contains(boletoMensalidade.Descricao)
                                                select bm).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (boletoMensalidade.Multa.HasValue)
                        {

                            resultado.AddRange((from bm in Consultar()
                                                where
                                                bm.Multa.HasValue && bm.Multa.Value == boletoMensalidade.Multa.Value
                                                select bm).ToList());

                            resultado = resultado.Distinct().ToList();
                        }



                        if (boletoMensalidade.Status.HasValue && boletoMensalidade.Status.Value != default(byte))
                        {

                            resultado.AddRange((from bm in Consultar()
                                                where
                                                bm.Status.HasValue && bm.Status.Value == boletoMensalidade.Status.Value
                                                select bm).ToList());

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

        public void Incluir(BoletoMensalidade boletoMensalidade)
        {
            try
            {
                db.BoletoMensalidade.InsertOnSubmit(boletoMensalidade);
            }
            catch (Exception)
            {

                throw new BoletoMensalidadeNaoIncluidaExcecao();
            }
        }

        public void Excluir(BoletoMensalidade boletoMensalidade)
        {
            try
            {
                BoletoMensalidade boletoMensalidadeAux = new BoletoMensalidade();
                boletoMensalidadeAux.ID = boletoMensalidade.ID;

                List<BoletoMensalidade> resultado = this.Consultar(boletoMensalidadeAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new BoletoMensalidadeNaoExcluidaExcecao();

                boletoMensalidadeAux = resultado[0];

                db.BoletoMensalidade.DeleteOnSubmit(boletoMensalidadeAux);
            }
            catch (Exception)
            {

                throw new BoletoMensalidadeNaoExcluidaExcecao();
            }
        }

        public void Alterar(BoletoMensalidade boletoMensalidade)
        {
            try
            {
                BoletoMensalidade boletoMensalidadeAux = new BoletoMensalidade();
                boletoMensalidadeAux.ID = boletoMensalidade.ID;

                List<BoletoMensalidade> resultado = this.Consultar(boletoMensalidadeAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new BoletoMensalidadeNaoAlteradaExcecao();

                boletoMensalidadeAux = resultado[0];

                boletoMensalidadeAux.DataEmissao = boletoMensalidade.DataEmissao;
                boletoMensalidadeAux.DataPagamento = boletoMensalidade.DataPagamento;
                boletoMensalidadeAux.DataVencimento = boletoMensalidade.DataVencimento;
                boletoMensalidadeAux.Desconto = boletoMensalidade.Desconto;
                boletoMensalidadeAux.Descricao = boletoMensalidade.Descricao;
                boletoMensalidadeAux.Matricula = boletoMensalidade.Matricula;
                boletoMensalidadeAux.MatriculaID = boletoMensalidade.MatriculaID;
                boletoMensalidadeAux.Multa = boletoMensalidade.Multa;
                boletoMensalidadeAux.Parcela = boletoMensalidade.Parcela;
                boletoMensalidadeAux.Status = boletoMensalidade.Status;
                boletoMensalidadeAux.Valor = boletoMensalidade.Valor;
                boletoMensalidadeAux.DataImpressao = boletoMensalidade.DataImpressao;
                boletoMensalidadeAux.Juncao = boletoMensalidade.Juncao;
                boletoMensalidadeAux.NumeroImpressao = boletoMensalidade.NumeroImpressao;
                Confirmar();
            }
            catch (Exception)
            {

                throw new BoletoMensalidadeNaoAlteradaExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion

        #region Construtor
        public BoletoMensalidadeRepositorio()
        {
            Conexao conexao = new Conexao();
            db = new ColegioDB(new MySqlConnection(conexao.ToString()));

        }
        #endregion



    }
}