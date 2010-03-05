// JavaScript Document
// @autor: Jorge Cruz
function mascara(src, mask){

if(src.value.length >=8){
 event.keyCode = 0;
 return false;
}

var i = src.value.length;

var saida = mask.substring(i,i+1);

var ascii = event.keyCode;

if (saida == "B") //Não aceita número como entrada no teclado

{ 

if ((ascii < 48) && (ascii > 57))

{

event.keyCode -= 32;

}

else

{

event.keyCode = 0;

}

}else

if (saida == "A") //Aceita somente letras do alfabeto e maiúsculas como entrada no teclado

{

if ((ascii >=97) && (ascii <= 122))

{

event.keyCode -= 32;

}

else

{

event.keyCode = 0;

}

}else

if (saida == "0") //Aceita somente números como entrada no teclado

{

if ((ascii >= 48) && (ascii <= 57))

{

return

}

else

{

event.keyCode = 0

}

}

else //Aceita qualquer entrada no teclado

if (saida == "#")

{

return;

}

else

{

src.value += saida;

i += 1

saida = mask.substring(i,i+1);

if (saida == "A")

{

if ((ascii >=97) && (ascii <= 122))

{

event.keyCode -= 32;

}else

{

event.keyCode = 0;

}

}else

if (saida == "0")

{

if ((ascii >= 48) && (ascii <= 57))

{

return

}else

{

event.keyCode = 0

}

}else

{

return;

}

}

} 


//Função para Formatar Valor em Javascript

//mascara para valor
//this.id, tamanho de caracteres, event
function FormataValor(id,tammax,teclapres) {

    if(window.event) { // Internet Explorer
        var tecla = teclapres.keyCode; }
    else if(teclapres.which) { // Nestcape / firefox
        var tecla = teclapres.which;
    }

    vr = document.getElementById(id).value;
    vr = vr.toString().replace( "/", "" );
    vr = vr.toString().replace( "/", "" );
    vr = vr.toString().replace( ",", "" );
    vr = vr.toString().replace( ".", "" );
    vr = vr.toString().replace( ".", "" );
    vr = vr.toString().replace( ".", "" );
    vr = vr.toString().replace( ".", "" );
    tam = vr.length;

    if (tam < tammax && tecla != 8){ tam = vr.length + 1; }

    if (tecla == 8 ){ tam = tam - 1; }

    if ( tecla == 8 || tecla >= 48 && tecla <= 57 || tecla >= 96 && tecla <= 105 ){
    if ( tam <= 2 ){
    document.getElementById(id).value = vr; }
    if ( (tam > 2) && (tam <= 5) ){
    document.getElementById(id).value = vr.substr( 0, tam - 2 ) + ',' + vr.substr( tam - 2, tam ); }
    if ( (tam >= 6) && (tam <= 8) ){
    document.getElementById(id).value = vr.substr( 0, tam - 5 ) + '.' + vr.substr( tam - 5, 3 ) + ',' + vr.substr( tam - 2, tam ); }
    if ( (tam >= 9) && (tam <= 11) ){
    document.getElementById(id).value = vr.substr( 0, tam - 8 ) + '.' + vr.substr( tam - 8, 3 ) + '.' + vr.substr( tam - 5, 3 ) + ',' + vr.substr( tam - 2, tam ); }
    if ( (tam >= 12) && (tam <= 14) ){
    document.getElementById(id).value = vr.substr( 0, tam - 11 ) + '.' + vr.substr( tam - 11, 3 ) + '.' + vr.substr( tam - 8, 3 ) + '.' + vr.substr( tam - 5, 3 ) + ',' + vr.substr( tam - 2, tam ); }
    if ( (tam >= 15) && (tam <= 17) ){
    document.getElementById(id).value = vr.substr( 0, tam - 14 ) + '.' + vr.substr( tam - 14, 3 ) + '.' + vr.substr( tam - 11, 3 ) + '.' + vr.substr( tam - 8, 3 ) + '.' + vr.substr( tam - 5, 3 ) + ',' + vr.substr( tam - 2, tam );}
    }
}

//Check todos os inputs type=checkbox.
function CheckAll(sender){
    var Checks = document.getElementsByName(sender.name); 
    if(Checks != null && Checks.length > 0){
        for(i = 1; i < Checks.length; i++){
            Checks[i].checked = sender.checked;
        }
    }
}

