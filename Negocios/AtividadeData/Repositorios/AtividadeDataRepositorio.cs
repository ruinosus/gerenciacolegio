using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloAtividadeData.Excecoes;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloAtividadeData.Repositorios
{
    public class AtividadeDataRepositorio : IAtividadeDataRepositorio
    {
        #region Atributos

        ColegioDB db = new ColegioDB(new MySqlConnection(BasicoConstantes.CONEXAO));

        #endregion

        #region Métodos da Interface

        public List<AtividadeData> Consultar()
        {
            return db.AtividadeData.ToList();
        }

        public List<AtividadeData> Consultar(AtividadeData atividadeData, TipoPesquisa tipoPesquisa)
        {
            List<AtividadeData> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {

                        if (atividadeData.ID != 0)
                        {
                            resultado.AddRange((from ad in resultado
                                                where
                                                ad.ID == atividadeData.ID
                                                select ad).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (atividadeData.AtividadeID.HasValue && atividadeData.AtividadeID.Value != 0)
                        {
                            resultado.AddRange((from ad in resultado
                                                where
                                                ad.AtividadeID.HasValue && ad.AtividadeID.Value == atividadeData.AtividadeID.Value
                                                select ad).ToList());
                            resultado = resultado.Distinct().ToList();
                        }


                        if (atividadeData.DiaSemana.HasValue && atividadeData.DiaSemana.Value != default(DateTime))
                        {
                            resultado.AddRange((from ad in resultado
                                                where
                                                ad.DiaSemana.HasValue && ad.DiaSemana.Value == atividadeData.DiaSemana.Value
                                                select ad).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (atividadeData.HoraFim.HasValue && atividadeData.HoraFim.Value != default(DateTime))
                        {
                            resultado.AddRange((from ad in resultado
                                                where
                                                ad.HoraFim.HasValue && ad.HoraFim.Value == atividadeData.HoraFim.Value
                                                select ad).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (atividadeData.HoraInicio.HasValue && atividadeData.HoraInicio.Value != default(DateTime))
                        {
                            resultado.AddRange((from ad in resultado
                                                where
                                                ad.HoraInicio.HasValue && ad.HoraInicio.Value == atividadeData.HoraInicio.Value
                                                select ad).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (atividadeData.Status.HasValue && atividadeData.Status.Value != default(byte))
                        {
                            resultado.AddRange((from ad in resultado
                                                where
                                                ad.Status.HasValue && ad.Status.Value == atividadeData.Status.Value
                                                select ad).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        break;
                    }
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                        if (atividadeData.ID != 0)
                        {
                            resultado.AddRange((from ad in db.AtividadeData
                                                where
                                                ad.ID == atividadeData.ID
                                                select ad).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (atividadeData.AtividadeID.HasValue && atividadeData.AtividadeID.Value != 0)
                        {
                            resultado.AddRange((from ad in db.AtividadeData
                                                where
                                                ad.AtividadeID.HasValue && ad.AtividadeID.Value == atividadeData.AtividadeID.Value
                                                select ad).ToList());
                            resultado = resultado.Distinct().ToList();
                        }


                        if (atividadeData.DiaSemana.HasValue && atividadeData.DiaSemana.Value != default(DateTime))
                        {
                            resultado.AddRange((from ad in db.AtividadeData
                                                where
                                                ad.DiaSemana.HasValue && ad.DiaSemana.Value == atividadeData.DiaSemana.Value
                                                select ad).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (atividadeData.HoraFim.HasValue && atividadeData.HoraFim.Value != default(DateTime))
                        {
                            resultado.AddRange((from ad in db.AtividadeData
                                                where
                                                ad.HoraFim.HasValue && ad.HoraFim.Value == atividadeData.HoraFim.Value
                                                select ad).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (atividadeData.HoraInicio.HasValue && atividadeData.HoraInicio.Value != default(DateTime))
                        {
                            resultado.AddRange((from ad in db.AtividadeData
                                                where
                                                ad.HoraInicio.HasValue && ad.HoraInicio.Value == atividadeData.HoraInicio.Value
                                                select ad).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (atividadeData.Status.HasValue && atividadeData.Status.Value != default(byte))
                        {
                            resultado.AddRange((from ad in db.AtividadeData
                                                where
                                                ad.Status.HasValue && ad.Status.Value == atividadeData.Status.Value
                                                select ad).ToList());
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

        public void Incluir(AtividadeData atividadeData)
        {
            try
            {
                db.AtividadeData.InsertOnSubmit(atividadeData);
            }
            catch (Exception)
            {

                throw new AtividadeDataNaoIncluidaExcecao();
            }
        }

        public void Excluir(AtividadeData atividadeData)
        {
            try
            {
                AtividadeData atividadeDataAux = new AtividadeData();
                atividadeDataAux.ID = atividadeData.ID;

                List<AtividadeData> resultado = this.Consultar(atividadeDataAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new AtividadeDataNaoExcluidaExcecao();

                atividadeDataAux = resultado[0];

                db.AtividadeData.DeleteOnSubmit(atividadeDataAux);
            }
            catch (Exception)
            {

                throw new AtividadeDataNaoExcluidaExcecao();
            }
        }

        public void Alterar(AtividadeData atividadeData)
        {
            try
            {
                AtividadeData atividadeDataAux = new AtividadeData();
                atividadeDataAux.ID = atividadeData.ID;

                List<AtividadeData> resultado = this.Consultar(atividadeDataAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new AtividadeDataNaoAlteradaExcecao();

                atividadeDataAux = resultado[0];

                atividadeDataAux.AtividadeID = atividadeData.AtividadeID;
                atividadeDataAux.Atividade = atividadeData.Atividade;
                atividadeDataAux.DiaSemana = atividadeData.DiaSemana;
                atividadeDataAux.HoraFim = atividadeData.HoraFim;
                atividadeDataAux.HoraInicio = atividadeData.HoraInicio;
                atividadeDataAux.Status = atividadeData.Status;

                Confirmar();
            }
            catch (Exception)
            {
                throw new AtividadeDataNaoAlteradaExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion
    }
}