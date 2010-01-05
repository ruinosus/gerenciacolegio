using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloDependencia.Constantes;

namespace Negocios.ModuloDependencia.Excecoes
{
    /// <summary>
    /// Classe DependenciaNaoExcluidaExcecao
    /// </summary>
    public class DependenciaNaoExcluidaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public DependenciaNaoExcluidaExcecao()
            : base(DependenciaConstantes.DEPENDENCIA_NAOEXCLUIDA)
        { }
    }
}