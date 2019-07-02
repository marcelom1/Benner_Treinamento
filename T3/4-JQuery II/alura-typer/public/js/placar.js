$("#botao_placar").click(mostrarPlacar);
$("#botao_sync").click(sincronizaPlacar);

function removeLinha(){
    event.preventDefault();
    var linha = $(this).parent().parent();
    linha.fadeOut(1000);
    setTimeout(function(){
        linha.remove(); 
    },1000);
} 

function sincronizaPlacar(){
    var placar = [];
    var linhas =$("tbody> tr");
    linhas.each(function(){
        var usuario= $(this).find("td:nth-child(1)").text();
        var palavras= $(this).find("td:nth-child(2)").text();
        
        var score = {
            usuario: usuario,
            pontos: palavras
        };
        
        placar.push(score);
    });
    var dados ={
        placar: placar
    };
    $.post("http://localhost:3000/placar",dados)
}

function atualizaPlacar(){
    $.get("http://localhost:3000/placar",function(data){
        $(data).each(function(){
            var linha = novaLinha(this.usuario, this.pontos);
            linha.find(".botao_remover").click(removeLinha);
            $("tbody").append(linha)
        })
    })
}



function inserePlacar(){
    var corpoTabela = $(".placar").find("tbody");
    var usuario = "Marcelo";
    var numPalavra = $("#contador_palavras").text();
   
    var linha = novaLinha(usuario, numPalavra); 
    corpoTabela.prepend(linha);
    linha.find(".botao_remover").click(removeLinha);
    
    corpoTabela.prepend(linha);
    $(".placar").slideDown(500);
    scrollPlacar();
}

function scrollPlacar(){
    var posicaoPlacar = $(".placar").offset().top;
    $("body").animate({
       scrollTop: posicaoPlacar+"px"
    },1000);
}

function novaLinha(usuario, numPalavras){
    var linha = $("<tr>");
    var colunaUsuario = $("<td>").text(usuario)
    var colunaPalavras = $("<td>").text(numPalavras)
    var colunaRemove = $("<td>");
    
    var link = $("<a>").addClass("botao_remover").attr("href","#");
    var icone = $("<i>").addClass("small").addClass("material-icons").text("delete");
    
    
    link.append(icone);
    
    colunaRemove.append(link);
    
    linha.append(colunaUsuario);
    linha.append(colunaPalavras);
    linha.append(colunaRemove);


   return linha; 
    
    
}

function mostrarPlacar(){
    $(".placar").stop().slideToggle(600);
}
