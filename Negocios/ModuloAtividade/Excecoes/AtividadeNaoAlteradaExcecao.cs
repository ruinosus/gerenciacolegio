using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAtividade.Constantes;

namespace Negocios.ModuloAtividade.Excecoes
{
    /// <summary>
    /// Classe AtividadeNaoAlteradaExcecao
    /// </summary>
    public class AtividadeNaoAlteradaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public AtividadeNaoAlteradaExcecao()
            : base(AtividadeConstantes.ATIVIDADE_NAOALTERADA)
        { }
    }
}