using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloSalaPeriodo.Constantes;

namespace Negocios.ModuloSalaPeriodo.Excecoes
{
    /// <summary>
    /// Classe SalaPeriodoNaoExcluidaExcecao
    /// </summary>
    public class SalaPeriodoNaoExcluidaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public SalaPeriodoNaoExcluidaExcecao()
            : base(SalaPeriodoConstantes.SALAPERIODO_NAOEXCLUIDA)
        { }
    }
}