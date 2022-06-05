namespace atividade_02
{
    internal class Retangulo
    {
        public int altura;
        public int largura;

        public void Mostrar()
        {
            Console.WriteLine($"Altura: {altura}");
            Console.WriteLine($"Largura: {largura}");
        }

        public void LerDados()
        {
            Console.Write($"Digite a altura: ");
            int.TryParse(Console.ReadLine(), out altura);

            Console.Write($"Digite a largura: ");
            int.TryParse(Console.ReadLine(), out largura);
        }
    }
}