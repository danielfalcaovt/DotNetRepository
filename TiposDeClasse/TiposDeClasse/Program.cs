namespace TiposDeClasse
{
    class Program
    {
        static void Andar()
        {
            Console.WriteLine("Andou para frente...");
        }
        static void Main(string[] args) 
        {
            using (var pagamento = new Pagamento()) 
            {
                Console.WriteLine("Processando o pagamento...");
            }

            var pessoa = new Pessoa.Andar(Andar);
            pessoa();
        }
    }

    public class Pagamento : IDisposable
    {
        public Pagamento()
        {
            Console.WriteLine("Inicializando pagamento.");
        }

        public void Dispose()
        {
            Console.WriteLine("Finalizando o Pagamento.");
        }
    }

    public class Person
    {
        public string Name { get; set; }
    }

    public class Personal 
    {
        public string CPF { get; set; }
    }

    public class Corporate
    {
        public string IE { get; set; }
    }
}
