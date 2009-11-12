using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Negocios.ModuloPostagem.Excecoes
{
/// <summary>
/// Summary description for PostagemDadoNaoInformadoExcecao
/// </summary>
public class PostagemDadoNaoInformadoExcecao:Exception
{
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
    public PostagemDadoNaoInformadoExcecao()
            : base(ConstantesPostagem.POSTAGEM_DADONAOINFORMADO)
        { }
    }

}
