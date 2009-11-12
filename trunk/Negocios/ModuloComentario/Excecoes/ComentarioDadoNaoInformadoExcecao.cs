using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Negocios.ModuloComentario.Excecoes
{
    /// <summary>
    /// Summary description for ComentarioDadoNaoInformadoExcecao
    /// </summary>
    public class ComentarioDadoNaoInformadoExcecao : Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public ComentarioDadoNaoInformadoExcecao()
            : base(ConstantesComentario.COMENTARIO_DADONAOINFORMADO)
        { }
    }
}