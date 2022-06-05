namespace atividade_02
{
    internal class JogadorDeFutebol
    {
        public string? nome;
        public string? posicao;
        public DateTime dataNascimento;
        public string? nacionalidade;
        public decimal altura;
        public decimal peso;
        private int idade;

        public void Imprimir()
        {
            CalcularIdade();
            Console.WriteLine($"Nome do jogador: {nome}");
            Console.WriteLine($"Posição: {posicao}");
            Console.WriteLine($"Data de nascimento: {dataNascimento:dd/MM/yyyy}");
            Console.WriteLine($"Nascionalidade: {nacionalidade}");
            Console.WriteLine($"Altura: {Math.Round(altura, 2)}");
            Console.WriteLine($"Peso: {Math.Round(peso, 2)}");
            Console.WriteLine($"Idade: {idade}");
            ImprimirAposentadoria();

        }
        private void CalcularIdade()
        {
            idade = DateTime.Now.Year - dataNascimento.Year;
            if (DateTime.Now.DayOfYear < dataNascimento.DayOfYear)
            {
                idade--;
            }
        }

        private void ImprimirAposentadoria()
        {
            switch (posicao)
            {
                case "DEFESA":
                    if (idade < 40)
                    {
                        Console.WriteLine($"Falta(m) {40 - idade} ano(s) para aposentadoria.");
                        break;
                    }
                    Console.WriteLine("Jogador aposentado");
                    break;
                case "ATACANTE":
                    if (idade < 35)
                    {
                        Console.WriteLine($"Falta(m) {35 - idade} ano(s) para aposentadoria.");
                        break;
                    }
                    Console.WriteLine("Jogador aposentado");
                    break;
                case "MEIO-CAMPO":
                    if (idade < 38)
                    {
                        Console.WriteLine($"Falta(m) {38 - idade} ano(s) para aposentadoria.");
                        break;
                    }
                    Console.WriteLine("Jogador aposentado");
                    break;
            }
        }
        public void LerDados()
        {
            Console.Write($"Nome do jogador: ");
            nome = Console.ReadLine();

            Console.Write($"Posição (Defesa/Atacante/Meio-Campo): ");
            posicao = Console.ReadLine().ToUpper().Trim();

            Console.Write($"Data de nascimento (dd/mm/aaaa): ");
            DateTime.TryParse(Console.ReadLine(), out dataNascimento);

            Console.Write($"Nacionalidade: ");
            nacionalidade = Console.ReadLine().ToUpper().Trim();

            Console.Write($"Altura: ");
            decimal.TryParse(Console.ReadLine(), out altura);

            Console.Write($"Peso: ");
            decimal.TryParse(Console.ReadLine(), out peso);
        }
    }
}
