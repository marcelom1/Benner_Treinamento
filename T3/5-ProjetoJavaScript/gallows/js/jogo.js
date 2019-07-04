var criaJogo = function(sprite){
    
    var palavraSecreta = '';
    var lacunas = [];
    var etapa = 1
    
    var ganhou = function () {
         return lacunas.length 
            ? !lacunas.some(function(lacuna) {
                return lacuna == '';
            })
            : false;
    };

    var perdeu = function () {
        return sprite.isFinished();
    };

    var ganhouOuPerdeu = function () {
        return ganhou() || perdeu();
    };

    var reinicia = function () {
        etapa = 1;
        lacunas=[];
        palavraSecreta="";
        sprite.reset();
    };
    
    var proccessaChute = function(chute){
        if (!chute.trim()) throw Erro('Chute inválida!');
        var exp = new RegExp(chute,'gi'),resultado, acertou=false;
        while(resultado=exp.exec(palavraSecreta)){
            lacunas[resultado.index]=chute;
            acertou=true;
        }
        if (!acertou){
            sprite.nextFrame();
        }
        
    };
    var criarLacunas = function(){
        for(var i=0; i<palavraSecreta.length;i++){
            lacunas.push("");
        }
    }
    
    var proximaEtapa = function(){
      etapa = 2;  
    };
    
    var setPalavraSecreta = function (palavra){
        if (!palavra.trim()) throw Erro('palavra Secreta inválida!');
        palavraSecreta = palavra;
        criarLacunas();
        proximaEtapa();
        
    };
    
    var getLacunas = function(){
        return lacunas;
    };
    
    var getEtapa = function(){
        return etapa;
    };
    
    return{ 
        setPalavraSecreta: setPalavraSecreta,
        getLacunas: getLacunas,
        getEtapa: getEtapa,
        proccessaChute: proccessaChute,
        ganhou: ganhou,
        perdeu: perdeu,
        ganhouOuPerdeu: ganhouOuPerdeu,
        reinicia: reinicia
        
    };
    
};