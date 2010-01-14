using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloDesconto.Constantes;

namespace Negocios.ModuloDesconto.Excecoes
{
    /// <summary>
    /// Classe DescontoNaoExcluidoExcecao
    /// </summary>
    public class DescontoNaoExcluidoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public DescontoNaoExcluidoExcecao()
            : base(DescontoConstantes.DESCONTO_NAOEXCLUIDO)
        { }
    }
}