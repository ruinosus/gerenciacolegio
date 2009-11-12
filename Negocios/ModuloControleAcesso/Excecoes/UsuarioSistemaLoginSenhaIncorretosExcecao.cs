using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Negocios.ModuloControleAcesso.Excecoes
{
    /// <summary>
    /// Summary description for UsuarioSistemaLoginSenhaIncorretos
    /// </summary>
    public class UsuarioSistemaLoginSenhaIncorretosExcecao : Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public UsuarioSistemaLoginSenhaIncorretosExcecao()
            : base(ConstantesControleAcesso.USUARIO_LOGINSENHAINCORRETO)
        { }
    }
}
