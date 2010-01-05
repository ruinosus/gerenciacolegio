using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloSala.Constantes;

namespace Negocios.ModuloSala.Excecoes
{
    /// <summary>
    /// Classe SalaNaoIncluidaExcecao
    /// </summary>
    public class SalaNaoIncluidaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public SalaNaoIncluidaExcecao()
            : base(SalaConstantes.SALA_NAOINCLUIDA)
        { }
    }
}