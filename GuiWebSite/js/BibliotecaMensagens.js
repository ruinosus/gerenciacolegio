/* 
  Empresa: Apply Solutions

 * Biblioteca que cont�m as mensagens utilizadas em todas as outras bibliotecas de js.
 * Deve ser incluida em todas as jsp's.
 *
 *  Depende
 * 	BibliotecaFuncoesPrincipal.js
 *  @autor: Rian Machado
 */


	// armazena todas as mensagens do sistema, 20 mensagens por biblioteca
	_mensagens = new Array(250);

	// Mensagens da BibliotecaFuncoesPrincipal
	_mensagens[0] = "Obs: Este campo � obrigat�rio!  (*)";
	_mensagens[1] = "Obs: Este campo n�o � obrigat�rio!";
	_mensagens[2] = "Campo obrigat�rio! (*)";
	_mensagens[3] = "Confirma ?";
	
	// Mensagens da BibliotecaFuncoesText
	_mensagens[20] = "Campo num�rico inv�lido!";
	_mensagens[21] = "O valor m�ximo � de !";
	_mensagens[22] = "O valor m�nimo � de !";
	_mensagens[23] = "O n�mero precisa ter  caracteres!";
	_mensagens[24] = "O campo deve ter no m�nimo caracteres!";
	_mensagens[25] = "O campo deve ter no m�ximo caracteres!";
	_mensagens[26] = "Campo num�rico negativo inv�lido!";	
	_mensagens[27] = "Campo num�rico positivo inv�lido!";
	
	// Mensagens da BibliotecaFuncoesRadio
	_mensagens[40] = "Nenhum registro dispon�vel!";
	_mensagens[41] = "Selecione um registro!";
	
	// Mensagens da BibliotecaFuncoesPaginacao
	_mensagens[60] = "O n�mero da p�gina escolhida tem que estar entre 1 e !";
	_mensagens[61] = "Esta j� � a primeira p�gina!";
	_mensagens[62] = "Esta j� � a �ltima p�gina!";			
	_mensagens[63] = "Valor num�rico inv�lido!";				
	
	// Mensagens da BibliotecaFuncoesDataHora
	_mensagens[80] = "Hora inv�lida!";
	_mensagens[81] = "Data inv�lida!";
	_mensagens[82] = "O ano deve ser maior ou igual a 1900!";
	_mensagens[83] = "A data deve ser maior que !";	
	_mensagens[84] = "A data deve ser menor que !";	
	_mensagens[85] = "A data deve ser maior ou igual a !";	
	_mensagens[86] = "A data deve ser menor ou igual a !";	

	// BibliotecaFuncoesListBox.js
	_mensagens[100] = "Selecione um item da lista!";
	_mensagens[101] = "Selecione pelo menos um item da lista!";
	_mensagens[102] = "Insira pelo menos um item na lista!";

	// BibliotecaFuncoesDecimal.js;BibliotecaFuncoesMoeda.js
	_mensagens[120] = "Valor Monet�rio inv�lido!";
	_mensagens[121] = "Valor decimal inv�lido!";

	// BibliotecaFuncoesVeiculo.js
	_mensagens[122] = "Valor inv�lido! \nDeve ser do tipo AA-999";
	_mensagens[123] = "Valor inv�lido! \nDeve conter apenas n�meros ou letras";

	// BibliotecaFuncoesCNPF_CNPJ.js
	_mensagens[140] = "CPF inv�lido!";
	_mensagens[141] = "CNPJ inv�lido!";
	
	_mensagens[142] = "Deseja realmente excluir registro ?";
	
	_mensagens[143] = "Deseja realmente registra evas�o ?";
	_mensagens[200] = "Campos obrigat�rios devem ser informados!";
	_mensagens[201] = "Informe o im�vel!";
	_mensagens[202] = "Selecione uma Inscri��o Mecantil Valida!";
	_mensagens[203] = "Informe um dos campos!";
	
	_mensagens[205] = "Valor inv�lido! \nDeve conter apenas n�meros";

	
	_mensagens[300] = "Selecione algum filtro !";


	// obtem a mensagem desejada
	function mensagemSistema(pCdMensagem) {
		
		return _mensagens[pCdMensagem];
	}
