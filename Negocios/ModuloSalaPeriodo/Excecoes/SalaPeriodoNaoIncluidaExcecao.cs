using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloSalaPeriodo.Constantes;

namespace Negocios.ModuloSalaPeriodo.Excecoes
{
    /// <summary>
    /// Classe SalaPeriodoNaoIncluidaExcecao
    /// </summary>
    public class SalaPeriodoNaoIncluidaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public SalaPeriodoNaoIncluidaExcecao()
            : base(SalaPeriodoConstantes.SALAPERIODO_NAOINCLUIDA)
        { }
    }
}