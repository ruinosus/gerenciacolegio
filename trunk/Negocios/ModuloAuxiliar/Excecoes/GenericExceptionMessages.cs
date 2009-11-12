using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Classe de constantes contantendo as mensagens de erro do sistema.
/// </summary>
namespace Negocios.ModuloAuxiliar.Excecoes
{
    public class GenericExceptionMessages
    {
   
        //MENSAGENS GERAIS
        public static readonly String REGISTRO_NAO_LOCALIZADO = "Não foi possível localizar o registro solicitado.";
        public static readonly String ERRO_FK_EXCLUSAO = "Não é possível excluir o registro, pois já foi referenciado por outro processo. A operação de exclusão foi cancelada";
        public static readonly String ERRO_FK_INCLUSAO = "Não é possível inserir o registro, pois este já está cadastrado. A operação inserção foi cancelada.";
        public static readonly String ERRO_GENERICO = "Ocorreu um erro inesperado durante a execução do sistema. Entre em contato com o administrador.";
   
    }
}