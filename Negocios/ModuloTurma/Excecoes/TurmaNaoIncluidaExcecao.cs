using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloTurma.Constantes;

namespace Negocios.ModuloTurma.Excecoes
{
    /// <summary>
    /// Classe TurmaNaoIncluidaExcecao
    /// </summary>
    public class TurmaNaoIncluidaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public TurmaNaoIncluidaExcecao()
            : base(TurmaConstantes.TURMA_NAOINCLUIDA)
        { }
    }
}