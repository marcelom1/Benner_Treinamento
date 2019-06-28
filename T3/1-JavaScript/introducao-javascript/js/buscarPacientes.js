var botaoAdicionar = document.querySelector("#Buscar-paciente");

botaoAdicionar.addEventListener("click",function(){
   console.log("Buscando Pacientes");
    
    var xhr = new XMLHttpRequest();
    xhr.open("GET","https://api-pacientes.herokuapp.com/pacientes");
    
    xhr.addEventListener("load",function(){
        
        var erroajax = document.querySelector("#erro-ajax");
        if(xhr.status==200){
        
            erroajax.classList.add("invisivel");
            var resposta = xhr.responseText;
            //console.log(resposta);
            //console.log(typeof resposta);
            var pacientes = JSON.parse(resposta);
            //console.log(pacientes);
            //console.log(typeof pacientes);

            pacientes.forEach(function(paciente){
                adicionaPacienteNaTabela(paciente)
            });
        }else{
            console.log(xhr.status);
            console.log(xhr.responseText);
            
            erroajax.classList.remove("invisivel");
        }
        
    })
    
    xhr.send();
    
});