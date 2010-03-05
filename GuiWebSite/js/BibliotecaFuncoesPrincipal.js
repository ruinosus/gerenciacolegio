/* 
  Empresa: Apply Solutions

 * Biblioteca que contém as funções mais utilizadas em todas as bibliotecas.
 *           ********************************** ATENÇÃO *********************************
 *           * Este arquivo possui, atualmente, todas as outras bibliotecas javascript. *
 *           ****************************************************************************
 *
 *  Depende
 * 	BibliotecaFuncoesPrincipal.js
 * 	BibliotecaMensagens.js
 *  @autor: Rian Machado
 */

/*
	Submete o formulario redirecionando para  a pagina de erro
*/
function submeterFormularioErro(pAcao, pEvento) {
	
	if ( pEvento == CD_HISTORY_BACK ) {
		window.history.back();
		return;
	}
			
	document.forms[0].nmProximaAcaoErroEvento.value = pEvento;
	document.forms[0].nmProximaAcaoErro.value = pAcao;
	//document.forms[0].action = pAcao + VL_EXTENCAO_ACAO;
	document.forms[0].action = pAcao;

	document.forms[0].submit();
}

/*
	Focaliza o campo
*/
function focarCampo(pInput) {
	
    if ( (pInput.type != "hidden") && (pInput.readOnly != true) ) {
    	pInput.focus();
    }
}

/*
	Exibe uma mensagem no browser
*/
function exibirMensagem(pTexto) {
	alert(pTexto);
}





/*
	Verifica se o campo esta vazio
*/
function isCampoVazio(pInput, pExibirMensagem) {

	if ( trim(pInput.value) == "" ) {

		if ( pExibirMensagem ) {

			pInput.select();
			exibirMensagem(mensagemSistema(2));
			focarCampo(pInput);
		}
		
		return true;
	} else {
		
		return false;
	}
}

/*
	Remove os espacos a esquerda
*/
function ltrim(pString) {
	return pString.replace(/^\s*/, "")
}

/*
	Remove os espacos a direita
*/
function rtrim(pString) {
	return pString.replace(/\s*$/, "");
}

/*
	Remove os espacos dos dois lados
*/
function trim(pString) {
	return rtrim(ltrim(pString));
}

// Verifica se a tecla digitada trata-se de uma tecla funcional
function isTeclaFuncional(pEvento){
	var retorno = false;

	if (pEvento != null) {
		keyCode = pEvento.keyCode;
		
		switch(keyCode) {
			case 8  : retorno = true;break; //
			case 9  : retorno = true;break; //
			case 13 : retorno = true;break; //enter
			case 16 : retorno = true;break; //
			case 35 : retorno = true;break; //
			case 36 : retorno = true;break; //
			case 37 : retorno = true;break; //
			case 38 : retorno = true;break; //
			case 39 : retorno = true;break; //
			case 40 : retorno = true;break;	//
		}
	}

	return retorno;
}

function getJanelaAuxiliar(pUrlJanela, pNmJanela) {
	
	largura = screen.availWidth - 12; //720

	altura = screen.availHeight - 51; //500
	
	janelaAuxiliar = window.open(pUrlJanela, pNmJanela, "width=" + largura + ", height=" + altura +", menubar=no, scrollbars=yes, toolbar=no, status=yes, resizable=yes, left=0, top=0, screenX=0, screenY=0");

	return janelaAuxiliar;
}

function abrirJanelaAuxiliar(pUrlJanela) {

	var _nmJanelaAuxiliar = NM_JANELA_AUXILIAR;
	if (window.opener != null) {
		timeStamp = new Date();
		_nmJanelaAuxiliar = _nmJanelaAuxiliar + timeStamp.getTime();
	}
	
	janelaAuxiliar = getJanelaAuxiliar(pUrlJanela, _nmJanelaAuxiliar);
	
	janelaAuxiliar.focus();
}

function getJanelaAuxiliarEmBranco(pNmJanela) {
	
	largura = screen.availWidth - 12; //720

	altura = screen.availHeight - 51; //500
	
	janelaAuxiliar = window.open('', pNmJanela, "width=" + largura + ", height=" + altura +", menubar=no, scrollbars=yes, toolbar=no, status=yes, resizable=yes, left=0, top=0, screenX=0, screenY=0");

	return janelaAuxiliar;
}

function submeterFormularioJanelaAuxiliar(pAcao, pEvento, pForcarNovaJanela) {

	var _nmJanelaAuxiliar = NM_JANELA_AUXILIAR;
	var targetAntigo = document.forms[0].target;
	
	if (pForcarNovaJanela || window.opener != null) {
		timeStamp = new Date();
		_nmJanelaAuxiliar = _nmJanelaAuxiliar + timeStamp.getTime();
	}
	
	janelaAuxiliar = getJanelaAuxiliarEmBranco(_nmJanelaAuxiliar);
	
	document.forms[0].target = _nmJanelaAuxiliar;
	
	document.forms[0].nmProximaAcaoEvento.value = pEvento;
	document.forms[0].nmProximaAcao.value = pAcao;
	document.forms[0].action = pAcao;

	document.forms[0].submit();
	
	document.forms[0].target = targetAntigo;	
	
	janelaAuxiliar.focus();
}

// Solicita a confirmação do usuário. Se pTexto for nulo, será exibida uma mensagem padrão de confirmação.
function solicitarConfirmacao(pTexto) {
	if (pTexto == null) {
		var resposta = window.confirm(mensagemSistema(3));
	} else {
		var resposta = window.confirm(pTexto);
	}

	return resposta;
}

// Oculta um elemento pelo seu id
function ocultarElemento(pIdElemento) {
	document.getElementById(pIdElemento).style.display = "none";
}

// Exibe um documento oculto
function exibirElemento(pIdElemento) {
	document.getElementById(pIdElemento).style.display = "";
}

// exibe a mensagem do formulario
function exibirMensagemFormulario() {
	
	if ( document.forms[0].mensagem.value != '' ) {

		alert(document.forms[0].mensagem.value);
		document.forms[0].mensagem.value = '';
	}
}

// Fecha a janela atual
function fecharJanela() {
	window.close();
}




