using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloAlunoAtividadeTurma.Excecoes;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloBasico.VOs;

namespace Negocios.ModuloAlunoAtividadeTurma.Repositorios
{
    public class AlunoAtividadeTurmaRepositorio : IAlunoAtividadeTurmaRepositorio
    {
        #region Atributos

        ColegioDB db;

        #endregion

        #region Métodos da Interface

        public List<AlunoAtividadeTurma> Consultar()
        {
            return db.AlunoAtividadeTurma.ToList();
        }

        public List<AlunoAtividadeTurma> Consultar(AlunoAtividadeTurma alunoAtividadeTurma, TipoPesquisa tipoPesquisa)
        {
            List<AlunoAtividadeTurma> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (alunoAtividadeTurma.ID != 0)
                        {

                            resultado = ((from aa in resultado
                                          where
                                          aa.ID == alunoAtividadeTurma.ID
                                          select aa).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (alunoAtividadeTurma.AlunoID != 0)
                        {

                            resultado = ((from aa in resultado
                                          where
                                          aa.AlunoID == alunoAtividadeTurma.AlunoID
                                          select aa).ToList());

                            resultado = resultado.Distinct().ToList();
                        }


                        if (alunoAtividadeTurma.Status.HasValue)
                        {

                            resultado = ((from aa in resultado
                                          where
                                          aa.Status.HasValue && aa.Status.Value == alunoAtividadeTurma.Status.Value
                                          select aa).ToList());

                            resultado = resultado.Distinct().ToList();
                        }


                        break;
                    }
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                        if (alunoAtividadeTurma.ID != 0)
                        {

                            resultado.AddRange((from aa in Consultar()
                                                where
                                                aa.ID == alunoAtividadeTurma.ID
                                                select aa).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (alunoAtividadeTurma.AlunoID != 0)
                        {

                            resultado.AddRange((from aa in Consultar()
                                                where
                                                aa.AlunoID == alunoAtividadeTurma.AlunoID
                                                select aa).ToList());

                            resultado = resultado.Distinct().ToList();
                        }


                        if (alunoAtividadeTurma.Status.HasValue)
                        {

                            resultado.AddRange((from aa in Consultar()
                                                where
                                                aa.Status.HasValue && aa.Status.Value == alunoAtividadeTurma.Status.Value
                                                select aa).ToList());

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

        public void Incluir(AlunoAtividadeTurma alunoAtividadeTurma)
        {
            try
            {
                db.AlunoAtividadeTurma.InsertOnSubmit(alunoAtividadeTurma);
            }
            catch (Exception)
            {

                throw new AlunoAtividadeTurmaNaoIncluidoExcecao();
            }
        }

        public void Excluir(AlunoAtividadeTurma alunoAtividadeTurma)
        {
            try
            {
                AlunoAtividadeTurma alunoAtividadeTurmaAux = new AlunoAtividadeTurma();
                alunoAtividadeTurmaAux.ID = alunoAtividadeTurma.ID;


                List<AlunoAtividadeTurma> resultado = this.Consultar(alunoAtividadeTurmaAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new AlunoAtividadeTurmaNaoExcluidoExcecao();

                alunoAtividadeTurmaAux = resultado[0];

                db.AlunoAtividadeTurma.DeleteOnSubmit(alunoAtividadeTurmaAux);

            }
            catch (Exception)
            {

                throw new AlunoAtividadeTurmaNaoExcluidoExcecao();
            }
        }

        public void Alterar(AlunoAtividadeTurma alunoAtividadeTurma)
        {
            try
            {
                AlunoAtividadeTurma alunoAtividadeTurmaAux = new AlunoAtividadeTurma();
                alunoAtividadeTurmaAux.ID = alunoAtividadeTurma.ID;


                List<AlunoAtividadeTurma> resultado = this.Consultar(alunoAtividadeTurmaAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new AlunoAtividadeTurmaNaoAlteradoExcecao();

                alunoAtividadeTurmaAux.AlunoID = alunoAtividadeTurma.AlunoID;
                alunoAtividadeTurmaAux.AtividadeTurmaID = alunoAtividadeTurma.AtividadeTurmaID;
                alunoAtividadeTurmaAux.Status = alunoAtividadeTurma.Status;
                alunoAtividadeTurmaAux.Ano = alunoAtividadeTurma.Ano;

                alunoAtividadeTurmaAux = resultado[0];

                Confirmar();
            }
            catch (Exception)
            {

                throw new AlunoAtividadeTurmaNaoAlteradoExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion

        #region Construtor
        public AlunoAtividadeTurmaRepositorio()
        {
            Conexao conexao = new Conexao();
            db = new ColegioDB(new MySqlConnection(conexao.ToString()));

        }
        #endregion


    }
}