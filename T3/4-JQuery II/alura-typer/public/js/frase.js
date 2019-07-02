$("#botao_frase").click(fraseAleatoria);
$("#botao_frase_id").click(buscaFrase);

function buscaFrase(){
    $("#spinner").toggle();
    var fraseID = $("#frase_id").val();
    console.log(fraseID);
    var dados= {id: fraseID};
    
    $.get("http://localhost:3000/frases",dados,trocaFrase)
    .fail(function(){
        $("#erro").toggle();
        setTimeout(function(){
            $("#erro").toggle();
        },2500);
    })
    .always(function(){
        $("#spinner").toggle();
    });
}

function trocaFrase(data){
    var frase = $(".frase");
    frase.text(data.texto);
    atualizaTamanhoFrase();
    atualizaTempoInicial(data.tempo);
}

function fraseAleatoria(){
    $("#spinner").show();
    $.get("http://localhost:3000/frases",trocaFraseAleatoria)
        .fail(function(){
        $("#erro").show();
        setTimeout(function(){
            $("#erro").toggle();
        },2500);
    })
    .always(function(){
        $("#spinner").toggle();
    });
}

function trocaFraseAleatoria(data){
    var frase = $(".frase");
    var numeroAleatorio = Math.floor(Math.random()* data.length);    
    frase.text(data[numeroAleatorio].texto);
    atualizaTamanhoFrase();
    atualizaTempoInicial(data[numeroAleatorio].tempo);
}