using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAlunoAtividadeTurma.Constantes;

namespace Negocios.ModuloAlunoAtividadeTurma.Excecoes
{
    /// <summary>
    /// Classe AlunoAtividadeTurmaNaoIncluidoExcecao
    /// </summary>
    public class AlunoAtividadeTurmaNaoIncluidoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public AlunoAtividadeTurmaNaoIncluidoExcecao()
            : base(AlunoAtividadeTurmaConstantes.ALUNOATIVIDADETURMA_NAOINCLUIDO)
        { }
    }
}