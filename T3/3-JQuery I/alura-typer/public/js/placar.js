
function removeLinha(){
        event.preventDefault();
        $(this).parent().parent().remove();
} 

function inserePlacar(){
    var corpoTabela = $(".placar").find("tbody");
    var usuario = "Marcelo";
    var numPalavra = $("#contador_palavras").text();
   
    var linha = novaLinha(usuario, numPalavra); 
    corpoTabela.prepend(linha);
    linha.find(".botao_remover").click(removeLinha);    
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
