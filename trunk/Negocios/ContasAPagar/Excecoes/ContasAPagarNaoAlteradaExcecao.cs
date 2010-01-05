using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloContasAPagar.Constantes;

namespace Negocios.ModuloContasAPagar.Excecoes
{
    /// <summary>
    /// Classe ContasAPagarNaoAlteradaExcecao
    /// </summary>
    public class ContasAPagarNaoAlteradaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public ContasAPagarNaoAlteradaExcecao()
            : base(ContasAPagarConstantes.CONTASAPAGAR_NAOALTERADA)
        { }
    }
}