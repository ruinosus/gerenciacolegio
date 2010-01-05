using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloDisciplina.Constantes;

namespace Negocios.ModuloDisciplina.Excecoes
{
    /// <summary>
    /// Classe DisciplinaNaoExcluidaExcecao
    /// </summary>
    public class DisciplinaNaoExcluidaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public DisciplinaNaoExcluidaExcecao()
            : base(DisciplinaConstantes.DISCIPLINA_NAOEXCLUIDA)
        { }
    }
}