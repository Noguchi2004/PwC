using System;
class Program{

    public static void Main(string[] args)
    {
     
        if (args.Length == 0)
        {
            Console.WriteLine("Informe um endereço!");
            return;
        }
        var entrada = string.Join(" ", args);
        var endereco = new Endereco();
        var retorno = endereco.Converte(entrada);
        Console.WriteLine(retorno);
       
    }
}
