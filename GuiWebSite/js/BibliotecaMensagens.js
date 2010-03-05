/* 
  Empresa: Apply Solutions

 * Biblioteca que contém as mensagens utilizadas em todas as outras bibliotecas de js.
 * Deve ser incluida em todas as jsp's.
 *
 *  Depende
 * 	BibliotecaFuncoesPrincipal.js
 *  @autor: Rian Machado
 */


	// armazena todas as mensagens do sistema, 20 mensagens por biblioteca
	_mensagens = new Array(250);

	// Mensagens da BibliotecaFuncoesPrincipal
	_mensagens[0] = "Obs: Este campo é obrigatório!  (*)";
	_mensagens[1] = "Obs: Este campo não é obrigatório!";
	_mensagens[2] = "Campo obrigatório! (*)";
	_mensagens[3] = "Confirma ?";
	
	// Mensagens da BibliotecaFuncoesText
	_mensagens[20] = "Campo numérico inválido!";
	_mensagens[21] = "O valor máximo é de !";
	_mensagens[22] = "O valor mínimo é de !";
	_mensagens[23] = "O número precisa ter  caracteres!";
	_mensagens[24] = "O campo deve ter no mínimo caracteres!";
	_mensagens[25] = "O campo deve ter no máximo caracteres!";
	_mensagens[26] = "Campo numérico negativo inválido!";	
	_mensagens[27] = "Campo numérico positivo inválido!";
	
	// Mensagens da BibliotecaFuncoesRadio
	_mensagens[40] = "Nenhum registro disponível!";
	_mensagens[41] = "Selecione um registro!";
	
	// Mensagens da BibliotecaFuncoesPaginacao
	_mensagens[60] = "O número da página escolhida tem que estar entre 1 e !";
	_mensagens[61] = "Esta já é a primeira página!";
	_mensagens[62] = "Esta já é a última página!";			
	_mensagens[63] = "Valor numérico inválido!";				
	
	// Mensagens da BibliotecaFuncoesDataHora
	_mensagens[80] = "Hora inválida!";
	_mensagens[81] = "Data inválida!";
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
	_mensagens[120] = "Valor Monetário inválido!";
	_mensagens[121] = "Valor decimal inválido!";

	// BibliotecaFuncoesVeiculo.js
	_mensagens[122] = "Valor inválido! \nDeve ser do tipo AA-999";
	_mensagens[123] = "Valor inválido! \nDeve conter apenas números ou letras";

	// BibliotecaFuncoesCNPF_CNPJ.js
	_mensagens[140] = "CPF inválido!";
	_mensagens[141] = "CNPJ inválido!";
	
	_mensagens[142] = "Deseja realmente excluir registro ?";
	
	_mensagens[143] = "Deseja realmente registra evasão ?";
	_mensagens[200] = "Campos obrigatórios devem ser informados!";
	_mensagens[201] = "Informe o imóvel!";
	_mensagens[202] = "Selecione uma Inscrição Mecantil Valida!";
	_mensagens[203] = "Informe um dos campos!";
	
	_mensagens[205] = "Valor inválido! \nDeve conter apenas números";

	
	_mensagens[300] = "Selecione algum filtro !";


	// obtem a mensagem desejada
	function mensagemSistema(pCdMensagem) {
		
		return _mensagens[pCdMensagem];
	}
