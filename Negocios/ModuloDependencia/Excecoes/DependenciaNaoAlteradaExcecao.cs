using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloDependencia.Constantes;

namespace Negocios.ModuloDependencia.Excecoes
{
    /// <summary>
    /// Classe DependenciaNaoAlteradaExcecao
    /// </summary>
    public class DependenciaNaoAlteradaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public DependenciaNaoAlteradaExcecao()
            : base(DependenciaConstantes.DEPENDENCIA_NAOALTERADA)
        { }
    }
}