using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAuxiliar.BaseFiltro;

namespace Negocios.ModuloAuxuliar.Filtros
{
    /// <summary>
    /// Summary description for EstadoFiltroConsulta
    /// </summary>
    public class EstadoFiltroConsulta : FiltroConsulta
    {
        public bool ID
        {
            set
            {
                ExecutarOperacao(value, "Id");
            }
        }

        public bool Nome
        {
            set
            {
                ExecutarOperacao(value, "Nome");
            }
        }

        public bool Sigla
        {
            set
            {
                ExecutarOperacao(value, "Sigla");
            }
        }

        public bool Regiao
        {
            set
            {
                ExecutarOperacao(value, "RegiaoId");
            }
        }

        public void HabilitaTudo()
        {
            this.ID = true;
            this.Nome = true;
            this.Sigla = true;
            this.Regiao = true;
        }
    }
}