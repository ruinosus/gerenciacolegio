 
function ValidateRadio(name){
	return _ValidateRadio_(name,false,'');
}

function ValidateRadio(name,message){
	return _ValidateRadio_(name,true,message);
}

function ValidateCheckBox(name,message){
	return _ValidateRadio_(name,true,message);
}


function _ValidateRadio_(name,showMessage,message){
	var response = false;
	$('input:radio').each(function(){
		if(this.name.indexOf(name) != -1 && this.checked && this.value != 0){
			response = true;
		}
	});
	if(!response && showMessage){
		ShowMessage(message);
	}	
	return response;
}

function _ValidateCheckBox_(name,showMessage,message){
	var response = false;
	$('input:checkbox').each(function(){
		if(this.name.indexOf(name) != -1 && this.checked && this.value != 0){
			response = true;
		}
	});
	if(!response && showMessage){
		ShowMessage(message);
	}	
	return response;
}


function ShowMessage(message){
	$('#MessageError').text(message);
	$('#MessageError').show();
}

function Confirm(message){
	return window.confirm(message);
}

function checkOnlyOne(e, id) {
    var rbt = document.getElementsByTagName("input");

    for (var i = 0; i < rbt.length; i++) {
        if (rbt[i].type == "radio" && rbt[i].name.indexOf(id) != -1) {
            if (rbt[i] != e) {
                rbt[i].checked = !e.checked;
            }
        }
    }
}

function validaCNPJ(value) {
           CNPJ = value;
           erro = new String;
            if (CNPJ.length < 18) erro += "É' necessários preencher corretamente o número do CNPJ. \n\n";
            
            if ((CNPJ.charAt(2) != ",") || (CNPJ.charAt(6) != ",") || (CNPJ.charAt(10) != "/") || (CNPJ.charAt(15) != "-")){
                if (erro.length == 0) erro += "É necessários preencher corretamente o número do CNPJ. \n\n";
            }

            //substituir os caracteres que nao sao numeros
            if(document.layers && parseInt(navigator.appVersion) == 4){
                x = CNPJ.substring(0,2);
                x += CNPJ.substring(3,6);
                x += CNPJ.substring(7,10);
                x += CNPJ.substring(11,15);
                x += CNPJ.substring(16,18);
                CNPJ = x;
            } else {
                CNPJ = CNPJ.replace(",","");
                CNPJ = CNPJ.replace(",","");
                CNPJ = CNPJ.replace("-","");
                CNPJ = CNPJ.replace("/","");
           }
          var nonNumbers = /\D/;
          if (nonNumbers.test(CNPJ)) erro += "Informe apenas números. \n\n";
            var a = [];
            var b = new Number;
            var c = [6,5,4,3,2,9,8,7,6,5,4,3,2];
            for (i=0; i<12; i++){
                a[i] = CNPJ.charAt(i);
                b += a[i] * c[i+1];
            }
            if ((x = b % 11) < 2) { a[12] = 0 } else { a[12] = 11-x }
            b = 0;
            for (y=0; y<13; y++) {
                b += (a[y] * c[y]);
            }
            if ((x = b % 11) < 2) { a[13] = 0; } else { a[13] = 11-x; }
            if ((CNPJ.charAt(12) != a[12]) || (CNPJ.charAt(13) != a[13])){
                erro +="CNPJ informado invalido.";
            }
            if (erro.length > 0){
                alert(erro);

                
            }else return true;
                
             return false;
   }
