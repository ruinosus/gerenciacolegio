using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAtividade.Constantes;

namespace Negocios.ModuloAtividade.Excecoes
{
    /// <summary>
    /// Classe AtividadeNaoIncluidaExcecao
    /// </summary>
    public class AtividadeNaoIncluidaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public AtividadeNaoIncluidaExcecao()
            : base(AtividadeConstantes.ATIVIDADE_NAOINCLUIDA)
        { }
    }
}