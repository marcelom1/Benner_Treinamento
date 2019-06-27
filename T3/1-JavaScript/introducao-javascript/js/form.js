
var botaoAdicionar = document.querySelector("#adicionar-paciente");
botaoAdicionar.addEventListener("click",function(event){
    event.preventDefault();
    var form = document.querySelector("#form-adiciona");
    //Extrair informações do formulário
    var paciente = obtemPacienteDoFormulario(form);
    
    //criar a tr e td do paciente
    var pacienteTR = montarTr(paciente);
    
    var erros = validaPaciente(paciente);
    
    if(erros.length>0){
        exibeMensagensDeErro(erros);
        return;
    }
    
    
    //Adicionando o Paciente na tabela
    var tabela = document.querySelector("#tabela-pacientes");
    
    tabela.appendChild(pacienteTR);
    form.reset();
    var mensagens_erro=document.querySelector("#mensagem-erro");
    mensagens_erro.innerHTML = "";
    
})

function exibeMensagensDeErro(erros){
    var ul = document.querySelector("#mensagem-erro");
    ul.innerHTML = "";
    
    erros.forEach(function(erro){
       var li=document.createElement("li");
        li.textContent=erro;
        ul.appendChild(li);
    });
                  
                  
}



function obtemPacienteDoFormulario(form){
    var paciente ={
        nome: form.nome.value,
        peso: form.peso.value,
        altura: form.altura.value,
        gordura: form.gordura.value,
        imc: calculaImc(form.peso.value, form.altura.value)
        
    }
    return paciente;
  
}

function montarTr(paciente){
    
    var pacienteTR = document.createElement("tr");
    pacienteTR.classList.add("paciente");
     
    pacienteTR.appendChild(montaTd(paciente.nome,"info-nome"));
    pacienteTR.appendChild(montaTd(paciente.peso,"info-peso"));
    pacienteTR.appendChild(montaTd(paciente.altura,"info-altura"));
    pacienteTR.appendChild(montaTd(paciente.gordura,"info-gordura"));
    pacienteTR.appendChild(montaTd(paciente.imc,"info-imc"));
    
    return pacienteTR;
}

function montaTd(dado,classe){
    var td = document.createElement("td");
    td.textContent = dado;
    td.classList.add(classe);
    
    return td;
}


function validaPaciente(paciente){
    
    var erros =[];
    
    if (paciente.nome.length==0){
        erros.push("O nome não pode ser em branco");
    }
    
    if(!validaPeso(paciente.peso)){
        erros.push("Peso é Inválido");
    }
    
    if(!validaAlura(paciente.altura)){
        erros.push("Altura é Inválida");
    }
    
    if (paciente.gordura.length==0){
        erros.push("Gordura não pode ser em branco");
    }
    
    if (paciente.peso.length==0){
        erros.push("O Peso não pode ficar em branco");
    }
    
    if (paciente.altura.length==0){
        erros.push("A altura não pode ficar em branco");
    }
    return erros;
}