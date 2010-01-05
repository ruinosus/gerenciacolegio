using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloSerie.Constantes;

namespace Negocios.ModuloSerie.Excecoes
{
    /// <summary>
    /// Classe SerieNaoIncluidaExcecao
    /// </summary>
    public class SerieNaoIncluidaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public SerieNaoIncluidaExcecao()
            : base(SerieConstantes.SERIE_NAOINCLUIDA)
        { }
    }
}