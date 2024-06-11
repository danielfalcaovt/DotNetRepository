namespace Interfaces {
    class Program {
        static void Main(string[] args) {
            var pessoa = new Pessoa();
            pessoa.name = "idk";
            Console.WriteLine(pessoa.name);
            pessoa = new PessoaFisica();
        }
    }
    
    public class Pessoa: IEquatable<Pessoa> {
        public string name;

        public bool Equals (Pessoa pessoa) {
            return name == pessoa.name;
        }
    }

    public class PessoaFisica: Pessoa {
        public string cpf;
    }

    public class PessoaJuridica: Pessoa {
        public string cnpj;
    }

    public class Pagamento: IPagamento {
        public DateTime Vencimento { get; set; }

        public void Pagar(double valor) {
            Console.WriteLine("Efetuando pagamento...");
        }
    }

    public interface IPagamento {
        DateTime Vencimento { get; set; }

        void Pagar(double valor);
    }
}