namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Reserva(Suite suite)
        {
            this.Suite = suite;

        }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido

            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                throw new ArgumentException("O número de hóspedes excede a capacidade da suíte.");

            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Retorna a quantidade de hóspedes (propriedade Hospedes)

            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // Cálculo: DiasReservados X Suite.ValorDiaria

            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                // Calcula o desconto de 10%
                decimal desconto = valor * 0.1m;

                // Aplica o desconto
                valor -= desconto;
            }

            return valor;

        }
        class Excecao : Exception
        {
            // Defini uma mensagem personalizada para a exceção
            public Excecao(string mensagem) : base(mensagem)
            {
            }
        }

    }
}