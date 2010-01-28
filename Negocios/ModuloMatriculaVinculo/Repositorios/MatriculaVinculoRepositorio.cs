using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloMatriculaVinculo.Excecoes;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloBasico.VOs;

namespace Negocios.ModuloMatriculaVinculo.Repositorios
{
    public class MatriculaVinculoRepositorio : IMatriculaVinculoRepositorio
    {
        #region Atributos

        ColegioDB db;

        #endregion

        #region Métodos da Interface

        public List<MatriculaVinculo> Consultar()
        {
            return db.MatriculaVinculo.ToList();
        }

        public List<MatriculaVinculo> Consultar(MatriculaVinculo matriculaVinculo, TipoPesquisa tipoPesquisa)
        {
            List<MatriculaVinculo> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (matriculaVinculo.ID != 0)
                        {
                            resultado = ((from m in resultado
                                          where
                                          m.ID == matriculaVinculo.ID
                                          select m).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (matriculaVinculo.MatriculaMestreID != 0)
                        {
                            resultado = ((from m in resultado
                                          where
                                          m.MatriculaMestreID == matriculaVinculo.MatriculaMestreID
                                          select m).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (matriculaVinculo.MatriculaDependenteID != 0)
                        {
                            resultado = ((from m in resultado
                                          where
                                          m.MatriculaDependenteID == matriculaVinculo.MatriculaDependenteID
                                          select m).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (matriculaVinculo.ID != 0)
                        {
                            resultado = ((from m in resultado
                                          where
                                          m.ID == matriculaVinculo.ID
                                          select m).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        if (matriculaVinculo.Status.HasValue)
                        {

                            resultado = ((from m in resultado
                                          where
                                          m.Status.HasValue && m.Status.Value == matriculaVinculo.Status.Value
                                          select m).ToList());
                            resultado = resultado.Distinct().ToList();
                        }

                        break;
                    }
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                        if (matriculaVinculo.ID != 0)
                        {

                            resultado.AddRange((from m in Consultar()
                                                where
                                                m.ID == matriculaVinculo.ID
                                                select m).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (matriculaVinculo.MatriculaMestreID != 0)
                        {

                            resultado.AddRange((from m in Consultar()
                                                where
                                                m.MatriculaMestreID == matriculaVinculo.MatriculaMestreID
                                                select m).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (matriculaVinculo.MatriculaDependenteID != 0)
                        {

                            resultado.AddRange((from m in Consultar()
                                                where
                                                m.MatriculaDependenteID == matriculaVinculo.MatriculaDependenteID
                                                select m).ToList());

                            resultado = resultado.Distinct().ToList();
                        }


                        if (matriculaVinculo.Status.HasValue)
                        {

                            resultado.AddRange((from m in Consultar()
                                                where
                                                m.Status.HasValue && m.Status.Value == matriculaVinculo.Status.Value
                                                select m).ToList());

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

        public void Incluir(MatriculaVinculo matriculaVinculo)
        {
            try
            {
                db.MatriculaVinculo.InsertOnSubmit(matriculaVinculo);
            }
            catch (Exception)
            {

                throw new MatriculaVinculoNaoIncluidaExcecao();
            }
        }

        public void Excluir(MatriculaVinculo matriculaVinculo)
        {
            try
            {
                MatriculaVinculo matriculaVinculoAux = new MatriculaVinculo();
                matriculaVinculoAux.ID = matriculaVinculo.ID;


                List<MatriculaVinculo> resultado = this.Consultar(matriculaVinculoAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new MatriculaVinculoNaoExcluidaExcecao();

                matriculaVinculoAux = resultado[0];

                db.MatriculaVinculo.DeleteOnSubmit(matriculaVinculoAux);
            }
            catch (Exception)
            {

                throw new MatriculaVinculoNaoExcluidaExcecao();
            }
        }

        public void Alterar(MatriculaVinculo matriculaVinculo)
        {
            try
            {
                MatriculaVinculo matriculaVinculoAux = new MatriculaVinculo();
                matriculaVinculoAux.ID = matriculaVinculo.ID;


                List<MatriculaVinculo> resultado = this.Consultar(matriculaVinculoAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new MatriculaVinculoNaoAlteradaExcecao();

                matriculaVinculoAux = resultado[0];

                matriculaVinculoAux.DataVinculo = matriculaVinculo.DataVinculo;
                matriculaVinculoAux.GrupoID = matriculaVinculo.GrupoID;
                matriculaVinculoAux.MatriculaMestreID = matriculaVinculo.MatriculaMestreID;
                matriculaVinculoAux.MatriculaDependenteID = matriculaVinculo.MatriculaDependenteID;
                matriculaVinculoAux.Status = matriculaVinculo.Status;

                Confirmar();

            }
            catch (Exception)
            {

                throw new MatriculaVinculoNaoAlteradaExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion

        #region Construtor
        public MatriculaVinculoRepositorio()
        {
            Conexao conexao = new Conexao();
            db = new ColegioDB(new MySqlConnection(conexao.ToString()));

        }
        #endregion


    }
}