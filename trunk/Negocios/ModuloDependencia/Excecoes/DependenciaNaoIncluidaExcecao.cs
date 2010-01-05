using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloDependencia.Constantes;

namespace Negocios.ModuloDependencia.Excecoes
{
    /// <summary>
    /// Classe DependenciaNaoIncluidaExcecao
    /// </summary>
    public class DependenciaNaoIncluidaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public DependenciaNaoIncluidaExcecao()
            : base(DependenciaConstantes.DEPENDENCIA_NAOINCLUIDA)
        { }
    }
}