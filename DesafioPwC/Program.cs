using System;
class Program{

    public static void Main(string[] args)
    {
        var entrada = string.Join(" ", args);

        var endereco = new Endereco();
        var retorno = endereco.Converte(entrada);
        Console.WriteLine(retorno);

        Console.ReadLine();
    }
}