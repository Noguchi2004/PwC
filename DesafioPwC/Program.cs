using System;
class Program{

    public static void Main(string[] args)
    {
     
        if (args.Length != 0)
        { 
            var entrada = string.Join(" ", args);
            var endereco = new Endereco();
            var retorno = endereco.Converte(entrada);
            Console.WriteLine(retorno);
        }

        Converte("Miritiba 339");
        Converte("Babaçu 500");
        Converte("Cambuí 804B");
        Converte("Rio Branco 23");
        Converte("Quirino dos Santos 23 b");
        Converte("4, Rue de la Republique");
        Converte("100 Broadway Av");
        Converte("Calle Sagasta, 26");
        Converte("Calle 44 No 1991");

    }



    private static void Converte(string texto)
    {
        var endereco = new Endereco();
        var retorno = endereco.Converte(texto);
        Console.WriteLine(texto +" > "+ retorno);
       
    }
}
