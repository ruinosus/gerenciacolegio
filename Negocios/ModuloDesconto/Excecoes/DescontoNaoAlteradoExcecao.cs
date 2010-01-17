using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloDesconto.Constantes;

namespace Negocios.ModuloDesconto.Excecoes
{
    /// <summary>
    /// Classe DescontoNaoAlteradoExcecao
    /// </summary>
    public class DescontoNaoAlteradoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public DescontoNaoAlteradoExcecao()
            : base(DescontoConstantes.DESCONTO_NAOALTERADO)
        { }
    }
}