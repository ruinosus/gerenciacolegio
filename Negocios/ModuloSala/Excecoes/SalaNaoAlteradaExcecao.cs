using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloSala.Constantes;

namespace Negocios.ModuloSala.Excecoes
{
    /// <summary>
    /// Classe SalaNaoAlteradaExcecao
    /// </summary>
    public class SalaNaoAlteradaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public SalaNaoAlteradaExcecao()
            : base(SalaConstantes.SALA_NAOALTERADA)
        { }
    }
}