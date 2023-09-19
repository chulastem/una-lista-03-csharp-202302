namespace Atividades
{
    public class Program{
        public static void Main(string[] args){

        Console.WriteLine("Lista de Exercicios\nSelecione o exercicio de 1 a 6\n");
        var result = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Você selecionou {result}º Exercicio\n");

        switch(result){
            case 1 : Exercicio_1.Exercise();
                break;
            case 2 : Exercicio_2.Exercise();
                break;
            case 3 : Exercicio_3.Exercise();
                break;
            case 4 : Exercicio_4.Exercise();
                break;
            case 5 : Exercicio_5.Exercise();
                break;
            case 6 : Exercicio_6.Exercise();
                break;             
            default : Console.WriteLine("selecione apenas de 1 a 6: ");
                break;
            }
        }
    }
}
