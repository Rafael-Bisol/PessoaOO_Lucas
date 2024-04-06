using PessoaOO.Pessoas;

class Program
{
    static void Main(string[] args)
    {
        Pessoa pessoa1 = new Pessoa("Jão", 25, "Flamengo");
        pessoa1.ImprimirInfo();
    }
}