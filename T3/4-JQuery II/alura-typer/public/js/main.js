var tempoInicial=$("#tempo_digitacao").text();
var campo = $(".campo_digitacao");

$(document).ready(function(){
   atualizaTamanhoFrase();
    inicializaContadores();
    inicializaCronometro();
    inicializaMarcadores();
    $("#botao_reiniciar").click(reiniciaJogo);
    atualizaPlacar();
    $("#usuarios").selectize({
        create: true,
        sortField: 'text'
    });
    
    $('.tooltip').tooltipster({
        trigger: "custom"
    });
    
});

function atualizaTempoInicial(tempo){
    tempoInicial = tempo;
    $("#tempo_digitacao").text(tempo);
    
}

function atualizaTamanhoFrase(){
    var frase = $(".frase").text();
    var numPalavra = frase.split(" ").length;
    var tamanhoFrase = $(".tamanhofrase").text(numPalavra);
}



function inicializaContadores(){
    campo.on("input",function(){
        var conteudo = campo.val();
        var qtdPalavras = conteudo.split(/\s+/).length-1;
        $("#contador_palavras").text(qtdPalavras);


        var qtdCaracteres = conteudo.length;
        $("#contador_caracteres").text(qtdCaracteres);
    });
}

function inicializaCronometro(){
    
    campo.one("focus",function(){
        var temporestante = $("#tempo_digitacao").text();
        $("#botao_reiniciar").attr("disabled",true);
        var cronometroId = setInterval(function(){
            temporestante--;
            $("#tempo_digitacao").text(temporestante);
            if (temporestante<1){
                clearInterval(cronometroId);
                finalizaJogo();
            }
        },1000);

    })
}

function finalizaJogo(){
    $("#botao_reiniciar").attr("disabled", false);
    campo.attr("disabled",true);
    campo.toggleClass("campo_desativado");
    inserePlacar();
}

function inicializaMarcadores(){
   
    campo.on("input",function(){
        var frase = $(".frase").text();
        var digitado = campo.val();
        var comparavel = frase.substr(0,digitado.length);
        
        if(digitado==comparavel){
            campo.addClass("campo_correto");
            campo.removeClass("campo_errado");
        }else{
            campo.addClass("campo_errado");
            campo.removeClass("campo_correto");
        }
        
    });
}


function reiniciaJogo(){
     campo.attr("disabled",false);
    campo.val("");
    $("#contador_palavras").text("0");
    $("#contador_caracteres").text("0");
    $("#tempo_digitacao").text(tempoInicial);
    inicializaCronometro();
    campo.toggleClass("campo_desativado");
    campo.removeClass("campo_errado");
    campo.removeClass("campo_correto");
}



