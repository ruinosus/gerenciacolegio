using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Negocios.ModuloPostagem.Excecoes
{
/// <summary>
/// Summary description for PostagemNaoExcluidaExcecao
/// </summary>
public class PostagemNaoExcluidaExcecao:Exception
{
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
    public PostagemNaoExcluidaExcecao()
            : base(ConstantesPostagem.POSTAGEM_NAOEXCLUIDA)
        { }
    }

}
