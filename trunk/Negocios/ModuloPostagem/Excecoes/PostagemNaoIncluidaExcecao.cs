using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Negocios.ModuloPostagem.Excecoes
{

    /// <summary>
    /// Summary description for PostagemNaoIncluidaExcecao
    /// </summary>
    public class PostagemNaoIncluidaExcecao:Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public PostagemNaoIncluidaExcecao()
            : base(ConstantesPostagem.POSTAGEM_NAOINCLUIDA)
        { }
    }
}