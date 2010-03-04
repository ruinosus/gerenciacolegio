<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="colegioImagens.aspx.cs" Inherits="colegioImagens" %>

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
            
        	<div class="unico_artigos3">
           
           <!-- INICIO DA DIV ESQUERDA INTERNA -->
           
           <div class="unico_artigos_texto_indexImgEsquerda">
           <div class="unico_artigos_texto_indexImg2">
           <table width="180" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td colspan="2"><asp:ImageButton ID="imbMenu1" runat="server" ImageUrl="App_Themes/Default/Imagens/menuEsquerda3.png"
                                                        width="150" height="45"  hspace="0" vspace="10" /></td>
    </tr>
  <tr>
    <td colspan="2">
        <asp:DropDownList ID="ddlOpcoes" runat="server" Width="160px">
        </asp:DropDownList>
   </td>
    </tr>
  <tr>
    <td><label>
        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="rdb" />
    </label></td>
    <td><asp:ImageButton ID="imbMenu2" runat="server" ImageUrl="App_Themes/Default/Imagens/menu_edInfantil.png"
                                                        width="72" height="25"  hspace="10" vspace="10" /></td>
  </tr>
  <tr>
    <td><label>
        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="rdb" />
    </label></td>
    <td><asp:ImageButton ID="imbMenu3" runat="server" ImageUrl="App_Themes/Default/Imagens/menu_edFund1.png"
                                                        width="110" height="25"  hspace="10" vspace="10" /></td>
  </tr>
  <tr>
    <td><label>
        <asp:RadioButton ID="RadioButton3" runat="server" GroupName="rdb" />
    </label></td>
    <td><asp:ImageButton ID="imbMenu4" runat="server" ImageUrl="App_Themes/Default/Imagens/menu_edFund2.png"
                                                        width="118" height="25"  hspace="10" vspace="10" /></td>
  </tr>
  <tr>
    <td><label>
        <asp:RadioButton ID="RadioButton4" runat="server" GroupName="rdb" />
    </label></td>
    <td><asp:ImageButton ID="imbMenu5" runat="server" ImageUrl="App_Themes/Default/Imagens/menu_Medio.png"
                                                        width="52" height="25"  hspace="10" vspace="10" /></td>
  </tr>
</table>

           </div>
           
           <div class="unico_artigos_texto_indexImg">
								                        <div class="esquerda_informacoes_colegio2">
            <p align="center"><span class="unico_informacoes_colegio">Rua Zezito Costa Rego, n&ordm; 130. 
              <br/>Cidade Universitária. Recife - PE
              <br/>81. 3271.0233
              <br/> www.colegioconhecer.com.br            </span></p>
           </div>
           </div>
           </div>
           
           <!-- FIM DA DIV ESQUERDA INTERNA -->
           
           <div class="unico_artigos_texto_indexImgMeio"><asp:ImageButton ID="imbDestaque" runat="server" ImageUrl="App_Themes/Default/Imagens/imagem_MOD_imagens_maior.png"
                                                        Width="340" Height="326"  /></div>
           
           <!-- INICIO DA DIV MEIO INTERNA -->
           <div class="unico_artigos_texto_indexImgDireita">
            <div class="unico_artigos_texto_index2_divImg">
                	<div class="unico_artigos_texto_index2_atv_dv2"><asp:ImageButton ID="imbImgDetalhe1" runat="server" ImageUrl="App_Themes/Default/Imagens/imagem_MOD_imagens.png"
                                                        Width="80" Height="77"  />
              	  													<p><span class="style4Atividades"><asp:Label ID="DescricaoImgDetalhe1" runat="server" /></span></p>
                    </div>
                	<div class="unico_artigos_texto_index2_atv_dv2"><asp:ImageButton ID="imbImgDetalhe2" runat="server" ImageUrl="App_Themes/Default/Imagens/imagem_MOD_imagens.png"
                                                        Width="80" Height="77"  />
              	  													<p><span class="style4Atividades"><asp:Label ID="DescricaoImgDetalhe2" runat="server" /></span></p>
                    </div>
                	<div class="unico_artigos_texto_index2_atv_dv2"><asp:ImageButton ID="imbImgDetalhe3" runat="server" ImageUrl="App_Themes/Default/Imagens/imagem_MOD_imagens.png"
                                                        Width="80" Height="77"  />
              	  													<p><span class="style4Atividades"><asp:Label ID="DescricaoImgDetalhe3" runat="server" /></span></p>
                    </div>
              	</div>
                
                <div class="unico_artigos_texto_index2_divImg">
                	<div class="unico_artigos_texto_index2_atv_dv2"><asp:ImageButton ID="imbImgDetalhe4" runat="server" ImageUrl="App_Themes/Default/Imagens/imagem_MOD_imagens.png"
                                                        Width="80" Height="77"  />
              	  													<p><span class="style4Atividades"><asp:Label ID="DescricaoImgDetalhe4" runat="server" /></span></p>
                    </div>
                	<div class="unico_artigos_texto_index2_atv_dv2"><asp:ImageButton ID="imbImgDetalhe5" runat="server" ImageUrl="App_Themes/Default/Imagens/imagem_MOD_imagens.png"
                                                        Width="80" Height="77"  />
              	  													<p><span class="style4Atividades"><asp:Label ID="DescricaoImgDetalhe5" runat="server" /></span></p>
                    </div>
                	<div class="unico_artigos_texto_index2_atv_dv2"><asp:ImageButton ID="imbImgDetalhe6" runat="server" ImageUrl="App_Themes/Default/Imagens/imagem_MOD_imagens.png"
                                                        Width="80" Height="77"  />
              	  													<p><span class="style4Atividades"><asp:Label ID="DescricaoImgDetalhe6" runat="server" /></span></p>
                    </div>
              	</div>
                
                <div class="unico_artigos_texto_index2_divImg">
                	<div class="unico_artigos_texto_index2_atv_dv2"><asp:ImageButton ID="imbImgDetalhe7" runat="server" ImageUrl="App_Themes/Default/Imagens/imagem_MOD_imagens.png"
                                                        Width="80" Height="77"  />
              	  													<p><span class="style4Atividades"><asp:Label ID="DescricaoImgDetalhe7" runat="server" /></span></p>
                    </div>
                	<div class="unico_artigos_texto_index2_atv_dv2"><asp:ImageButton ID="imbImgDetalhe8" runat="server" ImageUrl="App_Themes/Default/Imagens/imagem_MOD_imagens.png"
                                                        Width="80" Height="77"  />
              	  													<p><span class="style4Atividades"><asp:Label ID="DescricaoImgDetalhe8" runat="server" /></span></p>
                    </div>
                	<div class="unico_artigos_texto_index2_atv_dv2"><asp:ImageButton ID="imbImgDetalhe9" runat="server" ImageUrl="App_Themes/Default/Imagens/imagem_MOD_imagens.png"
                                                        Width="80" Height="77"  />
              	  													<p><span class="style4Atividades"><asp:Label ID="DescricaoImgDetalhe9" runat="server" /></span></p>
                    </div>
                </div>
           </div>
           <!-- FIM DA DIV MEIO INTERNA -->
           </div>
              
            
        </div><!-- Fim esquerda -->
        
</div><!-- Fim Conteúdo -->
            </asp:Content>