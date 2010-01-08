using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloChequeBoletoAtividade.Excecoes;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloChequeBoletoAtividade.Repositorios
{
    public class ChequeBoletoAtividadeRepositorio: IChequeBoletoAtividadeRepositorio
    {
		#region Atributos
		
        ColegioDB db = new ColegioDB(new MySqlConnection(BasicoConstantes.CONEXAO));
		
		#endregion      
		
        #region Métodos da Interface

        public List<ChequeBoletoAtividade> Consultar()
        {
            return db.ChequeBoletoAtividade.ToList();
        }

        public List<ChequeBoletoAtividade> Consultar(ChequeBoletoAtividade chequeBoletoAtividade, TipoPesquisa tipoPesquisa)
        {
            List<ChequeBoletoAtividade> resultado = Consultar();
            bool pesquisa = false;
            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (chequeBoletoAtividade.ID != 0)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from cba in resultado
                                                    where
                                                    cba.ID == chequeBoletoAtividade.ID
                                                    select cba).ToList());
                            }
                            else
                            {
                                resultado=((from cba in resultado
                                                    where
                                                    cba.ID == chequeBoletoAtividade.ID
                                                    select cba).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (chequeBoletoAtividade.BoletoAtividadeID != 0)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from cba in resultado
                                                    where
                                                    cba.BoletoAtividadeID == chequeBoletoAtividade.BoletoAtividadeID
                                                    select cba).ToList());
                            }
                            else
                            {
                                resultado=((from cba in resultado
                                                    where
                                                    cba.BoletoAtividadeID == chequeBoletoAtividade.BoletoAtividadeID
                                                    select cba).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (chequeBoletoAtividade.ChequeID != 0)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from cba in resultado
                                                    where
                                                    cba.ChequeID == chequeBoletoAtividade.ChequeID
                                                    select cba).ToList());
                            }
                            else
                            {
                                resultado=((from cba in resultado
                                                    where
                                                    cba.ChequeID == chequeBoletoAtividade.ChequeID
                                                    select cba).ToList());
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
                        if (chequeBoletoAtividade.ID != 0)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from cba in Consultar()
                                                    where
                                                    cba.ID == chequeBoletoAtividade.ID
                                                    select cba).ToList());
                            }
                            else
                            {
                                resultado = ((from cba in Consultar()
                                              where
                                              cba.ID == chequeBoletoAtividade.ID
                                              select cba).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (chequeBoletoAtividade.BoletoAtividadeID != 0)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from cba in Consultar()
                                                    where
                                                    cba.BoletoAtividadeID == chequeBoletoAtividade.BoletoAtividadeID
                                                    select cba).ToList());
                            }
                            else
                            {
                                resultado = ((from cba in Consultar()
                                              where
                                              cba.BoletoAtividadeID == chequeBoletoAtividade.BoletoAtividadeID
                                              select cba).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (chequeBoletoAtividade.ChequeID != 0)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from cba in Consultar()
                                                    where
                                                    cba.ChequeID == chequeBoletoAtividade.ChequeID
                                                    select cba).ToList());
                            }
                            else
                            {
                                resultado = ((from cba in Consultar()
                                              where
                                              cba.ChequeID == chequeBoletoAtividade.ChequeID
                                              select cba).ToList());
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

        public void Incluir(ChequeBoletoAtividade chequeBoletoAtividade)
        {
            try
            {
                db.ChequeBoletoAtividade.InsertOnSubmit(chequeBoletoAtividade);
            }
            catch (Exception)
            {
                
                throw new ChequeBoletoAtividadeNaoIncluidaExcecao();
            }
        }

        public void Excluir(ChequeBoletoAtividade chequeBoletoAtividade)
        {
            try
            {
                ChequeBoletoAtividade chequeBoletoAtividadeAux = new ChequeBoletoAtividade();
                chequeBoletoAtividadeAux.ID = chequeBoletoAtividade.ID;

                List<ChequeBoletoAtividade> resultado = this.Consultar(chequeBoletoAtividadeAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new ChequeBoletoAtividadeNaoExcluidaExcecao();

                chequeBoletoAtividadeAux = resultado[0];

                db.ChequeBoletoAtividade.DeleteOnSubmit(chequeBoletoAtividadeAux);
            
            }
            catch (Exception)
            {
                
                  throw new ChequeBoletoAtividadeNaoExcluidaExcecao();
            }
        }

        public void Alterar(ChequeBoletoAtividade chequeBoletoAtividade)
        {
            try
            {
                ChequeBoletoAtividade chequeBoletoAtividadeAux = new ChequeBoletoAtividade();
                chequeBoletoAtividadeAux.ID = chequeBoletoAtividade.ID;
                

                List<ChequeBoletoAtividade> resultado = this.Consultar(chequeBoletoAtividadeAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new ChequeBoletoAtividadeNaoAlteradaExcecao();

                chequeBoletoAtividadeAux = resultado[0];

                chequeBoletoAtividadeAux.BoletoAtividadeID = chequeBoletoAtividade.BoletoAtividadeID;
                chequeBoletoAtividadeAux.ChequeID = chequeBoletoAtividade.ChequeID;
                chequeBoletoAtividadeAux.Status = chequeBoletoAtividade.Status;                
                Confirmar();
            }
            catch (Exception)
            {
                
                  throw new ChequeBoletoAtividadeNaoAlteradaExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion      
         

    
    }
}