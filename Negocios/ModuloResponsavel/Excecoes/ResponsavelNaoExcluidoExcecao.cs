using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloResponsavel.Constantes;

namespace Negocios.ModuloResponsavel.Excecoes
{
    /// <summary>
    /// Classe ResponsavelNaoExcluidoExcecao
    /// </summary>
    public class ResponsavelNaoExcluidoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public ResponsavelNaoExcluidoExcecao()
            : base(ResponsavelConstantes.RESPONSAVEL_NAOEXCLUIDO)
        { }
    }
}