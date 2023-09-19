namespace Atividades;
public class Exercicio_5
{
	public static void Exercise()
	{
	double n1, n2, result;
	string simb = null;
	Console.WriteLine("Digite o primeiro número: ");
	n1 = Convert.ToDouble(Console.ReadLine());
	Console.WriteLine("Digite o segundo número: ");
	n2 = Convert.ToDouble(Console.ReadLine());

	Console.WriteLine("Escolha que operção você deseja realizar:(digite o simbolo da operação)");
	Console.WriteLine("(+)Soma");
	Console.WriteLine("(-)Subtração");
	Console.WriteLine("(*)Multiplicação");
        Console.WriteLine("(/)Divisão");

    	simb = Convert.ToString(Console.ReadLine());

	if (simb == "+")
	{
		result = n1 + n2;
		Console.WriteLine(n1 + " + " + n2 + " = " + result);
	}
	else if (simb == "-")
	{
		result = n1 - n2;
		Console.WriteLine(n1 + " - " + n2 + " = " + result);
	}
	else if (simb == "*")
	{
		result = n1 * n2;
		Console.WriteLine(n1 + " x " + n2 + " = " + result);
	}
	else if (simb == "/")
	{
		result = n1 / n2;
		Console.WriteLine(n1 + " / " + n2 + " = " + result);
	}	
	Console.ReadLine();
	}
}
