using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloContasAPagar.Constantes;

namespace Negocios.ModuloContasAPagar.Excecoes
{
    /// <summary>
    /// Classe ContasAPagarNaoExcluidaExcecao
    /// </summary>
    public class ContasAPagarNaoExcluidaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public ContasAPagarNaoExcluidaExcecao()
            : base(ContasAPagarConstantes.CONTASAPAGAR_NAOEXCLUIDA)
        { }
    }
}