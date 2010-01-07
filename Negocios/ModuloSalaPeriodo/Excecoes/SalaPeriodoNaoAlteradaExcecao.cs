using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloSalaPeriodo.Constantes;

namespace Negocios.ModuloSalaPeriodo.Excecoes
{
    /// <summary>
    /// Classe SalaPeriodoNaoAlteradaExcecao
    /// </summary>
    public class SalaPeriodoNaoAlteradaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public SalaPeriodoNaoAlteradaExcecao()
            : base(SalaPeriodoConstantes.SALAPERIODO_NAOALTERADA)
        { }
    }
}