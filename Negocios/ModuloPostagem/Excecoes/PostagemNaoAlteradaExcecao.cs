using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Negocios.ModuloPostagem.Excecoes
{
    /// <summary>
    /// Summary description for PostagemNaoAlteradaExcecao
    /// </summary>
    public class PostagemNaoAlteradaExcecao:Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public PostagemNaoAlteradaExcecao()
            : base(ConstantesPostagem.POSTAGEM_NAOALTERADA)
        { }
    }
}