using Figgle;

const int limiteContagem = 100;
int contador = 1;

Contador();
Console.Clear();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(FiggleFonts.Big.Render("Explosão monstra 2.0!"));
Console.ResetColor();

void Contador()
{
    #pragma warning disable CA1416 
    Thread.Sleep(101 - contador);
    Console.Write($"{contador} ");
    Console.Beep(5000, 101 - contador);
    contador++;
    #pragma warning restore CA1416
    if (contador <= limiteContagem)
    {
        Contador();
    }
}