using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloDisciplina.Constantes;

namespace Negocios.ModuloDisciplina.Excecoes
{
    /// <summary>
    /// Classe DisciplinaNaoAlteradaExcecao
    /// </summary>
    public class DisciplinaNaoAlteradaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public DisciplinaNaoAlteradaExcecao()
            : base(DisciplinaConstantes.DISCIPLINA_NAOALTERADA)
        { }
    }
}