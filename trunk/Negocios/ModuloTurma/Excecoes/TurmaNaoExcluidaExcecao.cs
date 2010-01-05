using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloTurma.Constantes;
namespace Negocios.ModuloTurma.Excecoes
{
    /// <summary>
    /// Classe TurmaNaoExcluidaExcecao
    /// </summary>
    public class TurmaNaoExcluidaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public TurmaNaoExcluidaExcecao()
            : base(TurmaConstantes.TURMA_NAOEXCLUIDA)
        { }
    }
}