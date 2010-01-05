using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloAuxiliar.Singleton;
using Negocios.ModuloDesconto.Repositorios;
using Negocios.ModuloDesconto.Processos;
using Negocios.ModuloDesconto.Fabricas;

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
            this.descontoRepositorio.Excluir(desconto);
        }

        public void Alterar(Desconto desconto)
        {
            this.descontoRepositorio.Alterar(desconto);
        }

        public List<Desconto> Consultar(Desconto desconto)
        {
            List<Desconto> descontoList = this.descontoRepositorio.Consultar(desconto);           

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