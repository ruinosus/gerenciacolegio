using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Negocios.ModuloComentario.Excecoes
{
    /// <summary>
    /// Summary description for ComentarioNaoIncluidoExcecao
    /// </summary>
    public class ComentarioNaoIncluidoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public ComentarioNaoIncluidoExcecao()
            : base(ConstantesComentario.COMENTARIO_NAOINCLUIDO)
        { }
    }
}