using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloChequeBoletoMensalidade.Excecoes;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloChequeBoletoMensalidade.Repositorios
{
    public class ChequeBoletoMensalidadeRepositorio: IChequeBoletoMensalidadeRepositorio
    {
		#region Atributos
		
        ColegioDB db = new ColegioDB(new MySqlConnection(BasicoConstantes.CONEXAO));
		
		#endregion      
		
        #region M�todos da Interface

        public List<ChequeBoletoMensalidade> Consultar()
        {
            return db.ChequeBoletoMensalidade.ToList();
        }

        public List<ChequeBoletoMensalidade> Consultar(ChequeBoletoMensalidade chequeBoletoMensalidade, TipoPesquisa tipoPesquisa)
        {
            List<ChequeBoletoMensalidade> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (chequeBoletoMensalidade.BoletoMensalidadeID != 0)
                        {
                            resultado.AddRange((from cbm in resultado
                                                where
                                                cbm.BoletoMensalidadeID == chequeBoletoMensalidade.BoletoMensalidadeID
                                                select cbm).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (chequeBoletoMensalidade.ChequeID != 0)
                        {
                            resultado.AddRange((from cbm in resultado
                                                where
                                                cbm.ChequeID == chequeBoletoMensalidade.ChequeID
                                                select cbm).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        break;
                    }
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                        if (chequeBoletoMensalidade.BoletoMensalidadeID != 0)
                        {
                            resultado.AddRange((from cbm in Consultar()
                                                where
                                                cbm.BoletoMensalidadeID == chequeBoletoMensalidade.BoletoMensalidadeID
                                                select cbm).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (chequeBoletoMensalidade.ChequeID != 0)
                        {
                            resultado.AddRange((from cbm in Consultar()
                                                where
                                                cbm.ChequeID == chequeBoletoMensalidade.ChequeID
                                                select cbm).ToList());
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

        public void Incluir(ChequeBoletoMensalidade chequeBoletoMensalidade)
        {
            try
            {
                db.ChequeBoletoMensalidade.InsertOnSubmit(chequeBoletoMensalidade);
            }
            catch (Exception)
            {
                
                throw new ChequeBoletoMensalidadeNaoIncluidaExcecao();
            }
        }

        public void Excluir(ChequeBoletoMensalidade chequeBoletoMensalidade)
        {
            try
            {
                ChequeBoletoMensalidade chequeBoletoMensalidadeAux = new ChequeBoletoMensalidade();
                chequeBoletoMensalidadeAux.BoletoMensalidadeID = chequeBoletoMensalidade.BoletoMensalidadeID;
                chequeBoletoMensalidadeAux.ChequeID = chequeBoletoMensalidade.ChequeID;

                List<ChequeBoletoMensalidade> resultado = this.Consultar(chequeBoletoMensalidadeAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new ChequeBoletoMensalidadeNaoExcluidaExcecao();

                chequeBoletoMensalidadeAux = resultado[0];

                db.ChequeBoletoMensalidade.DeleteOnSubmit(chequeBoletoMensalidadeAux);
            
            }
            catch (Exception)
            {
                throw new ChequeBoletoMensalidadeNaoExcluidaExcecao();
            }
        }

        public void Alterar(ChequeBoletoMensalidade chequeBoletoMensalidade)
        {
            try
            {
                ChequeBoletoMensalidade chequeBoletoMensalidadeAux = new ChequeBoletoMensalidade();
                chequeBoletoMensalidadeAux.BoletoMensalidadeID = chequeBoletoMensalidade.BoletoMensalidadeID;
                chequeBoletoMensalidadeAux.ChequeID = chequeBoletoMensalidade.ChequeID;

                List<ChequeBoletoMensalidade> resultado = this.Consultar(chequeBoletoMensalidadeAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new ChequeBoletoMensalidadeNaoAlteradaExcecao();

                chequeBoletoMensalidadeAux = resultado[0];

                chequeBoletoMensalidadeAux.BoletoMensalidadeID = chequeBoletoMensalidade.BoletoMensalidadeID;
                chequeBoletoMensalidadeAux.ChequeID = chequeBoletoMensalidade.ChequeID;

                Confirmar();
            }
            catch (Exception)
            {
                
                throw new ChequeBoletoMensalidadeNaoAlteradaExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion      


    
    }
}