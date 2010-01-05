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
		
        #region Métodos da Interface

        public List<BoletoAtividade> Consultar()
        {
            return db.BoletoAtividade.ToList();
        }

        public List<BoletoAtividade> Consultar(BoletoAtividade boletoAtividade, TipoPesquisa tipoPesquisa)
        {
            List<BoletoAtividade> resultado = Consultar();

            switch (tipoPesquisa)
            {
                //#region Case E
                //case TipoPesquisa.E:
                //    {

                //        if (boletoAtividade.ID != 0)
                //        {
                //            resultado.AddRange((from ad in resultado
                //                                where
                //                                ad.ID == boletoAtividade.ID
                //                                select ad).ToList());
                //            resultado = resultado.Distinct().ToList();
                //        }

                //        if (boletoAtividade.DataEmissao.HasValue && boletoAtividade.DataEmissao.Value != default(DateTime))
                //        {
                //            resultado.AddRange((from ad in resultado
                //                                where
                //                                ad.DataEmissao.HasValue && ad.DataEmissao.Value == boletoAtividade.DataEmissao.Value
                //                                select ad).ToList());
                //            resultado = resultado.Distinct().ToList();
                //        }


                //        if (boletoAtividade.DiaSemana.HasValue && boletoAtividade.DiaSemana.Value != default(DateTime))
                //        {
                //            resultado.AddRange((from ad in resultado
                //                                where
                //                                ad.DiaSemana.HasValue && ad.DiaSemana.Value == boletoAtividade.DiaSemana.Value
                //                                select ad).ToList());
                //            resultado = resultado.Distinct().ToList();
                //        }

                //        if (boletoAtividade.HoraFim.HasValue && boletoAtividade.HoraFim.Value != default(DateTime))
                //        {
                //            resultado.AddRange((from ad in resultado
                //                                where
                //                                ad.HoraFim.HasValue && ad.HoraFim.Value == boletoAtividade.HoraFim.Value
                //                                select ad).ToList());
                //            resultado = resultado.Distinct().ToList();
                //        }

                //        if (boletoAtividade.HoraInicio.HasValue && boletoAtividade.HoraInicio.Value != default(DateTime))
                //        {
                //            resultado.AddRange((from ad in resultado
                //                                where
                //                                ad.HoraInicio.HasValue && ad.HoraInicio.Value == boletoAtividade.HoraInicio.Value
                //                                select ad).ToList());
                //            resultado = resultado.Distinct().ToList();
                //        }

                //        if (boletoAtividade.Status.HasValue && boletoAtividade.Status.Value != default(byte))
                //        {
                //            resultado.AddRange((from ad in resultado
                //                                where
                //                                ad.Status.HasValue && ad.Status.Value == boletoAtividade.Status.Value
                //                                select ad).ToList());
                //            resultado = resultado.Distinct().ToList();
                //        }

                //        break;
                //    }
                //#endregion
                //#region Case Ou
                //case TipoPesquisa.Ou:
                //    {
                //        if (atividadeData.ID != 0)
                //        {
                //            resultado.AddRange((from ad in db.AtividadeData
                //                                where
                //                                ad.ID == atividadeData.ID
                //                                select ad).ToList());
                //            resultado = resultado.Distinct().ToList();
                //        }

                //        if (atividadeData.AtividadeID.HasValue && atividadeData.AtividadeID.Value != 0)
                //        {
                //            resultado.AddRange((from ad in db.AtividadeData
                //                                where
                //                                ad.AtividadeID.HasValue && ad.AtividadeID.Value == atividadeData.AtividadeID.Value
                //                                select ad).ToList());
                //            resultado = resultado.Distinct().ToList();
                //        }


                //        if (atividadeData.DiaSemana.HasValue && atividadeData.DiaSemana.Value != default(DateTime))
                //        {
                //            resultado.AddRange((from ad in db.AtividadeData
                //                                where
                //                                ad.DiaSemana.HasValue && ad.DiaSemana.Value == atividadeData.DiaSemana.Value
                //                                select ad).ToList());
                //            resultado = resultado.Distinct().ToList();
                //        }

                //        if (atividadeData.HoraFim.HasValue && atividadeData.HoraFim.Value != default(DateTime))
                //        {
                //            resultado.AddRange((from ad in db.AtividadeData
                //                                where
                //                                ad.HoraFim.HasValue && ad.HoraFim.Value == atividadeData.HoraFim.Value
                //                                select ad).ToList());
                //            resultado = resultado.Distinct().ToList();
                //        }

                //        if (atividadeData.HoraInicio.HasValue && atividadeData.HoraInicio.Value != default(DateTime))
                //        {
                //            resultado.AddRange((from ad in db.AtividadeData
                //                                where
                //                                ad.HoraInicio.HasValue && ad.HoraInicio.Value == atividadeData.HoraInicio.Value
                //                                select ad).ToList());
                //            resultado = resultado.Distinct().ToList();
                //        }

                //        if (atividadeData.Status.HasValue && atividadeData.Status.Value != default(byte))
                //        {
                //            resultado.AddRange((from ad in db.AtividadeData
                //                                where
                //                                ad.Status.HasValue && ad.Status.Value == atividadeData.Status.Value
                //                                select ad).ToList());
                //            resultado = resultado.Distinct().ToList();
                //        }

                //        break;
                //    }
                //#endregion
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
                db.BoletoAtividade.DeleteOnSubmit(boletoAtividade);
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
                db.BoletoAtividade.InsertOnSubmit(boletoAtividade);
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