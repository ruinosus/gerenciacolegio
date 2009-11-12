using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Negocios.ModuloComentario.Excecoes
{
    /// <summary>
    /// Summary description for ComentarioNaoAlteradoExcecao
    /// </summary>
    public class ComentarioNaoAlteradoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public ComentarioNaoAlteradoExcecao()
            : base(ConstantesComentario.COMENTARIO_NAOALTERADO)
        { }
    }
}