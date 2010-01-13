using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloAtividadeTurma.Excecoes;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloAtividadeTurma.Repositorios
{
    public class AtividadeTurmaRepositorio : IAtividadeTurmaRepositorio
    {
        #region Atributos

        ColegioDB db = new ColegioDB(new MySqlConnection(BasicoConstantes.CONEXAO));

        #endregion

        #region Métodos da Interface

        public List<AtividadeTurma> Consultar()
        {
            return db.AtividadeTurma.ToList();
        }

        public List<AtividadeTurma> Consultar(AtividadeTurma atividadeTurma, TipoPesquisa tipoPesquisa)
        {
            List<AtividadeTurma> resultado = Consultar();
            bool pesquisa = false;
            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {

                        if (atividadeTurma.ID != 0)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from ad in resultado
                                                    where
                                                    ad.ID == atividadeTurma.ID
                                                    select ad).ToList());
                            }
                            else
                            {
                                resultado = ((from ad in resultado
                                              where
                                              ad.ID == atividadeTurma.ID
                                              select ad).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (atividadeTurma.AtividadeID.HasValue && atividadeTurma.AtividadeID.Value != 0)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from ad in resultado
                                                    where
                                                    ad.AtividadeID.HasValue && ad.AtividadeID.Value == atividadeTurma.AtividadeID.Value
                                                    select ad).ToList());
                            }
                            else
                            {
                                resultado = ((from ad in resultado
                                              where
                                              ad.AtividadeID.HasValue && ad.AtividadeID.Value == atividadeTurma.AtividadeID.Value
                                              select ad).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }




                        if (atividadeTurma.Status.HasValue && atividadeTurma.Status.Value != default(byte))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from ad in resultado
                                                    where
                                                    ad.Status.HasValue && ad.Status.Value == atividadeTurma.Status.Value
                                                    select ad).ToList());
                            }
                            else
                            {
                                resultado = ((from ad in resultado
                                              where
                                              ad.Status.HasValue && ad.Status.Value == atividadeTurma.Status.Value
                                              select ad).ToList());
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

                        if (atividadeTurma.ID != 0)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from ad in Consultar()
                                                    where
                                                    ad.ID == atividadeTurma.ID
                                                    select ad).ToList());
                            }
                            else
                            {
                                resultado = ((from ad in Consultar()
                                              where
                                              ad.ID == atividadeTurma.ID
                                              select ad).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (atividadeTurma.AtividadeID.HasValue && atividadeTurma.AtividadeID.Value != 0)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from ad in Consultar()
                                                    where
                                                    ad.AtividadeID.HasValue && ad.AtividadeID.Value == atividadeTurma.AtividadeID.Value
                                                    select ad).ToList());
                            }
                            else
                            {
                                resultado = ((from ad in Consultar()
                                              where
                                              ad.AtividadeID.HasValue && ad.AtividadeID.Value == atividadeTurma.AtividadeID.Value
                                              select ad).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }


                        

                        if (atividadeTurma.Status.HasValue && atividadeTurma.Status.Value != default(byte))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from ad in Consultar()
                                                    where
                                                    ad.Status.HasValue && ad.Status.Value == atividadeTurma.Status.Value
                                                    select ad).ToList());
                            }
                            else
                            {
                                resultado = ((from ad in Consultar()
                                              where
                                              ad.Status.HasValue && ad.Status.Value == atividadeTurma.Status.Value
                                              select ad).ToList());
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

        public void Incluir(AtividadeTurma atividadeTurma)
        {
            try
            {
                db.AtividadeTurma.InsertOnSubmit(atividadeTurma);
            }
            catch (Exception)
            {

                throw new AtividadeTurmaNaoIncluidaExcecao();
            }
        }

        public void Excluir(AtividadeTurma atividadeTurma)
        {
            try
            {
                AtividadeTurma atividadeTurmaAux = new AtividadeTurma();
                atividadeTurmaAux.ID = atividadeTurma.ID;

                List<AtividadeTurma> resultado = this.Consultar(atividadeTurmaAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new AtividadeTurmaNaoExcluidaExcecao();

                atividadeTurmaAux = resultado[0];

                db.AtividadeTurma.DeleteOnSubmit(atividadeTurmaAux);
            }
            catch (Exception)
            {

                throw new AtividadeTurmaNaoExcluidaExcecao();
            }
        }

        public void Alterar(AtividadeTurma atividadeTurma)
        {
            try
            {
                AtividadeTurma atividadeTurmaAux = new AtividadeTurma();
                atividadeTurmaAux.ID = atividadeTurma.ID;

                List<AtividadeTurma> resultado = this.Consultar(atividadeTurmaAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new AtividadeTurmaNaoAlteradaExcecao();

                atividadeTurmaAux = resultado[0];

                atividadeTurmaAux.AtividadeID = atividadeTurma.AtividadeID;
                atividadeTurmaAux.Atividade = atividadeTurma.Atividade;
                atividadeTurmaAux.HoraFim = atividadeTurma.HoraFim;
                atividadeTurmaAux.HoraInicio = atividadeTurma.HoraInicio;
                atividadeTurmaAux.Status = atividadeTurma.Status;
                atividadeTurmaAux.Valor = atividadeTurma.Valor;
                atividadeTurmaAux.Domingo = atividadeTurma.Domingo;
                atividadeTurmaAux.Segunda = atividadeTurma.Segunda;
                atividadeTurmaAux.Terca = atividadeTurma.Terca;
                atividadeTurmaAux.Quarta = atividadeTurma.Quarta;
                atividadeTurmaAux.Quinta = atividadeTurma.Quinta;
                atividadeTurmaAux.Sexta = atividadeTurma.Sexta;
                atividadeTurmaAux.Sabado = atividadeTurma.Sabado;


                Confirmar();
            }
            catch (Exception)
            {
                throw new AtividadeTurmaNaoAlteradaExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion
    }
}