//converter formato do valor para moeda.
function Converter(Valor,Modo){
    
    if(Modo == 1){
        
        Valor = Valor.replace(/\,/g,'|');
        Valor = Valor.replace(/\./g,',');
        Valor = Valor.replace(/\|/g,'.');

    }else{
        
        Valor = Valor.replace(/\./g,'|');
        Valor = Valor.replace(/\,/g,'.');
        Valor = Valor.replace(/\|/g,',');

    }
    
    return Valor;
}

//calcular preço final de produto conforme percentual IPI (onBlur do input IPI).       
function CalcularPrecoFinal_IPI(txtPercentual, txtPrecoCIF, txtPrecoCalculadoCIF, hddPrecoCalculadoCIF, txtPrecoFOB, txtPrecoCalculadoFOB, hddPrecoCalculadoFOB){
    
    var Percentual = 0;
    var PrecoInformadoCIF = 0;
    var PrecoCalculadoCIF = 0;
    var PrecoInformadoFOB = 0;
    var PrecoCalculadoFOB = 0;
    var IsValidCIF = false;
    var IsValidFOB = false;
    
    document.getElementById(txtPrecoCalculadoFOB).value = "";
    document.getElementById(txtPrecoCalculadoCIF).value = "";
    
    if(document.getElementById(txtPercentual) != null){
        Percentual = parseFloat(document.getElementById(txtPercentual).value.replace(/\,/g,'.'));
        document.getElementById(txtPercentual).value = document.getElementById(txtPercentual).value.replace(/\./g,',');      
    }
    
    if(document.getElementById(txtPrecoCIF) != null){
        document.getElementById(txtPrecoCIF).value = Converter(document.getElementById(txtPrecoCIF).value,1);
        PrecoInformadoCIF = parseFloat(document.getElementById(txtPrecoCIF).value);
        document.getElementById(txtPrecoCIF).value = Converter(document.getElementById(txtPrecoCIF).value,0);                
    }
    
    if(document.getElementById(txtPrecoFOB) != null && !isNaN(Converter(document.getElementById(txtPrecoFOB).value))){
        document.getElementById(txtPrecoFOB).value = Converter(document.getElementById(txtPrecoFOB).value,1);                
        PrecoInformadoFOB = parseFloat(document.getElementById(txtPrecoFOB).value);
        document.getElementById(txtPrecoFOB).value = Converter(document.getElementById(txtPrecoFOB).value,0);                            
    }
    
    if(Percentual > 0){            
        if(PrecoInformadoCIF > 0){
            document.getElementById(hddPrecoCalculadoCIF).value = Converter((PrecoInformadoCIF * ((100 + Percentual) / 100)).toFixed(4),0);
            document.getElementById(txtPrecoCalculadoCIF).value = document.getElementById(hddPrecoCalculadoCIF).value.replace(/\./g,',');
            IsValidCIF = true;
        }                    
        if(PrecoInformadoFOB > 0){
            document.getElementById(hddPrecoCalculadoFOB).value = Converter((PrecoInformadoFOB * ((100 + Percentual) / 100)).toFixed(4),0);
            document.getElementById(txtPrecoCalculadoFOB).value = document.getElementById(hddPrecoCalculadoFOB).value.replace(/\./g,',');
            IsValidFOB = true;
        }
    }
    
    if(!IsValidCIF){
        document.getElementById(txtPrecoCalculadoCIF).value = "";
        document.getElementById(hddPrecoCalculadoCIF).value = "";
    }
    
    if(!IsValidFOB){
        document.getElementById(txtPrecoCalculadoFOB).value = "";
        document.getElementById(hddPrecoCalculadoFOB).value = "";
    }
    
}

