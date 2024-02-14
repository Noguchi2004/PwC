using System;
class Program{

    public static void Main(string[] args)
    {
        var entrada = string.Join(" ", args);
        entrada ="Rua dos milagres 12";
        //entrada ="13, Rua dos milagres";
        //entrada ="Rua dos milagres, 12";
        
        var endereco = new Endereco();
        var retorno = endereco.Converte(entrada);
        Console.WriteLine(retorno);

        Console.ReadLine();
    }
}