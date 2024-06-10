namespace CoolStudy {
    class Program {
        static void Main(string[] args) {
            Pagamento pagamento = new Pagamento();
            pagamento.SaldoBancario = 1000;
            Console.WriteLine(pagamento.SaldoBancario);
            pagamento.Pagar();
            PagamentoViaCartao novoPagamento = new PagamentoViaCartao();
            novoPagamento.SaldoBancario = 2000;
            novoPagamento.Pagar();
        }
    }

    class Pagamento {
        protected double saldoBancario;
        public double SaldoBancario {
            get {
                Console.WriteLine("Checando usuário...");
                return saldoBancario;
            }
            set {
                Console.WriteLine("Checando usuário...");
                saldoBancario = value;
            }
        }
        public virtual void Pagar() {
            Console.WriteLine($"Você efetuou o pagamento no valor de {this.saldoBancario - 500}");
        }
    }

    class PagamentoViaCartao: Pagamento {
        public override void Pagar() {
            Console.WriteLine($"Você pagou {this.saldoBancario - 200} R$.");
        }
    }
}