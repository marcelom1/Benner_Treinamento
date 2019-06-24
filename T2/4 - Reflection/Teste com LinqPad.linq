<Query Kind="Program" />

void Main()
{
    var controller = new CambioController();
	var nomeAction = "Calculo";
	var argumentos = new string[]{ "moedaDestino"};
	 	
    /*var methodInfo = controller.GetType().GetMethods(bindingFlags);
    methodInfo.Dump();*/
}
	public class CambioController { 
    public string Calculo(string moedaOrigem, string moedaDestino, decimal valor)
        => null;

    public string Calculo(string moedaDestino, decimal valor)
        =>Calculo("BRL", moedaDestino, valor);
	public string Calculo(string moedaDestino)
        =>Calculo("BRL", moedaDestino, 1);
}