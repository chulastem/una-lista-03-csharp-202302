using System;
					
public class Program
{
	public static void Main()
	{
		int n1, n2, n3, maior = 0, menor = 0;
		Console.WriteLine("Digite três núneros inteiros: ");
		n1 = Convert.ToInt32(Console.ReadLine());
		n2 = Convert.ToInt32(Console.ReadLine());
		n3 = Convert.ToInt32(Console.ReadLine());
		
		maior = n1;
		if(maior < n2) maior = n2;
		if(maior < n3) maior = n3;
		
		menor = n1;
		if(menor > n2) menor = n2;
		if(menor > n3) menor = n3;
			
		Console.WriteLine("O maoir número é "+ maior);
		Console.WriteLine("O menor número é "+ menor);
		Console.WriteLine("A media aritmetica dos numeros digitados é  "+ (n1+n2+n3)/3);

        Console.ReadLine();
	}
}