//calcular preço final de produto conforme percentual IPI.   
function CalcularPrecoFinal(txtPercentual, txtPreco, txtPrecoCalculado, hddPrecoCalculado){
    
    var Percentual = 0;
    var PrecoInformado = 0;
    var PrecoCalculado = 0;
    var IsValid = false;
    
    document.getElementById(txtPrecoCalculado).value = "";

    if(document.getElementById(txtPercentual) != null){
        Percentual = parseFloat(document.getElementById(txtPercentual).value.replace(/\,/g,'.'));
        document.getElementById(txtPercentual).value = document.getElementById(txtPercentual).value.replace(/\./g,',');   
    }
    
    if(document.getElementById(txtPreco)!= null){  
        document.getElementById(txtPreco).value = Converter(document.getElementById(txtPreco).value,1);
        PrecoInformado = parseFloat(document.getElementById(txtPreco).value);
        document.getElementById(txtPreco).value = Converter(document.getElementById(txtPreco).value,0);                
    }

    if(Percentual > 0){            
        if(PrecoInformado > 0){
            PrecoCalculado = (PrecoInformado * ((100 + Percentual) / 100));
            document.getElementById(hddPrecoCalculado).value = Converter(PrecoCalculado.toFixed(4),0).replace(/\./g,',');
            document.getElementById(txtPrecoCalculado).value = Converter(PrecoCalculado.toFixed(4),0).replace(/\./g,',');                                        
            IsValid = true;
        }
    }
    
    if(!IsValid){
        document.getElementById(hddPrecoCalculado).value = "";
        document.getElementById(txtPrecoCalculado).value = "";
    }
    
}

//Máscara para permitir somente números monetários no input.
//Exemplo: onkeydown="javascript:Mask_Currency(this, event);"
function Mask_Currency(sender, e){    

    var keyCode;
    if(window.event){ // Internet Explorer
        keyCode = e.keyCode; 
    }else if(e.which){ // firefox
        keyCode = e.which;
    }

    var IsValid = ((keyCode > 95 & keyCode < 106) || 
                    (keyCode == 188 | keyCode == 190) ||
                    (keyCode == 110 | keycode == 194) ||
                    (keyCode == 8 | keyCode == 46) ||
                    (keyCode > 47 & keyCode < 58) ||
                    (keyCode > 34 & keyCode < 40));
    
    IsValid = (IsValid == 0 ? false : (IsValid == 1 ? true : IsValid));
    if(window.event){
        e.returnValue = IsValid;
    }else{
        if(!IsValid)
            e.preventDefault();
    }
   
}

//Máscara para permitir somente números no input.
//Exemplo: onkeydown="javascript:Mask_Currency(this, event);"
function Mask_Numeric(sender, e){    
        
    var keyCode;
    if(window.event) { // Internet Explorer
        keyCode = e.keyCode; 
    }else if(e.which) { // firefox
        keyCode = e.which;
    }

    var IsValid = ((keyCode > 95 & keyCode < 106) || 
                    (keyCode == 8 | keyCode == 46) ||
                    (keyCode > 47 & keyCode < 58) ||
                    (keyCode > 34 & keyCode < 40));
           
    IsValid = (IsValid == 0 ? false : (IsValid == 1 ? true : IsValid));
    if(window.event){
        e.returnValue = IsValid;
    }else{
        if(!IsValid)
            e.preventDefault();
    }
                   
}

//Máscara para permitir somente 4 decimais no input.
//Exemplo: onkeypress="javascript:decimalMask(this, event, numeroDeDecimais);"
function decimalMask(sender, e, maxDecimais){
    var keyCode;
    if (window.event) { // Internet Explorer
        keyCode = e.keyCode;
    } else if (e.which) { // firefox
    	keyCode = e.which;
    }
    
    var commaIndex = sender.value.indexOf(',');
    
    if (commaIndex != -1) {
        var decimais = sender.value.split(',')[1];
        
        if (decimais.length >= maxDecimais) {
            if(keyCode >= 48 && keyCode <=57) {
			    if(window.event)
				    e.returnValue = false;
			    else
				    e.preventDefault();
			}
		}
    }
}

function PopupPage(url,nome,height,width){

	var attr = "scrollbars=yes,toolbar=no,status=no,menubar=no,resizable=yes";

	if(width != 0)
	 	attr += ",width=" + width;
	if(height != 0)
		attr += ",height=" + height;

  	return window.open(url,nome,attr);
}

//referência (inicio) - ajaxToolkit:ModalPopupExtender
            
function pageLoad() {
    var Obj = $get('ModalPopup_Button_Ok');
    if(Obj != null)
        $addHandler(Obj, 'click', hideModalPopupViaClient);        
}

function hideModalPopupViaClient(ev) {
    ev.preventDefault();        
    var modalPopupBehavior = $find('ModalPopupBehavior');
    if(modalPopupBehavior != null){
        modalPopupBehavior.hide();
    }
    var ThisForm = document.forms['aspnetForm'];
    if (ThisForm != null) {
        document.getElementById("notif").value = 'no';
        ThisForm = document.aspnetForm;
        ThisForm.submit();
    }
}

//referência (fim) - ajaxToolkit:ModalPopupExtender