using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Negocios.ModuloAuxuliar.VOs
{
    /// <summary>
    /// Summary description for RegistroModificacao
    /// </summary>
    public class RegistroModificacao
    {
        protected DateTime dtCadastro;
        protected DateTime dtDesativacao;
        protected DateTime dtAlteracao;
        protected int idUsuarioSistema;

        public int IdUsuarioSistema
        {
            get { return idUsuarioSistema; }
            set { idUsuarioSistema = value; }
        }

        public DateTime DataCadastro
        {
            get { return dtCadastro; }
            set { dtCadastro = value; }
        }

        public DateTime DataAlteracao
        {
            get { return dtAlteracao; }
            set { dtAlteracao = value; }
        }

        public DateTime DataDesativacao
        {
            get { return dtDesativacao; }
            set { dtDesativacao = value; }
        }
    }
}