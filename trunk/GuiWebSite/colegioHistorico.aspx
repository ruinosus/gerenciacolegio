<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="colegioHistorico.aspx.cs" Inherits="colegioHistorico" %>

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
                <p><span class="style1Atividades">Hist&oacute;rico</span>       	        
                <asp:Image ID="imgBarraArtigoUnico1" runat="server" ImageUrl="App_Themes/Default/Imagens/barraArtigoUnico.png" Width="930" Height="6" />               </p>
              </div>
              
              <div class="unico_artigos_texto_index">
              	<p><span class="style3Hist"> O Col&eacute;gio Conhecer, h&aacute; 30 anos, dedica-se &agrave; educa&ccedil;&atilde;o de crian&ccedil;as e adolescentes de modo a formar cidad&atilde;os conscientes de seus direitos e deveres, respeitando as diferen&ccedil;as, no que tange &agrave; diversidade humana, e o meio ambiente que acolhe a todos n&oacute;s.</span></p>
              </div>
              <div class="unico_artigos_texto_index2">
              	<div class="unico_artigos_texto_index2_div1_hist"><asp:ImageButton ID="imgHistorico1" runat="server" ImageUrl="App_Themes/Default/Imagens/historico_simbolo1.png" width="144" height="138" />
              	  <p><span class="style4Hist">1 logo ainda eramos Escola Conhecer.</span></p>
              	</div>
				<div class="unico_artigos_texto_index2_div2_hist"><asp:ImageButton ID="imgHistorico2" runat="server" ImageUrl="App_Themes/Default/Imagens/historico_simbolo2.png" width="144" height="138" />
				<p><span class="style4Hist">2 logo, define a mudan&ccedil;a de Escola para Col&eacute;gio.</span></p>
				</div>
                <div class="unico_artigos_texto_index2_div3_hist"><asp:ImageButton ID="imgHistorico3" runat="server" ImageUrl="App_Themes/Default/Imagens/historico_simbolo3.png" width="144" height="138" />
                <p><span class="style4Hist">3 logo, define a inclus&atilde;o do Ensino M&eacute;dio.</span></p>
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