namespace atividade_02;

public static class Program
{
    public static void Main(string[] args)
    {
        int opcao = 0;
        Console.Write("Escolha o Exercício: \n" +
            "(1) Retângulo\n" +
            "(2) Registro acadêmico\n" +
            "(3) Jogador de futebol\n" +
            "(4) Calculadora\n" +
            "Opção: ");
        int.TryParse(Console.ReadLine(), out opcao);
        Console.Clear();
        switch (opcao)
        {
            case 1:
                TestarRetangulo();
                break;
            case 2:
                TestarRegistroAcademico();
                break;
            case 3:
                TestarJogadorDeFutebol();
                break;
            case 4:
                TestarCalculadora();
                break;
        }
    }

    private static void TestarJogadorDeFutebol()
    {
        var jogadorDeFutebol = new JogadorDeFutebol();
        jogadorDeFutebol.LerDados();
        Console.WriteLine("----------------------------");
        jogadorDeFutebol.Imprimir();
    }

    private static void TestarRetangulo()
    {
        Retangulo[] retangulos = new Retangulo[10];
        for (int i = 0; i < 10; i++)
        {
            Console.Clear();
            retangulos[i] = new Retangulo();
            Console.WriteLine($"Retângulo {i + 1}");
            retangulos[i].LerDados();
            Console.WriteLine();
        }
        Console.Clear();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Retângulo {i + 1}");
            retangulos[i].Mostrar();
            Console.WriteLine();
        }
    }

    private static void TestarRegistroAcademico()
    {
        var registroAcademico = new RegistroAcademico();
        registroAcademico.LerDados();
        Console.WriteLine("----------------------------");
        registroAcademico.Imprimir();
    }

    private static void TestarCalculadora()
    {
        double x;
        double y;
        Calculadora calculadora = new Calculadora();
        Console.Write("Digite o valor de X: ");
        double.TryParse(Console.ReadLine(), out x);

        Console.Write("Digite o valor de Y: ");
        double.TryParse(Console.ReadLine(), out y);

        Console.WriteLine("-----------------");
        Console.WriteLine($"Soma: {calculadora.Somar(x, y)}");
        Console.WriteLine($"Multiplicação: {calculadora.Multiplicar(x, y)}");
        Console.WriteLine($"Subtração: {calculadora.Subtrair(x, y)}");
        if (y != 0)
        {
            Console.WriteLine($"Divisão: {calculadora.Dividir(x, y)}");

        }
        else
        {
            Console.WriteLine("Divisão inválida!");
        }
        Console.WriteLine($"Potência: {calculadora.Potencia(x, y)}");
    }
}