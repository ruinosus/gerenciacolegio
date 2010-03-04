<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="colegioPost.aspx.cs" Inherits="colegioPost" %>

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
                <p><span class="style1Atividades"><asp:Label ID="lblTituloMeio1" runat="server" Text="TÍTULO PUBLICAÇÃO" /></span>       	        
                <asp:Image ID="imgBarraArtigoMeio1" runat="server" ImageUrl="App_Themes/Default/Imagens/barraArtigoUnico.png" Width="930" Height="6" />    </p>                
              </div>
              
              <div class="unico_artigos_texto_index_atv">
				<asp:Label ID="lblArtigoUnico1" runat="server" />
              <div class="unico_artigos_texto_index_atv_dv">
              	              
              </div>
              
                    <div class="unico_informacoes_colegio">
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
        </div>
            </asp:Content>
