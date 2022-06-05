namespace atividade_02
{
    internal class RegistroAcademico
    {
        const float baseMensalidade = 650f;
        public string? nomeAluno;
        public int numeroMatricula;
        public string? dataNascimento;
        public bool bolsista;
        public int anoMatricula;
        private float mensalidade;

        private void CalculaMensalidade()
        {
            if (bolsista)
            {
                mensalidade = baseMensalidade * 0.5f;
            }
            else
            {
                mensalidade = baseMensalidade;
            }
        }
        public void Imprimir()
        {
            CalculaMensalidade();
            Console.WriteLine($"Nome do aluno: {nomeAluno}");
            Console.WriteLine($"Número da matrícula: {numeroMatricula}");
            Console.WriteLine($"Data de nascimento: {dataNascimento}");
            Console.WriteLine($"Bolsista: {(bolsista ? "S" : "N")}");
            Console.WriteLine($"Ano da matrícula: {anoMatricula}");
            Console.WriteLine($"Valor da mensalidade: {Math.Round(mensalidade, 2)}");
        }

        public void LerDados()
        {
            Console.Write($"Nome do aluno: ");
            nomeAluno = Console.ReadLine();

            Console.Write($"Número da matrícula: ");
            int.TryParse(Console.ReadLine(), out numeroMatricula);

            Console.Write($"Data de nascimento: ");
            dataNascimento = Console.ReadLine();

            Console.Write($"Bolsista (S/N): ");
            bolsista = Console.ReadLine().ToUpper().Trim() == "S";

            Console.Write($"Ano da matrícula: ");
            int.TryParse(Console.ReadLine(), out anoMatricula);

        }
    }
}
