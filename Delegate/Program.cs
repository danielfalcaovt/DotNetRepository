namespace Delegate {
    class Program {
        static void Main(string[] args) {
            Metodos metodos = new Metodos();
            var pagar = new Pagamento.Pagar(metodos.PagarViaCard);
            pagar("102391203912");
        }
    }

    public interface IMetodos {
        void PagarViaCard(string cdNum);
    }

    public interface IPagamento {
        void Pagar(string cdNum);
    }

    class Pagamento: IPagamento {
        public delegate void Pagar(string cdNum);
    }

    class Metodos: IMetodos {
        public void PagarViaCard(string cdNum) {
            Console.WriteLine($"Efetuando pagamento pelo cartão: {cdNum}");
        }
    }
}