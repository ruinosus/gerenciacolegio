using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloCheque.Excecoes;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloBasico.VOs;

namespace Negocios.ModuloCheque.Repositorios
{
    public class ChequeRepositorio : IChequeRepositorio
    {
        #region Atributos

        ColegioDB db;

        #endregion

        #region Métodos da Interface

        public List<Cheque> Consultar()
        {
            return db.Cheque.ToList();
        }

        public List<Cheque> Consultar(Cheque cheque, TipoPesquisa tipoPesquisa)
        {
            List<Cheque> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (cheque.ID != 0)
                        {

                            resultado = ((from c in resultado
                                          where
                                          c.ID == cheque.ID
                                          select c).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (cheque.Parcela.HasValue)
                        {

                            resultado = ((from c in resultado
                                          where
                                          c.Parcela.HasValue && c.Parcela.Value == cheque.Parcela.Value
                                          select c).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(cheque.Agencia))
                        {

                            resultado = ((from c in resultado
                                          where
                                          c.Agencia.Contains(cheque.Agencia)
                                          select c).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(cheque.Banco))
                        {

                            resultado = ((from c in resultado
                                          where
                                          c.Banco.Contains(cheque.Banco)
                                          select c).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(cheque.Conta))
                        {

                            resultado = ((from c in resultado
                                          where
                                          c.Conta.Contains(cheque.Conta)
                                          select c).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(cheque.Cpf))
                        {

                            resultado = ((from c in resultado
                                          where
                                          c.Cpf.Contains(cheque.Cpf)
                                          select c).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (cheque.Tipo != 0)
                        {

                            resultado = ((from c in resultado
                                          where
                                          c.Tipo == cheque.Tipo
                                          select c).ToList());

                            resultado = resultado.Distinct().ToList();
                        }


                        if (cheque.Parcela.HasValue)
                        {

                            resultado = ((from c in resultado
                                          where
                                          c.Parcela.HasValue && c.Parcela.Value == cheque.Parcela.Value
                                          select c).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (cheque.NumCheque.HasValue)
                        {

                            resultado = ((from c in resultado
                                          where
                                          c.NumCheque.HasValue && c.NumCheque.Value == cheque.NumCheque.Value
                                          select c).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (cheque.Status.HasValue)
                        {

                            resultado = ((from c in resultado
                                          where
                                          c.Status.HasValue && c.Status.Value == cheque.Status.Value
                                          select c).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (cheque.Valor.HasValue)
                        {

                            resultado = ((from c in resultado
                                          where
                                          c.Valor.HasValue && c.Valor.Value == cheque.Valor.Value
                                          select c).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        break;
                    }
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                        if (cheque.ID != 0)
                        {
                            resultado.AddRange((from c in Consultar()
                                                where
                                                c.ID == cheque.ID
                                                select c).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (cheque.Parcela.HasValue)
                        {

                            resultado.AddRange((from c in Consultar()
                                                where
                                                c.Parcela.HasValue && c.Parcela.Value == cheque.Parcela.Value
                                                select c).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(cheque.Agencia))
                        {

                            resultado.AddRange((from c in Consultar()
                                                where
                                                c.Agencia.Contains(cheque.Agencia)
                                                select c).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(cheque.Banco))
                        {

                            resultado.AddRange((from c in Consultar()
                                                where
                                                c.Banco.Contains(cheque.Banco)
                                                select c).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(cheque.Conta))
                        {

                            resultado.AddRange((from c in Consultar()
                                                where
                                                c.Conta.Contains(cheque.Conta)
                                                select c).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(cheque.Cpf))
                        {

                            resultado.AddRange((from c in Consultar()
                                                where
                                                c.Cpf.Contains(cheque.Cpf)
                                                select c).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (cheque.Tipo != 0)
                        {

                            resultado.AddRange((from c in Consultar()
                                                where
                                                c.Tipo == cheque.Tipo
                                                select c).ToList());

                            resultado = resultado.Distinct().ToList();
                        }


                        if (cheque.Parcela.HasValue)
                        {

                            resultado.AddRange((from c in Consultar()
                                                where
                                                c.Parcela.HasValue && c.Parcela.Value == cheque.Parcela.Value
                                                select c).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (cheque.NumCheque.HasValue)
                        {

                            resultado.AddRange((from c in Consultar()
                                                where
                                                c.NumCheque.HasValue && c.NumCheque.Value == cheque.NumCheque.Value
                                                select c).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (cheque.Status.HasValue)
                        {

                            resultado.AddRange((from c in Consultar()
                                                where
                                                c.Status.HasValue && c.Status.Value == cheque.Status.Value
                                                select c).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (cheque.Valor.HasValue)
                        {

                            resultado.AddRange((from c in Consultar()
                                                where
                                                c.Valor.HasValue && c.Valor.Value == cheque.Valor.Value
                                                select c).ToList());

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

        public void Incluir(Cheque cheque)
        {
            try
            {
                db.Cheque.InsertOnSubmit(cheque);
            }
            catch (Exception)
            {

                throw new ChequeNaoIncluidoExcecao();
            }
        }

        public void Excluir(Cheque cheque)
        {
            try
            {
                Cheque chequeAux = new Cheque();
                chequeAux.ID = cheque.ID;


                List<Cheque> resultado = this.Consultar(chequeAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new ChequeNaoExcluidoExcecao();

                chequeAux = resultado[0];

                db.Cheque.DeleteOnSubmit(chequeAux);

            }
            catch (Exception)
            {

                throw new ChequeNaoExcluidoExcecao();
            }
        }

        public void Alterar(Cheque cheque)
        {
            try
            {
                Cheque chequeAux = new Cheque();
                chequeAux.ID = cheque.ID;


                List<Cheque> resultado = this.Consultar(chequeAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new ChequeNaoAlteradoExcecao();

                chequeAux.Agencia = cheque.Agencia;
                chequeAux.Banco = cheque.Banco;
                chequeAux.Conta = cheque.Conta;
                chequeAux.Cpf = cheque.Cpf;
                chequeAux.NumCheque = cheque.NumCheque;
                chequeAux.Parcela = cheque.Parcela;
                chequeAux.Status = cheque.Status;
                chequeAux.Tipo = cheque.Tipo;
                chequeAux.Valor = cheque.Valor;

                chequeAux = resultado[0];

                Confirmar();
            }
            catch (Exception)
            {

                throw new ChequeNaoAlteradoExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion

        #region Construtor
        public ChequeRepositorio()
        {
            Conexao conexao = new Conexao();
            db = new ColegioDB(new MySqlConnection(conexao.ToString()));

        }
        #endregion


    }
}