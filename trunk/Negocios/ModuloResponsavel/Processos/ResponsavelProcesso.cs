using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloAuxiliar.Singleton;
using Negocios.ModuloResponsavel.Repositorios;
using Negocios.ModuloResponsavel.Processos;
using Negocios.ModuloResponsavel.Fabricas;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloResponsavel.Processos
{
    /// <summary>
    /// Classe ResponsavelProcesso
    /// </summary>
    public class ResponsavelProcesso : Singleton<ResponsavelProcesso>, IResponsavelProcesso
    {
        #region Atributos
        private IResponsavelRepositorio responsavelRepositorio = null;
        #endregion

        #region Construtor
        public ResponsavelProcesso()
        {
            responsavelRepositorio = ResponsavelFabrica.IResponsavelInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(Responsavel responsavel)
        {
            this.responsavelRepositorio.Incluir(responsavel);

        }

        public void Excluir(Responsavel responsavel)
        {
            //this.responsavelRepositorio.Excluir(responsavel);
        }

        public void Alterar(Responsavel responsavel)
        {
            this.responsavelRepositorio.Alterar(responsavel);
        }

        public List<Responsavel> Consultar(Responsavel responsavel, TipoPesquisa tipoPesquisa)
        {
            List<Responsavel> responsavelList = this.responsavelRepositorio.Consultar(responsavel,tipoPesquisa);           

            return responsavelList;
        }

        public List<Responsavel> Consultar()
        {
            List<Responsavel> responsavelList = this.responsavelRepositorio.Consultar();

            return responsavelList;
        }

        public void Confirmar()
        {
            this.responsavelRepositorio.Confirmar();
        }

        #endregion
    }
}