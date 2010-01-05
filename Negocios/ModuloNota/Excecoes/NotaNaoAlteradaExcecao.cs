using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloNota.Constantes;

namespace Negocios.ModuloNota.Excecoes
{
    /// <summary>
    /// Classe NotaNaoAlteradaExcecao
    /// </summary>
    public class NotaNaoAlteradaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public NotaNaoAlteradaExcecao()
            : base(NotaConstantes.NOTA_NAOALTERADA)
        { }
    }
}