internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Entre com seu nome inteiro : ");
        string Nome = Console.ReadLine();
        Console.Write("Entre com sua idade : ");
        int Idade = int.Parse(Console.ReadLine());
        Console.Write("Entre com sua nota  : ");
        int Nota = int.Parse(Console.ReadLine());

        Console.WriteLine($"O aluno {Nome} tem {Idade} anos de idade e esta com uma nota de {Nota} pontos");
    }
}