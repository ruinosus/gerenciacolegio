using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloResponsavel.Constantes;

namespace Negocios.ModuloResponsavel.Excecoes
{
    /// <summary>
    /// Classe ResponsavelNaoAlteradoExcecao
    /// </summary>
    public class ResponsavelNaoAlteradoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public ResponsavelNaoAlteradoExcecao()
            : base(ResponsavelConstantes.RESPONSAVEL_NAOALTERADO)
        { }
    }
}