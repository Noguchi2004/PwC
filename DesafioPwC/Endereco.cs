using System;
using System.Security;
using System.Text.RegularExpressions;

public class Endereco
{
	public Endereco()
	{

	}

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
		{
			Numero = stringDividida[stringDividida.Count - 1];
			stringDividida.RemoveAt(stringDividida.Count - 1);
			Rua = string.Join(" ", stringDividida);
		}
		else {
			for (int i = stringDividida.Count - 1; i >= 0; i--)
			{
				Numero = stringDividida[];
				stringDividida.RemoveAt(stringDividida - i--);
				Rua = string.Join(" ", stringDividida);
	
			}
		}
		return $"{{\"{Rua}\"}},\"{{\"{Numero}\"}}";

	}

}
