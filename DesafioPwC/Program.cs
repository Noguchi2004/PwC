using System;
class Program{

    public static void Main(string[] args)
    {
        var entrada = string.Join(" ", args);
        //entrada ="Miritiba 339";
        //entrada ="Babaçu 500";
        //entrada ="Cambuí 804B";
        //entrada = "Rio Branco 23";
        //entrada = "Quirino dos Santos 23 b";
        //entrada = "4, Rue de la Republique";
        //entrada = "100 Broadway Av";
        //entrada = "Calle Sagasta, 26";
        entrada = "Calle 44 No 1991";
        
        var endereco = new Endereco();
        var retorno = endereco.Converte(entrada);
        Console.WriteLine(retorno);

        Console.ReadLine();
    }
}