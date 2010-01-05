using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloSerie.Constantes;


namespace Negocios.ModuloSerie.Excecoes
{
    /// <summary>
    /// Classe SerieNaoAlteradaExcecao
    /// </summary>
    public class SerieNaoAlteradaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public SerieNaoAlteradaExcecao()
            : base(SerieConstantes.SERIE_NAOALTERADA)
        { }
    }
}