using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;

namespace Negocios.ModuloBasico.Excecoes
{
    /// <summary>
    /// Classe ArquivoConfiguracaoNaoEncontradoExcecao
    /// </summary>
    public class ArquivoConfiguracaoNaoEncontradoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public ArquivoConfiguracaoNaoEncontradoExcecao()
            : base(BasicoConstantes.ARQUIVO_CONFIGURACAO_NAO_ENCONTRADO)
        { }
    }
}