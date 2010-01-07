using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloAlunoAtividade.Excecoes;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloAlunoAtividade.Repositorios
{
    public class AlunoAtividadeRepositorio: IAlunoAtividadeRepositorio
    {
		#region Atributos
		
        ColegioDB db = new ColegioDB(new MySqlConnection(BasicoConstantes.CONEXAO));
		
		#endregion      
		
        #region Métodos da Interface

        public List<AlunoAtividade> Consultar()
        {
            return db.AlunoAtividade.ToList();
        }

        public List<AlunoAtividade> Consultar(AlunoAtividade alunoAtividade, TipoPesquisa tipoPesquisa)
        {
            List<AlunoAtividade> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (alunoAtividade.ID != 0)
                        {
                            resultado.AddRange((from aa in resultado
                                                where
                                                aa.ID == alunoAtividade.ID
                                                select aa).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (alunoAtividade.AlunoID!= 0)
                        {
                            resultado.AddRange((from aa in resultado
                                                where
                                                aa.AlunoID == alunoAtividade.AlunoID
                                                select aa).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (alunoAtividade.AtividadeID != 0)
                        {
                            resultado.AddRange((from aa in resultado
                                                where
                                                aa.AtividadeID == alunoAtividade.AtividadeID
                                                select aa).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (alunoAtividade.DescontoID != 0)
                        {
                            resultado.AddRange((from aa in resultado
                                                where
                                                aa.DescontoID == alunoAtividade.DescontoID
                                                select aa).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (alunoAtividade.Status.HasValue)
                        {
                            resultado.AddRange((from aa in resultado
                                                where
                                                aa.Status.HasValue && aa.Status.Value == alunoAtividade.Status.Value
                                                select aa).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        
                        break;
                    }
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                        if (alunoAtividade.ID != 0)
                        {
                            resultado.AddRange((from aa in Consultar()
                                                where
                                                aa.ID == alunoAtividade.ID
                                                select aa).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (alunoAtividade.AlunoID != 0)
                        {
                            resultado.AddRange((from aa in Consultar()
                                                where
                                                aa.AlunoID == alunoAtividade.AlunoID
                                                select aa).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (alunoAtividade.AtividadeID != 0)
                        {
                            resultado.AddRange((from aa in Consultar()
                                                where
                                                aa.AtividadeID == alunoAtividade.AtividadeID
                                                select aa).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (alunoAtividade.DescontoID != 0)
                        {
                            resultado.AddRange((from aa in Consultar()
                                                where
                                                aa.DescontoID == alunoAtividade.DescontoID
                                                select aa).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (alunoAtividade.Status.HasValue)
                        {
                            resultado.AddRange((from aa in Consultar()
                                                where
                                                aa.Status.HasValue && aa.Status.Value == alunoAtividade.Status.Value
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

        public void Incluir(AlunoAtividade alunoAtividade)
        {
            try
            {
                db.AlunoAtividade.InsertOnSubmit(alunoAtividade);
            }
            catch (Exception)
            {
                
                throw new AlunoAtividadeNaoIncluidoExcecao();
            }
        }

        public void Excluir(AlunoAtividade alunoAtividade)
        {
            try
            {
                AlunoAtividade alunoAtividadeAux = new AlunoAtividade();
                alunoAtividadeAux.ID = alunoAtividade.ID;


                List<AlunoAtividade> resultado = this.Consultar(alunoAtividadeAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new AlunoAtividadeNaoExcluidoExcecao();

                alunoAtividadeAux = resultado[0];

                db.AlunoAtividade.DeleteOnSubmit(alunoAtividadeAux);
            
            }
            catch (Exception)
            {
                
                  throw new AlunoAtividadeNaoExcluidoExcecao();
            }
        }

        public void Alterar(AlunoAtividade alunoAtividade)
        {
            try
            {
                AlunoAtividade alunoAtividadeAux = new AlunoAtividade();
                alunoAtividadeAux.ID = alunoAtividade.ID;


                List<AlunoAtividade> resultado = this.Consultar(alunoAtividadeAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new AlunoAtividadeNaoAlteradoExcecao();

                alunoAtividadeAux.AlunoID = alunoAtividade.AlunoID;
                alunoAtividadeAux.AtividadeID = alunoAtividade.AtividadeID;
                alunoAtividadeAux.DescontoID = alunoAtividade.DescontoID;
                alunoAtividadeAux.Status= alunoAtividade.Status;

                alunoAtividadeAux = resultado[0];

                Confirmar();
            }
            catch (Exception)
            {
                
                 throw new AlunoAtividadeNaoAlteradoExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion      


    }
}