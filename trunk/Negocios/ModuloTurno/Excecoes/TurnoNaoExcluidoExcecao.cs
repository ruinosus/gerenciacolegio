using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloTurno.Constantes;

namespace Negocios.ModuloTurno.Excecoes
{
    /// <summary>
    /// Classe TurnoNaoExcluidoExcecao
    /// </summary>
    public class TurnoNaoExcluidoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public TurnoNaoExcluidoExcecao()
            : base(TurnoConstantes.TURNO_NAOEXCLUIDO)
        { }
    }
}