using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Negocios.ModuloControleAcesso.Excecoes
{
/// <summary>
/// Summary description for UsuarioSitemaDadoNaoInformado
/// </summary>
public class UsuarioSitemaDadoNaoInformadoExcecao: Exception
    { 
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante.
        /// </summary>
    public UsuarioSitemaDadoNaoInformadoExcecao()
            : base(ConstantesControleAcesso.USUARIO_DADONAOINFORMADO)
        { }
    }
}