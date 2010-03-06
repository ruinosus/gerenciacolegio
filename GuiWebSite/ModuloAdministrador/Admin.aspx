<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="Admin.aspx.cs" Inherits="ModuloPostagem_Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="corpo" runat="Server">
    <table width="100%">
        <tr align="center">
            <td>
                <table>
                    <tr>
                        <td>
                         <asp:Label ID="lblPostagem" runat="server" Text="Painel de Postagens"></asp:Label>
                        </td>
                        <td>
                         <asp:ImageButton ID="imgPostagem" runat="server" ImageUrl="~/App_Themes/Default/Imagens/postagens.png"
                                PostBackUrl="~/ModuloPostagem/Consultar.aspx" />

                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
