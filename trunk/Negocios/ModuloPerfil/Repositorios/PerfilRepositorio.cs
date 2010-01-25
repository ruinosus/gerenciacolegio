using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloPerfil.Excecoes;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloBasico.VOs;

namespace Negocios.ModuloPerfil.Repositorios
{
    public class PerfilRepositorio : IPerfilRepositorio
    {
        #region Atributos

        ColegioDB db;

        #endregion

        #region Métodos da Interface

        public List<Perfil> Consultar()
        {
            return db.Perfil.ToList();
        }

        public List<Perfil> Consultar(Perfil perfil, TipoPesquisa tipoPesquisa)
        {
            List<Perfil> resultado = Consultar();
            bool pesquisa = false;
            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (perfil.ID != 0)
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.ID == perfil.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (perfil.Status.HasValue)
                        {

                            resultado = ((from d in resultado
                                          where
                                          d.Status.HasValue && d.Status.Value == perfil.Status.Value
                                          select d).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(perfil.Descricao))
                        {

                            resultado = ((from d in resultado
                                          where
                                           d.Descricao.Contains(perfil.Descricao)
                                          select d).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        break;
                    }
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                        if (perfil.ID != 0)
                        {

                            resultado.AddRange((from p in Consultar()
                                                where
                                                p.ID == perfil.ID
                                                select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (perfil.Status.HasValue)
                        {

                            resultado.AddRange((from d in Consultar()
                                                where
                                                d.Status.HasValue && d.Status.Value == perfil.Status.Value
                                                select d).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(perfil.Descricao))
                        {

                            resultado.AddRange((from d in Consultar()
                                                where
                                                 d.Descricao.Contains(perfil.Descricao)
                                                select d).ToList());

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

        public void Incluir(Perfil perfil)
        {
            try
            {
                db.Perfil.InsertOnSubmit(perfil);
            }
            catch (Exception)
            {

                throw new PerfilNaoIncluidoExcecao();
            }
        }

        public void Excluir(Perfil perfil)
        {
            try
            {
                Perfil perfilAux = new Perfil();
                perfilAux.ID = perfil.ID;

                List<Perfil> resultado = this.Consultar(perfilAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new PerfilNaoExcluidoExcecao();

                perfilAux = resultado[0];

                db.Perfil.DeleteOnSubmit(perfilAux);
            }
            catch (Exception)
            {

                throw new PerfilNaoExcluidoExcecao();
            }
        }

        public void Alterar(Perfil perfil)
        {
            try
            {
                Perfil perfilAux = new Perfil();
                perfilAux.ID = perfil.ID;

                List<Perfil> resultado = this.Consultar(perfilAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new PerfilNaoAlteradoExcecao();

                perfilAux = resultado[0];

                perfilAux.CtrlAdvertenciasAtrasos = perfil.CtrlAdvertenciasAtrasos;
                perfilAux.CtrlAluno = perfil.CtrlAluno;
                perfilAux.CtrlAniversariantes = perfil.CtrlAniversariantes;
                perfilAux.CtrlAnotacoes = perfil.CtrlAnotacoes;
                perfilAux.CtrlAtividade = perfil.CtrlAtividade;
                perfilAux.CtrlBoletim = perfil.CtrlBoletim;
                perfilAux.CtrlCertificados = perfil.CtrlCertificados;
                perfilAux.CtrlCheques = perfil.CtrlCheques;
                perfilAux.CtrlContasPagar = perfil.CtrlContasPagar;
                perfilAux.CtrlDebitos = perfil.CtrlDebitos;
                perfilAux.CtrlDeclaracaoQuitacao = perfil.CtrlDeclaracaoQuitacao;
                perfilAux.CtrlEmails = perfil.CtrlEmails;
                perfilAux.CtrlFinanceiro = perfil.CtrlFinanceiro;
                perfilAux.CtrlFolhaChamada = perfil.CtrlFolhaChamada;
                perfilAux.CtrlFolhaPonto = perfil.CtrlFolhaPonto;
                perfilAux.CtrlFreqAlunos = perfil.CtrlFreqAlunos;
                perfilAux.CtrlFreqFuncionarios = perfil.CtrlFreqFuncionarios;
                perfilAux.CtrlFuncionario = perfil.CtrlFuncionario;
                perfilAux.CtrlGre = perfil.CtrlGre;
                perfilAux.CtrlMensalidade = perfil.CtrlMensalidade;
                perfilAux.CtrlNotas = perfil.CtrlNotas;
                perfilAux.CtrlRankingNotas = perfil.CtrlRankingNotas;
                perfilAux.CtrlRemanejamento = perfil.CtrlRemanejamento;
                perfilAux.CtrlSerie = perfil.CtrlSerie;
                perfilAux.CtrlTransfHistoricos = perfil.CtrlTransfHistoricos;
                perfilAux.CtrlTurma = perfil.CtrlTurma;
                perfilAux.CtrlTurno = perfil.CtrlTurno;
                perfilAux.Descricao = perfil.Descricao;
                perfilAux.Status = perfil.Status;

                Confirmar();
            }
            catch (Exception)
            {

                throw new PerfilNaoAlteradoExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion

        #region Construtor
        public PerfilRepositorio()
        {
            Conexao conexao = new Conexao();
            db = new ColegioDB(new MySqlConnection(conexao.ToString()));

        }
        #endregion


    }
}