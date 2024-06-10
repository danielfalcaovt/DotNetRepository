namespace CoolStudy {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("[1] DEPOSITAR / [2] PAGAR");
            char userChoice = Convert.ToChar(Console.ReadLine());
            double valorDepositado;
            double valorPagar;
            while (true) {
                Console.WriteLine("Again");
                using (Pagamento pagamento = new Pagamento()) {
                    if (userChoice == '1' || userChoice == '2') {
                        if (userChoice == '1') {
                            Console.WriteLine("Quanto você deseja depositar?");
                            valorDepositado = Convert.ToDouble(Console.ReadLine());
                            pagamento.SaldoBancario = valorDepositado;
                            Console.WriteLine("[1] DEPOSITAR / [2] PAGAR");
                            userChoice = Convert.ToChar(Console.ReadLine());
                        }
                        else 
                        {
                            Console.WriteLine("Quanto você deseja pagar?");
                            valorPagar = Convert.ToDouble(Console.ReadLine());
                            pagamento.valorGasto = valorPagar;
                            pagamento.Pagar();
                            Console.WriteLine("[1] DEPOSITAR / [2] PAGAR");
                            userChoice = Convert.ToChar(Console.ReadLine());
                        }
                    } else {
                        Console.WriteLine("Por favor, escolha uma opção VÁLIDA.");
                    }
                }
            }
        }

    }
    class Pagamento: IDisposable {
        protected double saldoBancario;
        public double valorGasto;
        public double SaldoBancario {
            get {
                Console.WriteLine("Consultando saldo bancário.");
                return saldoBancario;
            }
            set {
                Console.WriteLine("Depositando em saldo bancário.");
                saldoBancario = value;
            }
        }
        public virtual void Pagar() {
            Console.WriteLine(this.saldoBancario);
            Console.WriteLine(this.valorGasto);
            if (this.saldoBancario > this.valorGasto) {
                Console.WriteLine($"Você efetuou o pagamento no valor de {this.saldoBancario - this.valorGasto}");
            }
            else 
            {
                Console.WriteLine("Você não possui saldo o suficiente.");
            }
        }

        public void Dispose() {
            Console.WriteLine("Finalizando o banco de dados.");
        }
    }



    class PagamentoViaCartao: Pagamento {
        public override void Pagar() {
            Console.WriteLine($"Você pagou {this.saldoBancario - this.valorGasto} R$.");
        }
    }
}