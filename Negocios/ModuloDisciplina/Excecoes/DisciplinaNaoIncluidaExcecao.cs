using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloDisciplina.Constantes;

namespace Negocios.ModuloDisciplina.Excecoes
{
    /// <summary>
    /// Classe DisciplinaNaoIncluidaExcecao
    /// </summary>
    public class DisciplinaNaoIncluidaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public DisciplinaNaoIncluidaExcecao()
            : base(DisciplinaConstantes.DISCIPLINA_NAOINCLUIDA)
        { }
    }
}