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
		try
		{
			String Numero = String.Empty;
			String Rua = String.Empty;
			int numTeste;

			List<String> stringDividida = endereco.Replace(",", "").Split(" ", StringSplitOptions.None).ToList();


			//se o numero estiver no inicio
			if (int.TryParse(stringDividida[0], out numTeste))
			{
				Numero = stringDividida[0];
				stringDividida.RemoveAt(0);
				Rua = String.Join(" ", stringDividida);


			}
			else if (stringDividida.Contains("No"))
			{
				var n = -1;
				for (int i = 0; i < stringDividida.Count; i++)
				{
					if (stringDividida[i] == "No")
					{
						n = i;
					}
				}

				for (int i = 0; i < n; i++)
				{
					Rua += stringDividida[i];
					if (i + 1 < n)
					{
						Rua += " ";
					}
				}


				for (int i = n; i < stringDividida.Count; i++)
				{
					Numero += stringDividida[i] + " ";
				}

				Numero = Numero.TrimEnd();

			}
			//se estiver no final
			else if (Regex.IsMatch(stringDividida[stringDividida.Count - 1], @"\d$"))
			{
				Numero = stringDividida[stringDividida.Count - 1];
				stringDividida.RemoveAt(stringDividida.Count - 1);
				Rua = string.Join(" ", stringDividida);
			}
			else
			{
				var n = -1;
				for (int i = 0; i < stringDividida.Count; i++)
				{
					if (Regex.IsMatch(stringDividida[i], "^\\d"))
					{
						n = i;
					}
				}

				for (int i = 0; i < n; i++)
				{
					Rua += stringDividida[i];
					if (i + 1 < n)
					{
						Rua += " ";
					}
				}


				for (int i = n; i < stringDividida.Count; i++)
				{
					Numero += stringDividida[i] + " ";
				}
				Numero = Numero.TrimEnd();

			}
			if (string.IsNullOrEmpty(Rua))
			{
                return "Informe a rua no endereço!";
            }


            return $"{{\"{Rua}\",\"{Numero}\"}}";
		}
		catch
		{
			return "Informe um endereço correto, contendo rua e número, em qualquer ordem!";
		}
	}
}