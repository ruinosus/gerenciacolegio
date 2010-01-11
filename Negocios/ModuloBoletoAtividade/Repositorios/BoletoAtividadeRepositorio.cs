using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloBoletoAtividade.Excecoes;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloBoletoAtividade.Repositorios
{
    public class BoletoAtividadeRepositorio: IBoletoAtividadeRepositorio
    { 
		#region Atributos
		
        ColegioDB db = new ColegioDB(new MySqlConnection(BasicoConstantes.CONEXAO));
		
		#endregion      
		
        #region M�todos da Interface

        public List<BoletoAtividade> Consultar()
        {
            return db.BoletoAtividade.ToList();
        }

        public List<BoletoAtividade> Consultar(BoletoAtividade boletoAtividade, TipoPesquisa tipoPesquisa)
        {
            List<BoletoAtividade> resultado = Consultar();
            bool pesquisa = false;
            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {

                        if (boletoAtividade.ID != 0)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from ba in resultado
                                                    where
                                                    ba.ID == boletoAtividade.ID
                                                    select ba).ToList());
                            }
                            else {
                                resultado=((from ba in resultado
                                                    where
                                                    ba.ID == boletoAtividade.ID
                                                    select ba).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (boletoAtividade.DataEmissao != default(DateTime))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from ba in resultado
                                                    where
                                                    ba.DataEmissao == boletoAtividade.DataEmissao
                                                    select ba).ToList());
                            }
                            else {
                                resultado=((from ba in resultado
                                                    where
                                                    ba.DataEmissao == boletoAtividade.DataEmissao
                                                    select ba).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }


                        if (boletoAtividade.DataPagamento.HasValue && boletoAtividade.DataPagamento.Value != default(DateTime))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from ba in resultado
                                                    where
                                                    ba.DataPagamento.HasValue && ba.DataPagamento.Value == boletoAtividade.DataPagamento.Value
                                                    select ba).ToList());
                            }
                            else {
                                resultado=((from ba in resultado
                                                    where
                                                    ba.DataPagamento.HasValue && ba.DataPagamento.Value == boletoAtividade.DataPagamento.Value
                                                    select ba).ToList());
                            } pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (boletoAtividade.DataVencimento != default(DateTime))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from ba in resultado
                                                    where
                                                    ba.DataVencimento == boletoAtividade.DataVencimento
                                                    select ba).ToList());
                            }
                            else {
                                resultado=((from ba in resultado
                                                    where
                                                    ba.DataVencimento == boletoAtividade.DataVencimento
                                                    select ba).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (boletoAtividade.Desconto.HasValue)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from ba in resultado
                                                    where
                                                    ba.Desconto.HasValue && ba.Desconto.Value == boletoAtividade.Desconto.Value
                                                    select ba).ToList());
                            }
                            else
                            {
                                resultado=((from ba in resultado
                                                    where
                                                    ba.Desconto.HasValue && ba.Desconto.Value == boletoAtividade.Desconto.Value
                                                    select ba).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (string.IsNullOrEmpty(boletoAtividade.Descricao))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from ba in resultado
                                                    where
                                                    ba.Descricao.Contains(boletoAtividade.Descricao)
                                                    select ba).ToList());
                            }
                            else
                            {
                                resultado=((from ba in resultado
                                                    where
                                                    ba.Descricao.Contains(boletoAtividade.Descricao)
                                                    select ba).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (boletoAtividade.Multa.HasValue)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from ba in resultado
                                                    where
                                                    ba.Multa.HasValue && ba.Multa.Value == boletoAtividade.Multa.Value
                                                    select ba).ToList());
                            }
                            else
                            {
                                resultado=((from ba in resultado
                                                    where
                                                    ba.Multa.HasValue && ba.Multa.Value == boletoAtividade.Multa.Value
                                                    select ba).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (boletoAtividade.Parcela.HasValue)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from ba in resultado
                                                    where
                                                    ba.Parcela.HasValue && ba.Parcela.Value == boletoAtividade.Parcela.Value
                                                    select ba).ToList());
                            }
                            else {
                                resultado=((from ba in resultado
                                                    where
                                                    ba.Parcela.HasValue && ba.Parcela.Value == boletoAtividade.Parcela.Value
                                                    select ba).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (boletoAtividade.Status.HasValue && boletoAtividade.Status.Value != default(byte))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from ba in resultado
                                                    where
                                                    ba.Status.HasValue && ba.Status.Value == boletoAtividade.Status.Value
                                                    select ba).ToList());
                            }
                            else
                            {
                                resultado=((from ba in resultado
                                                    where
                                                    ba.Status.HasValue && ba.Status.Value == boletoAtividade.Status.Value
                                                    select ba).ToList());
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

                        if (boletoAtividade.ID != 0)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from ba in Consultar()
                                                    where
                                                    ba.ID == boletoAtividade.ID
                                                    select ba).ToList());
                            }
                            else
                            {
                                resultado = ((from ba in Consultar()
                                              where
                                              ba.ID == boletoAtividade.ID
                                              select ba).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (boletoAtividade.DataEmissao != default(DateTime))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from ba in Consultar()
                                                    where
                                                    ba.DataEmissao == boletoAtividade.DataEmissao
                                                    select ba).ToList());
                            }
                            else
                            {
                                resultado = ((from ba in Consultar()
                                              where
                                              ba.DataEmissao == boletoAtividade.DataEmissao
                                              select ba).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }


                        if (boletoAtividade.DataPagamento.HasValue && boletoAtividade.DataPagamento.Value != default(DateTime))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from ba in Consultar()
                                                    where
                                                    ba.DataPagamento.HasValue && ba.DataPagamento.Value == boletoAtividade.DataPagamento.Value
                                                    select ba).ToList());
                            }
                            else
                            {
                                resultado = ((from ba in Consultar()
                                              where
                                              ba.DataPagamento.HasValue && ba.DataPagamento.Value == boletoAtividade.DataPagamento.Value
                                              select ba).ToList());
                            } pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (boletoAtividade.DataVencimento != default(DateTime))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from ba in Consultar()
                                                    where
                                                    ba.DataVencimento == boletoAtividade.DataVencimento
                                                    select ba).ToList());
                            }
                            else
                            {
                                resultado = ((from ba in Consultar()
                                              where
                                              ba.DataVencimento == boletoAtividade.DataVencimento
                                              select ba).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (boletoAtividade.Desconto.HasValue)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from ba in Consultar()
                                                    where
                                                    ba.Desconto.HasValue && ba.Desconto.Value == boletoAtividade.Desconto.Value
                                                    select ba).ToList());
                            }
                            else
                            {
                                resultado = ((from ba in Consultar()
                                              where
                                              ba.Desconto.HasValue && ba.Desconto.Value == boletoAtividade.Desconto.Value
                                              select ba).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (string.IsNullOrEmpty(boletoAtividade.Descricao))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from ba in Consultar()
                                                    where
                                                    ba.Descricao.Contains(boletoAtividade.Descricao)
                                                    select ba).ToList());
                            }
                            else
                            {
                                resultado = ((from ba in Consultar()
                                              where
                                              ba.Descricao.Contains(boletoAtividade.Descricao)
                                              select ba).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (boletoAtividade.Multa.HasValue)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from ba in Consultar()
                                                    where
                                                    ba.Multa.HasValue && ba.Multa.Value == boletoAtividade.Multa.Value
                                                    select ba).ToList());
                            }
                            else
                            {
                                resultado = ((from ba in Consultar()
                                              where
                                              ba.Multa.HasValue && ba.Multa.Value == boletoAtividade.Multa.Value
                                              select ba).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (boletoAtividade.Parcela.HasValue)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from ba in Consultar()
                                                    where
                                                    ba.Parcela.HasValue && ba.Parcela.Value == boletoAtividade.Parcela.Value
                                                    select ba).ToList());
                            }
                            else
                            {
                                resultado = ((from ba in Consultar()
                                              where
                                              ba.Parcela.HasValue && ba.Parcela.Value == boletoAtividade.Parcela.Value
                                              select ba).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (boletoAtividade.Status.HasValue && boletoAtividade.Status.Value != default(byte))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from ba in Consultar()
                                                    where
                                                    ba.Status.HasValue && ba.Status.Value == boletoAtividade.Status.Value
                                                    select ba).ToList());
                            }
                            else
                            {
                                resultado = ((from ba in Consultar()
                                              where
                                              ba.Status.HasValue && ba.Status.Value == boletoAtividade.Status.Value
                                              select ba).ToList());
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

        public void Incluir(BoletoAtividade boletoAtividade)
        {
            try
            {
                db.BoletoAtividade.InsertOnSubmit(boletoAtividade);
            }
            catch (Exception)
            {
                
                throw new BoletoAtividadeNaoIncluidaExcecao();
            }
        }

        public void Excluir(BoletoAtividade boletoAtividade)
        {
            try
            {
                BoletoAtividade boletoAtividadeAux = new BoletoAtividade();
                boletoAtividadeAux.ID = boletoAtividade.ID;

                List<BoletoAtividade> resultado = this.Consultar(boletoAtividadeAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new BoletoAtividadeNaoExcluidaExcecao();

                boletoAtividadeAux = resultado[0];

                db.BoletoAtividade.DeleteOnSubmit(boletoAtividadeAux);
               
            }
            catch (Exception)
            {
                
                throw new BoletoAtividadeNaoExcluidaExcecao();
            }
        }

        public void Alterar(BoletoAtividade boletoAtividade)
        {
            try
            {
                BoletoAtividade boletoAtividadeAux = new BoletoAtividade();
                boletoAtividadeAux.ID = boletoAtividade.ID;

                List<BoletoAtividade> resultado = this.Consultar(boletoAtividadeAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new BoletoAtividadeNaoAlteradaExcecao();

                boletoAtividadeAux = resultado[0];

                boletoAtividadeAux.DataEmissao = boletoAtividade.DataEmissao;
                boletoAtividadeAux.DataPagamento = boletoAtividade.DataPagamento;
                boletoAtividadeAux.DataVencimento = boletoAtividade.DataVencimento;
                boletoAtividadeAux.Desconto = boletoAtividade.Desconto;
                boletoAtividadeAux.Descricao = boletoAtividade.Descricao;
                boletoAtividadeAux.AlunoAtividadeTurma = boletoAtividade.AlunoAtividadeTurma;
                boletoAtividadeAux.AlunoAtividadeTurmaID= boletoAtividade.AlunoAtividadeTurmaID;
                boletoAtividadeAux.Multa = boletoAtividade.Multa;
                boletoAtividadeAux.Parcela = boletoAtividade.Parcela;
                boletoAtividadeAux.Status = boletoAtividade.Status;
                boletoAtividadeAux.Valor = boletoAtividade.Valor;

                Confirmar();
            }
            catch (Exception)
            {
                
                throw new BoletoAtividadeNaoAlteradaExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion      


    
    }
}