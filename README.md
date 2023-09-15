# Lista de Exercícios III: Estrutura Condicional

## UC - Estrutura de dados e análise de algoritmos -Pratica

**Pedro Antonio Esteves Silva - RA: 622122907**

Considerações Iniciais:
Esta lista de exercício deve:

- Ser realizada em equipes de até 06 alunos.
- Ser entregue no prazo proposto.
- Ter os algoritmos pedidos escritos em linguagem C# (csharp) OU Java.
- Ter todos os algoritmos devidamente identados.
- Identifique a entrega da lista com seu nome e RA

1- Escreva um algoritmo que leia 3 números a partir do teclado. O algoritmo deve
apresentar:

a. O maior número.

b. O menor número.

c. A média aritmética dos três números.

```csharp
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
	}
}
```

Utilizando o IF TERNARIO 

```csharp
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
	
		maior = (n1 > n2) ? ((n1 > n3) ? n1 : n3) : ((n2 > n3) ? n2 : n3);
		menor = (n1 < n2) ? ((n1 < n3) ? n1 : n3) : ((n2 < n3) ? n2 : n3);
		
		Console.WriteLine("O maoir número é "+ maior);
		Console.WriteLine("O menor número é "+ menor);
		Console.WriteLine("A media aritmetica dos numeros digitados é  "+ (n1+n2+n3)/3);
	}
}
```

2- Escreva o algoritmo de uma máquina de venda automática de salgadinhos, doces,
sucos e refrigerantes. O algoritmo deve calcular o menor número de notas que deve
ser dado de troco para um pagamento efetuado.

O algoritmo deve ler o valor da compra e o valor pago.

Se o valor pago for menor que o valor da compra, a máquina deve apresentar uma
mensagem, informando que a quantia paga é insuficiente para realizar a compra.
A máquina aceita apenas notas de R$ 50,00, R$ 20,00, R$ 10,00, R$ 5,00, R$ 2,00 e R$
1,00.

Exemplo:

- Valor pago: R$ 100,00
- Valor da compra: R$ 23,00
- Troco: R$ 77,00
- Notas de R$ 50,00: 1
- Notas de R$ 20,00: 1
- Notas de R$ 10,00: 0
- Notas de R$ 5,00: 1
- Notas de R$ 2,00: 1
- Notas de R$ 1,00: 0

```csharp
using System;
					
public class Program
{
	public static void Main()
	{
		Double valorCompra, valorPago, troco = 0;
		Console.WriteLine("Digite o valor da compra: ");
		valorCompra = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Digite o valor pago: ");
		valorPago = Convert.ToDouble(Console.ReadLine());
		troco = valorPago-valorCompra;
		
		if(troco<0){
			Console.WriteLine("quantia paga é insuficiente para realizar a compra.");
		}
		else{
			
			int nota1 = 0, nota2 = 0, nota5 = 0, nota10 = 0, nota20 = 0, nota50 = 0;
			
			Console.WriteLine("Valor do troco R$ "+ troco);
			
			nota50 = (int)(troco / 50);
            troco -= nota50 * 50;
            if (nota50 > 0){
                Console.WriteLine("Notas de R$ 50,00: "+ nota50);
            }
			
			nota20 = (int)(troco / 20);
            troco -= nota20 * 20;
            if (nota20 > 0){
                Console.WriteLine("Notas de R$ 20,00: "+ nota20);
            }
			
			nota10 = (int)(troco / 10);
            troco -= nota10 * 10;
            if (nota10 > 0){
                Console.WriteLine("Notas de R$ 10,00: "+ nota10);
            }
			
			nota5 = (int)(troco / 5);
            troco -= nota5 * 5;
            if (nota5 > 0){
                Console.WriteLine("Notas de R$ 05,00: "+ nota5);
            }
			nota2 = (int)(troco / 2);
            troco -= nota2 * 2;
            if (nota2 > 0){
                Console.WriteLine("Notas de R$ 02,00: "+ nota2);
            }
			
			nota1 = (int)(troco / 1);
            troco -= nota1 * 1;
            if (nota1 > 0){
                Console.WriteLine("Notas de R$ 1,00: "+ nota1);
            }	
				}		
		}
}
```

3- Escreva um algoritmo que resolva uma equação de segundo grau, realizando a
verificação de consistência dos valores dos coeficientes ("a", "b" e "c") e do
discriminante (delta).

