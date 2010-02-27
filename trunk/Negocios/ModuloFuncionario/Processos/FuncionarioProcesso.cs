using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloBasico.Singleton;
using Negocios.ModuloFuncionario.Repositorios;
using Negocios.ModuloFuncionario.Processos;
using Negocios.ModuloFuncionario.Fabricas;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloFuncionario.Excecoes;

namespace Negocios.ModuloFuncionario.Processos
{
    /// <summary>
    /// Classe FuncionarioProcesso
    /// </summary>
    public class FuncionarioProcesso : Singleton<FuncionarioProcesso>, IFuncionarioProcesso
    {
        #region Atributos
        private IFuncionarioRepositorio funcionarioRepositorio = null;
        #endregion

        #region Construtor
        public FuncionarioProcesso()
        {
            funcionarioRepositorio = FuncionarioFabrica.IFuncionarioInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(Funcionario funcionario)
        {
            this.funcionarioRepositorio.Incluir(funcionario);

        }

        public void Excluir(Funcionario funcionario)
        {

            try
            {
                if (funcionario.ID == 0)
                    throw new FuncionarioNaoExcluidoExcecao();

                List<Funcionario> resultado = funcionarioRepositorio.Consultar(funcionario, TipoPesquisa.E);

                if (resultado == null || resultado.Count <= 0 || resultado.Count > 1)
                    throw new FuncionarioNaoExcluidoExcecao();

                resultado[0].Status = (int)Status.Inativo;
                this.Alterar(resultado[0]);
            }
            catch (Exception e)
            {

                throw e;
            }
            //this.funcionarioRepositorio.Excluir(funcionario);
        }

        public void Alterar(Funcionario funcionario)
        {
            this.funcionarioRepositorio.Alterar(funcionario);
        }

        public List<Funcionario> Consultar(Funcionario funcionario, TipoPesquisa tipoPesquisa)
        {
            List<Funcionario> funcionarioList = this.funcionarioRepositorio.Consultar(funcionario,tipoPesquisa);           

            return funcionarioList;
        }

        public List<Funcionario> Consultar()
        {
            List<Funcionario> funcionarioList = this.funcionarioRepositorio.Consultar();

            return funcionarioList;
        }

        public void Confirmar()
        {
            this.funcionarioRepositorio.Confirmar();
        }

        #endregion
    }
}