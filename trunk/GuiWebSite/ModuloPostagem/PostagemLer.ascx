<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PostagemLer.ascx.cs" Inherits="ModuloPostagem_PostagemLer" %>
<div id="content">
        <!-- INICIO DE TODOS OS MODULOS DE TEXTO A ESQUERDA -->
        <div class="meio">
            <asp:GridView ID="GrdPostagem" runat="server" AutoGenerateColumns="False" Width="100%"
                GridLines="None" ForeColor="#333333" BackColor="White">
                <RowStyle />
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <div class="left_articles">
                                <table width="100%">
                                    <tr>
                                        <td style="width: 10%" rowspan="3" align="left" valign="top">
                                            <div class="calendar">
                                                <p align="left">
                                                    <asp:Label ID="lblData" runat="server" Text='<%#GetData(Eval("DataCriacao")) %>'></asp:Label>
                                            </div>
                                        </td>
                                        <td style="width: 90%" colspan="4" align="left">
                                            <asp:LinkButton runat="server" ID="lkbComentar"  PostBackUrl='<%#"~/ModuloComentario/Incluir.aspx?id="+(Eval("ID"))+"&tela="+((int)Eval("TipoPostagem"))%>' CssClass="greenbtn">Comentar</asp:LinkButton>
                                            <h2>
                                                <asp:Label ID="lblTitulo" runat="server" Text='<%#Eval("Titulo") %>'></asp:Label>
                                                <a href="#"></a>
                                            </h2>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 100%" colspan="5" align="left">
                                            <p class="description">
                                                <asp:Label ID="lblSubTitulo" runat="server" Text='<%#Eval("SubTitulo") %>'></asp:Label></p>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 100%" colspan="5" align="left">
                                            <p>
                                                <asp:Image ID="Image1" runat="server" Height="89px" Width="120px" ImageUrl='<%# GetImageUrl(Eval("Id")) %>'
                                                    alt="thumbnail" hspace="0" vspace="0" border="0" class="thumbnail" Visible='<%# GetImage(Eval("Imagem")) %>' />
                                                <asp:Label ID="lblConteudo" runat="server" Text='<%#Eval("Corpo") %>'></asp:Label></p>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </ItemTemplate>
                        <ItemStyle HorizontalAlign="Center" />
                        <HeaderStyle HorizontalAlign="Center" />
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:LinkButton ID="lkbVoltar" runat="server">Voltar</asp:LinkButton>
        </div>
    </div>