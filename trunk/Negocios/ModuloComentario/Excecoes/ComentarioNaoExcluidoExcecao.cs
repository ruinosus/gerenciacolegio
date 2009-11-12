using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Negocios.ModuloComentario.Excecoes
{
    /// <summary>
    /// Summary description for ComentarioNaoExcluidoExcecao
    /// </summary>
    public class ComentarioNaoExcluidoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public ComentarioNaoExcluidoExcecao()
            : base(ConstantesComentario.COMENTARIO_NAOEXCLUIDO)
        { }
    }
}