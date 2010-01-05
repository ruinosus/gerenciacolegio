using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloFuncionario.Constantes;

namespace Negocios.ModuloFuncionario.Excecoes
{
    /// <summary>
    /// Classe FuncionarioNaoIncluidoExcecao
    /// </summary>
    public class FuncionarioNaoIncluidoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public FuncionarioNaoIncluidoExcecao()
            : base(FuncionarioConstantes.FUNCIONARIO_NAOINCLUIDO)
        { }
    }
}