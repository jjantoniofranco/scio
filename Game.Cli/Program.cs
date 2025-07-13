using GameEngine.Abstractions;
using GameEngine.Characters;
using GameEngine.Items;

Console.WriteLine("=== MOTOR DE JUEGO - DEMOSTRACIÓN ===\n");

Console.WriteLine("1. DEMOSTRACIÓN CON PERSONAJE FIJO:");
Console.WriteLine("-----------------------------------");

var paladinFijo = new Paladin(new Espada());
Console.WriteLine($"Personaje: {paladinFijo.Name}");
Console.WriteLine($"Arma: Espada");
Console.WriteLine($"Resultado del ataque: {paladinFijo.Attack()}\n");



Console.WriteLine("2. SELECCIÓN PERSONALIZADA:");
Console.WriteLine("----------------------------");

var personajeSeleccionado = SeleccionarPersonaje();
var armaSeleccionada = SeleccionarArma();

var personajePersonalizado = CrearPersonaje(personajeSeleccionado, armaSeleccionada);

Console.WriteLine($"\nPersonaje seleccionado: {personajePersonalizado.Name}");
Console.WriteLine($"Arma seleccionada: {ObtenerNombreArma(armaSeleccionada)}");
Console.WriteLine($"Resultado del ataque: {personajePersonalizado.Attack()}\n");

Console.WriteLine("=== FIN DE LA DEMOSTRACIÓN ===");
Console.WriteLine("\nPresiona cualquier tecla para salir...");
Console.ReadKey();

string SeleccionarPersonaje()
{
    Console.WriteLine("Selecciona un personaje:");
    Console.WriteLine("1. Paladín (Conan)");
    Console.WriteLine("2. Elfo (Legolas)");
    Console.WriteLine("3. Mago (Merlin)");

    while (true)
    {
        Console.Write("Ingresa tu elección (1-3): ");
        var opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1": return "Paladin";
            case "2": return "Elfo";
            case "3": return "Mago";
            default:
                Console.WriteLine("Opción inválida. Por favor selecciona 1, 2 o 3.");
                break;
        }
    }
}

string SeleccionarArma()
{
    Console.WriteLine("\nSelecciona un arma:");
    Console.WriteLine("1. Espada");
    Console.WriteLine("2. Arco");
    Console.WriteLine("3. Hechizo");

    while (true)
    {
        Console.Write("Ingresa tu elección (1-3): ");
        var opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1": return "Espada";
            case "2": return "Arco";
            case "3": return "Hechizo";
            default:
                Console.WriteLine("Opción inválida. Por favor selecciona 1, 2 o 3.");
                break;
        }
    }
}

IGameAvatar CrearPersonaje(string tipoPersonaje, string tipoArma)
{
    var arma = CrearArma(tipoArma);

    return tipoPersonaje switch
    {
        "Paladin" => new Paladin(arma),
        "Elfo" => new Elfo(arma),
        "Mago" => new Mago(arma),
        _ => throw new ArgumentException($"Tipo de personaje no válido: {tipoPersonaje}")
    };
}

IWeapon CrearArma(string tipoArma)
{
    return tipoArma switch
    {
        "Espada" => new Espada(),
        "Arco" => new Arco(),
        "Hechizo" => new Hechizo(),
        _ => throw new ArgumentException($"Tipo de arma no válido: {tipoArma}")
    };
}

string ObtenerNombreArma(string tipoArma)
{
    return tipoArma switch
    {
        "Espada" => "Espada",
        "Arco" => "Arco",
        "Hechizo" => "Hechizo",
        _ => "Desconocida"
    };
}
