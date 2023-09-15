namespace Atividades;				
public class Exercicio_6
{
	public static void Exercise(){ 
        int n1,n2;
		
		Console.WriteLine("Digite o primeiro número inteiro: ");
        n1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo número inteiro: ");
        n2 = Convert.ToInt32(Console.ReadLine());

        int menor = Math.Min(n1, n2);
        int maior = Math.Max(n1, n2);

        Random random = new Random();
        int numeroSorteado = random.Next(menor, maior + 1);

        string parOuImpar = (numeroSorteado % 2 == 0) ? "par" : "ímpar";

        Console.WriteLine("Número sorteado: " + numeroSorteado);
        Console.WriteLine("É um número " + parOuImpar + ".");

        Console.ReadLine();
	}
}