<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Alterar.aspx.cs" Inherits="ModuloPostagem_Alterar" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Assembly="System.Web.Extensions, Version=1.0.61025.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI" TagPrefix="ajax" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="corpo" runat="Server">
    <div id="AvisoDeErro1" style="text-align: center;">
        <asp:ValidationSummary ID="vsuAvisoDeErro" Visible="false" runat="server" ValidationGroup="AvisoDeErro">
        </asp:ValidationSummary>
        <asp:ValidationSummary ID="vsuAvisoDeInformacao" runat="server" ValidationGroup="AvisoDeInformacao"
            ForeColor="#14A351" Visible="false"></asp:ValidationSummary>
        <asp:CustomValidator ID="cvaAvisoDeErro" runat="server" ValidationGroup="AvisoDeErro"
            Visible="false"></asp:CustomValidator>
        <asp:CustomValidator ID="cvaAvisoDeInformacao" runat="server" ValidationGroup="AvisoDeInformacao"
            ForeColor="#14A351" Visible="False"></asp:CustomValidator>
    </div>
    
    <table width="100%">
        <tr align="center">
            <td>
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="lblTipoPostagem" runat="server" Text="Tipo da Postagem:"></asp:Label>
                        </td>
                        <ajax:UpdatePanel ID="updEnuns" runat="server">
                            <ContentTemplate>
                                <td align="left">
                                    <asp:DropDownList ID="ddlTipoPostagem" AutoPostBack="true" runat="server" OnSelectedIndexChanged="CarregarComboLocal">
                                    </asp:DropDownList>
                                </td>
                                <td>
                                    <asp:Label ID="lblLocalPostagem" runat="server" Text="Local da Postagem:"></asp:Label>
                                </td>
                                <td align="left">
                                    <asp:DropDownList ID="ddlLocalPostagem" runat="server">
                                    </asp:DropDownList>
                                </td>
                            </ContentTemplate>
                        </ajax:UpdatePanel>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblTitulo" runat="server" Text="Título:"></asp:Label>
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtTitulo" runat="server" Width="450px" MaxLength="250"></asp:TextBox>
                        </td>
                        <td>
                            <asp:Label ID="lblSubTitulo" runat="server" Text="Sub-Título:"></asp:Label>
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtSubTitulo" runat="server" Width="300px" MaxLength="500"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblCorpo" runat="server" Text="Corpo:"></asp:Label>
                        </td>
                        <td colspan="3" align="left">
                            <asp:TextBox ID="txtCorpo"  runat="server" Height="90" Width="850" 
                                AutoFocus="true" TextMode="MultiLine" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblImagemPostagem" runat="server" Text="Imagem da Postagem:"></asp:Label>
                        </td>
                        <td align="left" colspan="3">
                            <ajax:UpdatePanel ID="updImagem" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:FileUpload ID="fupImgPostagem" runat="server" />
                                </ContentTemplate>
                                <Triggers>
                                    <asp:PostBackTrigger ControlID="btnConfirmar" />
<ajax:PostBackTrigger ControlID="btnConfirmar"></ajax:PostBackTrigger>
                                </Triggers>
                            </ajax:UpdatePanel>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td align="center">
                <asp:Button ID="btnConfirmar" runat="server" Text="Confirmar" OnClick="Confirmar" />
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="Cancelar" />
                <asp:Button ID="btnLimparCampos" runat="server" Text="Limpar Campos" OnClick="LimparCampos" />
            </td>
        </tr>
    </table>
</asp:Content>