a. Se os coeficientes "a" e "b" forem iguais a zero e o coeficiente "c" for diferente de
zero, apresentar a mensagem "Coeficientes informados incorretamente.".

b. Caso o coeficiente "a" seja igual a zero e o coeficiente "b" for diferente de zero,
deverá ser impressa a mensagem: "Essa é uma equação de primeiro grau" e deverá
ser informado o valor da raiz real da equação.

c. Caso o discriminante seja negativo, deverá ser impressa a mensagem: "Esta
equação não possui raízes reais".

d. Caso o discriminante seja zero, apresentar a mensagem "Esta equação possui duas
raízes reais iguais. " e informar o valor das raízes da equação.

e. Caso o discriminante seja maior que zero, apresentar a mensagem "Esta equação
possui duas raízes reais diferentes. " e informar o valor das raízes da equação.

*Equação do segundo grau: ax² + bx + c = 0
Discriminante: delta = b² – 4ac*

```csharp
using System;
					
public class Program
{
	public static void Main()
	{	
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
		}
}
```

4- Escreva um algoritmo que leia dois valores: o primeiro servindo de indicador de
operação e o segundo correspondendo ao raio de um círculo ou esfera. Caso o
primeiro valor lido seja:

a. 1: calcular e imprimir o perímetro do círculo.

b. 2: calcular e imprimir a área do círculo.

c. 3: calcular e imprimir o volume da esfera.

Se o primeiro valor lido for diferente desses três valores possíveis, imprimir uma
mensagem de erro, informando que o código da operação é inválido.

*OBS:
Perímetro de um círculo: 2 π r
Área de um círculo: π r²
Volume de uma esfera: 4/3 π r³
em que π = 3,141592 e r é o raio da circunferência.*

```csharp
using System;
					
public class Program
{
	public static void Main()
	{
        Console.WriteLine("Digite o código da operação:");
        Console.WriteLine("1 - Calcular o perímetro do círculo");
        Console.WriteLine("2 - Calcular a área do círculo");
        Console.WriteLine("3 - Calcular o volume da esfera");
        int codigoOperacao = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o valor do raio: ");
        double raio = Convert.ToDouble(Console.ReadLine());

        double resultado = 0;

        if (codigoOperacao == 1){
            resultado = 2 * Math.PI * raio;
            Console.WriteLine("Perímetro do círculo: " + resultado.ToString("F2"));
        }
        else if (codigoOperacao == 2){
            resultado = Math.PI * Math.Pow(raio, 2);
            Console.WriteLine("Área do círculo: " + resultado.ToString("F2"));
        }
        else if (codigoOperacao == 3){
            resultado = (4.0 / 3.0) * Math.PI * Math.Pow(raio, 3);
            Console.WriteLine("Volume da esfera: " + resultado.ToString("F2"));
        }
        else {
            Console.WriteLine("Código de operação inválido.");
        }
	}
}
```

5- Escrever um algoritmo que leia a partir do teclado dois números reais e um dos
símbolos de operação: + , - , * , / ou ^ .

O algoritmo deve retornar o resultado da operação.
Caso o símbolo informado seja diferente dos símbolos preestabelecidos, o algoritmo
deve apresentar uma mensagem de erro, informando que o símbolo da operação é
inválido.

```csharp
using System;
					
public class Program
{
	public static void Main()
	{
		double n1, n2, result;
		String simb;
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
		
		if(simb == "+"){
			result = n1+n2;
			Console.WriteLine(n1 +" + "+ n2 +" = "+ result);
		}
		else if(simb == "-"){
			result = n1-n2;
			Console.WriteLine(n1 +" - "+ n2 +" = "+ result);
		}
		else if(simb == "*"){
			result = n1*n2;
			Console.WriteLine(n1 +" x "+ n2 +" = "+ result);
		}
		else if(simb == "/"){
			result = n1/n2;
			Console.WriteLine(n1 +" / "+ n2 +" = "+ result);
		}
	}
}
```

6- Crie um algoritmo que leia dois números inteiros e realize o sorteio de um número
aleatório. O algoritmo deve validar qual é o menor e o maior número informado pelo
teclado, para que independente da ordem que o usuário digite os números, consiga
realizar o sorteio.

Se o algoritmo gerar um número par, escreva na tela o número gerado e informe que
ele é par. Se o algoritmo gerar um número ímpar, escreva na tela o número gerado e
que ele é um número ímpar.

```csharp
using System;
					
public class Program
{
	public static void Main()
	{
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
	}
}
```
