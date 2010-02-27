using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloBasico.Singleton;
using Negocios.ModuloDesconto.Repositorios;
using Negocios.ModuloDesconto.Processos;
using Negocios.ModuloDesconto.Fabricas;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloDesconto.Excecoes;

namespace Negocios.ModuloDesconto.Processos
{
    /// <summary>
    /// Classe DescontoProcesso
    /// </summary>
    public class DescontoProcesso : Singleton<DescontoProcesso>, IDescontoProcesso
    {
        #region Atributos
        private IDescontoRepositorio descontoRepositorio = null;
        #endregion

        #region Construtor
        public DescontoProcesso()
        {
            descontoRepositorio = DescontoFabrica.IDescontoInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(Desconto desconto)
        {
            this.descontoRepositorio.Incluir(desconto);

        }

        public void Excluir(Desconto desconto)
        {

            try
            {
                if (desconto.ID == 0)
                    throw new DescontoNaoExcluidoExcecao();

                List<Desconto> resultado = descontoRepositorio.Consultar(desconto, TipoPesquisa.E);

                if (resultado == null || resultado.Count <= 0 || resultado.Count > 1)
                    throw new DescontoNaoExcluidoExcecao();

                resultado[0].Status = (int)Status.Inativo;

                this.Alterar(resultado[0]);
            }
            catch (Exception e)
            {

                throw e;
            }
            //this.descontoRepositorio.Excluir(desconto);
        }

        public void Alterar(Desconto desconto)
        {
            this.descontoRepositorio.Alterar(desconto);
        }

        public List<Desconto> Consultar(Desconto desconto, TipoPesquisa tipoPesquisa)
        {
            List<Desconto> descontoList = this.descontoRepositorio.Consultar(desconto, tipoPesquisa);           

            return descontoList;
        }

        public List<Desconto> Consultar()
        {
            List<Desconto> descontoList = this.descontoRepositorio.Consultar();

            return descontoList;
        }

        public void Confirmar()
        {
            this.descontoRepositorio.Confirmar();
        }

        #endregion
    }
}