using System;
using System.Security;
using System.Text.RegularExpressions;

public class Endereco
{
	public Endereco()
	{

	}

	//"     rua dos duendes, 8888
	public String Converte(String endereco)
	{
		String Numero = String.Empty;
		String Rua = String.Empty;
		int numTeste;

		List<String> stringDividida = endereco.Split(" ", StringSplitOptions.None).ToList();
		
		if (int.TryParse(stringDividida[0], out numTeste))
		{
			Numero = stringDividida[0];
			stringDividida.RemoveAt(0);
			Rua = String.Join(" ", stringDividida);


		}
		else if (Regex.IsMatch(stringDividida[stringDividida.Count - 1], @"\d$"))
		{R
            Numero = stringDividida[stringDividida.Count-1];
			stringDividida.RemoveAt(stringDividida.Count - 1);
			Rua = string.Join(" ", stringDividida);
        }
		else
		{
			Numero = "caso2";
			Rua = "caso2";

		}
		return $"{{\"{Rua}\"}},\"{{\"{Numero}\"}}";

	}

}
