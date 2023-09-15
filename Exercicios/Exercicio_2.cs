namespace Atividades;				
public class Exercicio_2
{
	public static void Exercise()
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
        Console.ReadLine();	
	}
}