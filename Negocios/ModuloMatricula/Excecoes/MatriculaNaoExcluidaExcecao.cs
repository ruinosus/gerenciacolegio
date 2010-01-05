using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloMatricula.Constantes;

namespace Negocios.ModuloMatricula.Excecoes
{
    /// <summary>
    /// Classe MatriculaNaoExcluidaExcecao
    /// </summary>
    public class MatriculaNaoExcluidaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public MatriculaNaoExcluidaExcecao()
            : base(MatriculaConstantes.MATRICULA_NAOEXCLUIDA)
        { }
    }
}