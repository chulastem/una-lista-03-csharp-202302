namespace Atividades;				
public class Exercicio_3
{
	public static void Exercise(){       
    
        Double a, b, c, raiz, delta;

        Console.WriteLine("Informe o coeficiente 'a': ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe o coeficiente 'b': ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe o coeficiente 'c': ");
        c = Convert.ToDouble(Console.ReadLine());

        delta = b * b - 4 * a * c;

        if (a == 0 && b == 0 && c != 0){
            Console.WriteLine("Coeficientes informados incorretamente.");
        }
        else if (a == 0 && b != 0){
            Console.WriteLine("Essa é uma equação de primeiro grau.");
            raiz = -c / b;
            Console.WriteLine("Raiz da equação: " + raiz.ToString("F2"));
        }
        else{
            
            if (delta < 0){
                Console.WriteLine("Esta equação não possui raízes reais.");
            }
            else if (delta == 0){
                Console.WriteLine("Esta equação possui duas raízes reais iguais.");
                raiz = -b / (2 * a);
                Console.WriteLine("Raiz da equação: " + raiz.ToString("F2"));
            }
            else{
                Console.WriteLine("Esta equação possui duas raízes reais diferentes.");
                double raiz1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double raiz2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Raiz 1: " + raiz1.ToString("F2"));
                Console.WriteLine("Raiz 2: " + raiz2.ToString("F2"));
            }
        }
        Console.ReadLine();		
	}
}