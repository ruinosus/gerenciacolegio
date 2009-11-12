using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Negocios.ModuloControleAcesso.Excecoes
{
    /// <summary>
    /// Summary description for ConstantesControleAcesso
    /// </summary>
    public static class ConstantesControleAcesso
    {
        //ControleAcesso
        public static readonly String USUARIO_LOGINJAINFORMADO = "Esse Login já foi informado, por favor informe outro.";
        public static readonly String USUARIO_LOGINNAOINFORMADO = "Login não informado.";
        public static readonly String USUARIO_SENHANAOINFORMADA = "Senha não informada.";
        public static readonly String USUARIO_LOGINSENHAINCORRETO = "Login ou senha incorretos.";
        public static readonly String USUARIO_INCLUIDOCOMSUCESSO = "Usuário incluido com sucesso.";
        public static readonly String USUARIO_EXCLUIDOCOMSUCESSO = "Usuário excluido com sucesso.";
        public static readonly String USUARIO_ALTERADOCOMSUCESSO = "Usuário alterado com sucesso.";
        public static readonly String USUARIO_NAOINCLUIDO = "Não foi possível Incluir o Usuário.";
        public static readonly String USUARIO_NAOEXCLUIDO = "Não foi possível Excluir o Usuário.";
        public static readonly String USUARIO_NAOALTERADO = "Não foi possível Alterar os Dados.";

        public static readonly String USUARIO_DADONAOINFORMADO = "Os campos com * são obrigatorios.";
        public static readonly String USUARIO_CADASTROPENDENTE = "Seu cadastro está pendente, entre em contato com o administrador do site";
    }
}