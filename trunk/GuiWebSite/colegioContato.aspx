<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="colegioContato.aspx.cs" Inherits="colegioContato" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="corpo" runat="Server"> 
            <div id="conteudoCorpo">
 <div class="unico">
        
        	<div class="unico_artigos_detalhe_superior"><!-- Inicio da Curva de Estilo do Arquivo a Esquerda -->
        		<div class="unico_artigos_detalhe_superior_esquerda"></div>
            	<div class="unico_artigos_detalhe_superior_meio"></div>
            	<div class="unico_artigos_detalhe_superior_direita"></div>
            </div><!-- Fim esquerda_artigos_detalhe_superior -->
            
            <!-- Inicio do Artigo 1 a Esquerda da Página -->
            
        	<div class="unico_artigos">
            
              <div class="unico_artigos_titulo">
                <p><span class="style1Atividades">Contato</span>       	        
                                   <asp:Image ID="imgBarraArtigoUnico" runat="server" ImageUrl="App_Themes/Default/Imagens/barraArtigoUnico.png"
                                Width="930" Height="6" />                  </p>
              </div>
              
              <div class="unico_artigos_texto_index_atv">

              <div class="unico_artigos_texto_index_atv_dv">
              	              <p>
              <table width="450" border="0" align="center" cellpadding="0" cellspacing="0">
                
                <tr>
                  <td width="100" class="style7"><span class="style4Contato">Nome:</span></td>
                  <td width="350"><span class="style4Contato">
                  <asp:TextBox ID="txtNome" MaxLength="40" runat="server" /></span></td>
                </tr>
                <tr>
                  <td width="100" class="style7"><span class="style4Contato">E-mail:</span></td>
                  <td><asp:TextBox ID="txtEmail" MaxLength="50" runat="server" /></span></td>
                </tr>
                <tr>
                  <td width="100" height="19" class="style7"><span class="style4Contato">Mensagem:</span></td>
                  <td><span class="style4Contato"><asp:TextBox ID="txtMensagem" MaxLength="500" TextMode="MultiLine" runat="server" /></span></td>
                </tr>
                <tr>
                  <td width="100" height="19" class="style7"><span class="style4Contato">Tipo:</span></td>
                  <td height="19" colspan="2">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                          <asp:ListItem>Recado</asp:ListItem>
                          <asp:ListItem>Dúvida</asp:ListItem>
                          <asp:ListItem>Reclamaç&atilde;o/Sugest&atilde;o</asp:ListItem>
                      </asp:DropDownList>
                </td>
                </tr>
                <tr>
                  <td height="19" colspan="2">
                    <asp:Button ID="btnEnviar" runat="server" Text="Enviar" 
                          onclick="btnEnviar_Click" />
                    <asp:Button ID="btnLimpar" runat="server" Text="Limpar" 
                          onclick="btnLimpar_Click" />                 
                  </td>
                </tr>
              </table>
            </p>
              </div>
              
                    <div class="unico_informacoes_colegioContato">
            			<p align="center"><span class="unico_informacoes_colegioContato">Rua Zezito Costa Rego, n&ordm; 130. 
              			<br />
              			Cidade Universitária. Recife - PE
              			<br />
              			81. 3271.0233  www.colegioconhecer.com.br            </span></p>
            		</div>
              </div>
                
              </div>
              
            
            <!-- Fim esquerda_artigo 1 -->   
            
             <div class="unico_artigos_detalhe_inferior"><!-- Fim da Curva de Estilo do Arquivo a Esquerda -->
        		<div class="unico_artigos_detalhe_inferior_esquerda"></div>
            	<div class="unico_artigos_detalhe_inferior_meio"></div>
            	<div class="unico_artigos_detalhe_inferior_direita"></div>
            </div><!-- Fim esquerda_artigos_detalhe_inferior -->
            
        </div><!-- Fim esquerda -->

</div><!-- Fim Conteúdo -->
</asp:Content>