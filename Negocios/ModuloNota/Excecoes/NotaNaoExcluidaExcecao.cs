using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloNota.Constantes;

namespace Negocios.ModuloNota.Excecoes
{
    /// <summary>
    /// Classe NotaNaoExcluidaExcecao
    /// </summary>
    public class NotaNaoExcluidaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public NotaNaoExcluidaExcecao()
            : base(NotaConstantes.NOTA_NAOEXCLUIDA)
        { }
    }
}