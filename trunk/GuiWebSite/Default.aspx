<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="corpo" runat="Server"> 
            <div id="conteudoCorpo">
    <div class="esquerda">
        
        	<div class="esquerda_artigos_detalhe_superior"><!-- Inicio da Curva de Estilo do Arquivo a Esquerda -->
        		<div class="esquerda_artigos_detalhe_superior_esquerda"></div>
            	<div class="esquerda_artigos_detalhe_superior_meio"></div>
            	<div class="esquerda_artigos_detalhe_superior_direita"></div>
            </div><!-- Fim esquerda_artigos_detalhe_superior -->
            
            <!-- Inicio do Artigo 1 a Esquerda da Página -->
            
        	<div class="esquerda_artigos">
            
              <div class="esquerda_artigos_titulo">
                <p><span class="style1"><asp:Label ID="lblTituloEsquerda1" runat="server" Text="NOTÍCIA" /></span>       	        
                <asp:Image ID="imgBarraArtigoEsquerda1" runat="server" ImageUrl="App_Themes/Default/Imagens/barraArtigoEsquerda.png"
                                Width="324" Height="6" />             
                </p>
              </div>
              
              <div class="esquerda_artigos_texto_index">
              	<p align="justify"><asp:Label ID="lblTextoArtigoEsquerda1" runat="server"/></p>
              </div>
              
        	</div>
            
            <!-- Fim esquerda_artigo 1 -->
            
            <!-- Inicio do Artigo 2 a Esquerda da Página -->
            
            <div class="esquerda_artigos">
            
              <div class="esquerda_artigos_titulo">
                <p><span class="style1"><asp:Label ID="lblTituloEsquerda2" runat="server" Text="AVISOS" /></span>       	        
                    <asp:Image ID="imgBarraArtigoEsquerda2" runat="server" ImageUrl="App_Themes/Default/Imagens/barraArtigoEsquerda.png"
                                Width="324" Height="6" />               
                </p>
              </div>
              
              <div class="esquerda_artigos_imagem_index">
              	<p align="justify"><asp:Label ID="lblTextoArtigoEsquerda2" runat="server"/></p>
              </div>
              
        	</div>
            
            <!-- Fim esquerda_artigo 2 -->
            
             <div class="esquerda_artigos_detalhe_inferior"><!-- Fim da Curva de Estilo do Arquivo a Esquerda -->
        		<div class="esquerda_artigos_detalhe_inferior_esquerda"></div>
            	<div class="esquerda_artigos_detalhe_inferior_meio"></div>
            	<div class="esquerda_artigos_detalhe_inferior_direita"></div>
            </div><!-- Fim esquerda_artigos_detalhe_inferior -->
            
            <div class="esquerda_informacoes_colegio">
            <p align="center">Rua Zezito Costa Rego, n&ordm; 130. 
              <br />
              Cidade Universitária. Recife - PE
              <br />
              81. 3271.0233  www.colegioconhecer.com.br            </p>
            </div>
            
        </div><!-- Fim esquerda -->
        
        
        <!-- Inicio do Conteúdo do Meio da Página -->
        
                <div class="meio"><!-- Inicio do Conteúdo Meio da Página -->
        
        	<div class="meio_artigos_detalhe_superior"><!-- Inicio da Curva de Estilo do Arquivo a Meio -->
        		<div class="meio_artigos_detalhe_superior_esquerda"></div>
            	<div class="meio_artigos_detalhe_superior_meio"></div>
            	<div class="meio_artigos_detalhe_superior_direita"></div>
            </div><!-- Fim meio_artigos_detalhe_superior -->
            
        	<div class="meio_artigos"><!-- Inicio do Artigo 1 a Meio da Página -->
            
            <div class="meio_artigos_titulo">
                <p><span class="style1"><asp:Label ID="lblTituloMeio1" runat="server" Text="TITULO 01" /></span>       	        
                   <asp:Image ID="imgBarraArtigoMeio1" runat="server" ImageUrl="App_Themes/Default/Imagens/barraArtigoEsquerda.png"
                                Width="270" Height="6" />                 
                </p>
              </div>
              
              <div class="meio_artigos_texto_index">
              	<p align="justify"><asp:Label ID="lblTextoArtigoMeio1" runat="server"/></p>
              </div>
              
              <div class="meio_artigos_imagem_index"><asp:Image ID="imgArtigoMeio1" runat="server" Width="270"  Height="130" Visible="False" /> </div>
            
            </div><!-- Fim meio_artigos -->
            
             <div class="meio_artigos_detalhe_inferior"><!-- Fim da Curva de Estilo do Arquivo a Meio -->
        		<div class="meio_artigos_detalhe_inferior_esquerda"></div>
            	<div class="meio_artigos_detalhe_inferior_meio"></div>
            	<div class="meio_artigos_detalhe_inferior_direita"></div>
            </div><!-- Fim meio_artigos_detalhe_inferior -->
            
        </div><!-- Fim Meio -->
                
        
        <!-- Inicio do Conteúdo da Direita da Página -->
        
                <div class="direita"><!-- Inicio do Conteúdo Direita da Página -->
        
        	<div class="direita_artigos_detalhe_superior"><!-- Inicio da Curva de Estilo do Arquivo a Direita -->
        		<div class="direita_artigos_detalhe_superior_esquerda"></div>
            	<div class="direita_artigos_detalhe_superior_meio"></div>
            	<div class="direita_artigos_detalhe_superior_direita"></div>
            </div><!-- Fim direita_artigos_detalhe_superior -->
            
        	<div class="direita_artigos"><!-- Inicio do Artigo 1 a Direita da Página -->
            
                        <div class="direita_artigos_titulo">
                <p><span class="style1"><asp:Label ID="lblTituloDireita1" runat="server" Text="TITULO 02" /></span>       	        
                   <asp:Image ID="imgBarraArtigoDireita1" runat="server" ImageUrl="App_Themes/Default/Imagens/barraArtigoEsquerda.png"
                                Width="290" Height="6" />                  
                </p>
              </div>
              
              <div class="direita_artigos_texto_index">
              	<p align="justify"><asp:Label ID="lblTextoArtigoDireita1" runat="server"/></p>
              </div>
              
              <div class="direita_artigos_imagem_index"><asp:Image ID="imgArtigoDireita1" 
                      runat="server" Width="290"  Height="165" Visible="False" /></div>            
            
            </div><!-- Fim direita_artigos -->
            
             <div class="direita_artigos_detalhe_inferior"><!-- Fim da Curva de Estilo do Arquivo a Direita -->
        		<div class="direita_artigos_detalhe_inferior_esquerda"></div>
            	<div class="direita_artigos_detalhe_inferior_meio"></div>
            	<div class="direita_artigos_detalhe_inferior_direita"></div>
            </div><!-- Fim direita_artigos_detalhe_inferior -->
            
        </div><!-- Fim Direita -->
        </div>
</asp:Content>
