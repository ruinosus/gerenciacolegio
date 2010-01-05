using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloContasAPagar.Constantes;

namespace Negocios.ModuloContasAPagar.Excecoes
{
    /// <summary>
    /// Classe ContasAPagarNaoIncluidaExcecao
    /// </summary>
    public class ContasAPagarNaoIncluidaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public ContasAPagarNaoIncluidaExcecao()
            : base(ContasAPagarConstantes.CONTASAPAGAR_NAOINCLUIDA)
        { }
    }
}