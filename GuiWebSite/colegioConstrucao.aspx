<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="colegioConstrucao.aspx.cs" Inherits="colegioConstrucao" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .style5
        {
            word-spacing: 2px;
            text-align: center;
        }
    </style>
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
                <p><span class="style1Atividades"><asp:Label ID="lblTituloMeio1" runat="server" Text="PÁGINA EM CONSTRUÇ&Atilde;O" /></span>       	        
                <asp:Image ID="imgBarraArtigoMeio1" runat="server" ImageUrl="App_Themes/Default/Imagens/barraArtigoUnico.png" Width="930" Height="6" />    </p>                
              </div>
              
              <div class="unico_artigos_texto_index_const">
				<p class="style5">Infelizmente esta página ainda esta em construç&atilde;o, dentro de 
                    alguns dias estaremos disponibilizando-a com novo conteúdo. </p>
                  <p class="style5">&nbsp;</p>
                  <p class="style5">O Colégio Conhecer agradece a sua compreens&atilde;o.</p>       	              
              </div>
              
                    <div class="unico_informacoes_colegio_const">
            			<p align="center"><span class="unico_informacoes_colegioContato">Rua Zezito Costa Rego, n&ordm; 130. 
              			<br />
              			Cidade Universitária. Recife - PE
              			<br />
              			81. 3271.0233  www.colegioconhecer.com.br            </span></p>
            		</div>
              </div>
                
              </div>
            
        </div><!-- Fim esquerda -->
        </div>
            </asp:Content>

