using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloAtividade.Excecoes;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloAtividade.Repositorios
{
    public class AtividadeRepositorio: IAtividadeRepositorio
    {
		#region Atributos
		
        ColegioDB db = new ColegioDB(new MySqlConnection(BasicoConstantes.CONEXAO));
		
		#endregion      
		
        #region Métodos da Interface

        public List<Atividade> Consultar()
        {
            return db.Atividade.ToList();
        }

        public List<Atividade> Consultar(Atividade atividade, TipoPesquisa tipoPesquisa)
        {
            List<Atividade> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (atividade.ID != 0)
                        {
                            resultado.AddRange((from a in resultado
                                                where
                                                a.ID == atividade.ID
                                                select a).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (atividade.Valor.HasValue)
                        {
                            resultado.AddRange((from a in resultado
                                                where
                                                a.Valor.HasValue && a.Valor.Value == atividade.Valor.Value
                                                select a).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(atividade.Nome))
                        {
                            resultado.AddRange((from a in resultado
                                                where
                                                a.Nome.Contains(atividade.Nome)
                                                select a).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (atividade.FuncionarioID.HasValue)
                        {
                            resultado.AddRange((from a in resultado
                                                where
                                                a.FuncionarioID.HasValue && a.FuncionarioID.Value == atividade.FuncionarioID.Value
                                                select a).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(atividade.Descricao))
                        {
                            resultado.AddRange((from a in resultado
                                                where
                                                a.Descricao.Contains(atividade.Descricao)
                                                select a).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (atividade.Status.HasValue)
                        {
                            resultado.AddRange((from a in resultado
                                                where
                                                a.Status.HasValue && a.Status.Value == atividade.Status.Value
                                                select a).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (atividade.Valor.HasValue)
                        {
                            resultado.AddRange((from a in resultado
                                                where
                                                a.Valor.HasValue && a.Valor.Value == atividade.Valor.Value
                                                select a).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        break;
                    }
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                        if (atividade.ID != 0)
                        {
                            resultado.AddRange((from a in Consultar()
                                                where
                                                a.ID == atividade.ID
                                                select a).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (atividade.Valor.HasValue)
                        {
                            resultado.AddRange((from a in Consultar()
                                                where
                                                a.Valor.HasValue && a.Valor.Value == atividade.Valor.Value
                                                select a).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(atividade.Nome))
                        {
                            resultado.AddRange((from a in Consultar()
                                                where
                                                a.Nome.Contains(atividade.Nome)
                                                select a).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (atividade.FuncionarioID.HasValue)
                        {
                            resultado.AddRange((from a in Consultar()
                                                where
                                                a.FuncionarioID.HasValue && a.FuncionarioID.Value == atividade.FuncionarioID.Value
                                                select a).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(atividade.Descricao))
                        {
                            resultado.AddRange((from a in Consultar()
                                                where
                                                a.Descricao.Contains(atividade.Descricao)
                                                select a).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (atividade.Status.HasValue)
                        {
                            resultado.AddRange((from a in Consultar()
                                                where
                                                a.Status.HasValue && a.Status.Value == atividade.Status.Value
                                                select a).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (atividade.Valor.HasValue)
                        {
                            resultado.AddRange((from a in Consultar()
                                                where
                                                a.Valor.HasValue && a.Valor.Value == atividade.Valor.Value
                                                select a).ToList());
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

        public void Incluir(Atividade atividade)
        {
            try
            {
                db.Atividade.InsertOnSubmit(atividade);
            }
            catch (Exception)
            {
                
                throw new AtividadeNaoIncluidaExcecao();
            }
        }

        public void Excluir(Atividade atividade)
        {
            try
            {
                Atividade atividadeAux = new Atividade();
                atividadeAux.ID = atividade.ID;


                List<Atividade> resultado = this.Consultar(atividadeAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new AtividadeNaoExcluidaExcecao();

                atividadeAux = resultado[0];

                db.Atividade.DeleteOnSubmit(atividadeAux);
            
            }
            catch (Exception)
            {
                throw new AtividadeNaoExcluidaExcecao();
            }
        }

        public void Alterar(Atividade atividade)
        {
            try
            {
                Atividade atividadeAux = new Atividade();
                atividadeAux.ID = atividade.ID;


                List<Atividade> resultado = this.Consultar(atividadeAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new AtividadeNaoExcluidaExcecao();

                atividadeAux = resultado[0];
                atividadeAux.AtividadeData = atividade.AtividadeData;
                atividadeAux.Descricao = atividade.Descricao;
                atividadeAux.FuncionarioID = atividade.FuncionarioID;
                atividadeAux.Imagem= atividade.Imagem;
                atividadeAux.Nome= atividade.Nome;
                atividadeAux.Status= atividade.Status;
                atividadeAux.Valor= atividade.Valor;

                Confirmar();
            }
            catch (Exception)
            {
                
                 throw new AtividadeNaoAlteradaExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion      


    
    }
}