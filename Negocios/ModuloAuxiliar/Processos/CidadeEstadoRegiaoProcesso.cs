using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using Negocios.ModuloAuxiliar.Repositorios;
using Negocios.ModuloControleAcesso.Fabricas;
using Negocios.ModuloAuxuliar.VOs;
using System.Collections.Generic;
using Negocios.ModuloAuxuliar.Filtros;
using Negocios.ModuloAuxiliar.Singleton;
using Negocios.ModuloAuxiliar.Fabricas;

namespace Negocios.ModuloAuxiliar.Processos
{
    /// <summary>
    /// Summary description for CidadeEstadoProcesso
    /// </summary>
    public class CidadeEstadoRegiaoProcesso : Singleton<CidadeEstadoRegiaoProcesso>, ICidadeEstadoRegiaoProcesso
    {
        #region Atributos
        private ICidadeEstadoRegiaoRepositorio cidadeEstadoRegiaoRepositorio = null;
        #endregion

        #region Construtor
        public CidadeEstadoRegiaoProcesso()
        {
            cidadeEstadoRegiaoRepositorio = ModuloAuxiliarFabrica.ICidadeEstadoRegiaoRepositorioInstance;
        }

        #endregion

        #region Metodos da Interface


        public List<Estado> ConsultarEstados(Estado estado, EstadoFiltroConsulta estadoFiltroConsulta, bool lazy)
        {
            List<Estado> estadoList = cidadeEstadoRegiaoRepositorio.ConsultarEstados(estado, estadoFiltroConsulta, lazy);

            if (lazy)
            {
                foreach (Estado e in estadoList)
                {
                    Regiao regiao = new Regiao();
                    regiao.ID = e.Regiao.ID;
                    RegiaoFiltroConsulta regiaoFiltroConsulta = new RegiaoFiltroConsulta();
                    regiaoFiltroConsulta.HabilitaTudo();
                    e.Regiao = this.ConsultarRegioes(regiao, regiaoFiltroConsulta, lazy)[0];
                }
            }

            return estadoList;
        }

        public List<Estado> ConsultarEstados(EstadoFiltroConsulta estadoFiltroConsulta, bool lazy)
        {
            List<Estado> estadoList = cidadeEstadoRegiaoRepositorio.ConsultarEstados(estadoFiltroConsulta, lazy);

            if (lazy)
            {
                foreach (Estado e in estadoList)
                {
                    Regiao regiao = new Regiao();
                    regiao.ID = e.Regiao.ID;
                    RegiaoFiltroConsulta regiaoFiltroConsulta = new RegiaoFiltroConsulta();
                    regiaoFiltroConsulta.HabilitaTudo();
                    e.Regiao = this.ConsultarRegioes(regiao, regiaoFiltroConsulta, lazy)[0];
                }
            }

            return estadoList;
        }

        public List<Cidade> ConsultarCidades(Cidade cidade, CidadeFiltroConsulta cidadeFiltroConsulta, bool lazy)
        {
            List<Cidade> cidadeList = cidadeEstadoRegiaoRepositorio.ConsultarCidades(cidade,cidadeFiltroConsulta, lazy);

            if (lazy)
            {
                foreach (Cidade c in cidadeList)
                {
                    Estado estado = new Estado();
                    estado.ID = c.Estado.ID;
                    EstadoFiltroConsulta estadoFiltroConsulta = new EstadoFiltroConsulta();
                    estadoFiltroConsulta.HabilitaTudo();
                    c.Estado = this.ConsultarEstados(estado, estadoFiltroConsulta, lazy)[0];
                }
            }

            return cidadeList;
        }

        public List<Cidade> ConsultarCidades(CidadeFiltroConsulta cidadeFiltroConsulta, bool lazy)
        {
            List<Cidade> cidadeList = cidadeEstadoRegiaoRepositorio.ConsultarCidades(cidadeFiltroConsulta, lazy);

            if (lazy)
            {
                foreach (Cidade c in cidadeList)
                {
                    Estado estado = new Estado();
                    estado.ID = c.Estado.ID;
                    EstadoFiltroConsulta estadoFiltroConsulta = new EstadoFiltroConsulta();
                    estadoFiltroConsulta.HabilitaTudo();
                    c.Estado = this.ConsultarEstados(estado, estadoFiltroConsulta, lazy)[0];
                }
            }

            return cidadeList;

        }

        public List<Regiao> ConsultarRegioes(Regiao regiao, RegiaoFiltroConsulta regiaoFiltroConsulta, bool lazy)
        {
            return this.cidadeEstadoRegiaoRepositorio.ConsultarRegioes(regiao, regiaoFiltroConsulta, lazy);
        }

        public List<Regiao> ConsultarRegioes(RegiaoFiltroConsulta regiaoFiltroConsulta, bool lazy)
        {
            return this.cidadeEstadoRegiaoRepositorio.ConsultarRegioes( regiaoFiltroConsulta, lazy);
        }



        #endregion

        
    }
}