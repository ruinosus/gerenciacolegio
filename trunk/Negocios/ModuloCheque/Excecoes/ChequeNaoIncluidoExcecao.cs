using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloCheque.Constantes;

namespace Negocios.ModuloCheque.Excecoes
{
    /// <summary>
    /// Classe ChequeNaoIncluidoExcecao
    /// </summary>
    public class ChequeNaoIncluidoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public ChequeNaoIncluidoExcecao()
            : base(ChequeConstantes.CHEQUE_NAOINCLUIDO)
        { }
    }
}