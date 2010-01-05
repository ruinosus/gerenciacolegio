using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloProfessorDisciplinaSala.Constantes;

namespace Negocios.ModuloProfessorDisciplinaSala.Excecoes
{
    /// <summary>
    /// Classe ProfessorDisciplinaSalaNaoExcluidaExcecao
    /// </summary>
    public class ProfessorDisciplinaSalaNaoExcluidaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public ProfessorDisciplinaSalaNaoExcluidaExcecao()
            : base(ProfessorDisciplinaSalaConstantes.PROFESSORDISCIPLINASALA_NAOEXCLUIDA)
        { }
    }
}