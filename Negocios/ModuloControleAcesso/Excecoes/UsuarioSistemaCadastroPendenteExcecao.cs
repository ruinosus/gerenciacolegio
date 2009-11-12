using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloControleAcesso.Excecoes;

namespace Negocios.ModuloControleAcesso.Excecoes
{
/// <summary>
/// Summary description for UsuarioSistemaCadastroPendenteExcecao
/// </summary>
public class UsuarioSistemaCadastroPendenteExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public UsuarioSistemaCadastroPendenteExcecao()
            : base(ConstantesControleAcesso.USUARIO_CADASTROPENDENTE)
        { }
    }
}