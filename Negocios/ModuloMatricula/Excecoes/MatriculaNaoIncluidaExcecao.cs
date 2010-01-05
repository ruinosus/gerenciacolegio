using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloMatricula.Constantes;

namespace Negocios.ModuloMatricula.Excecoes
{
    /// <summary>
    /// Classe MatriculaNaoIncluidaExcecao
    /// </summary>
    public class MatriculaNaoIncluidaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public MatriculaNaoIncluidaExcecao()
            : base(MatriculaConstantes.MATRICULA_NAOINCLUIDA)
        { }
    }
}