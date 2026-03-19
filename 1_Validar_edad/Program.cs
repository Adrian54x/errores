// See https://aka.ms/new-console-template for more information
int edad;
bool valido;
do
{
    Console.Clear();
    Console.Write("Ingrese su edad:");
    valido = int.TryParse(Console.ReadLine(), out edad);
    if (!valido || edad < 0 || edad > 120)
    {
        valido = false;
        Console.WriteLine("Edad No valida!");
        Thread.Sleep(500);
    }

} while (!valido);
Console.WriteLine("Edad valida");
Console.ReadKey();