using GameEngine.Abstractions;

namespace GameEngine.Items;

public class Arco : IWeapon
{
    public string Use()
    {
        return "ha acertado en el corazón del enemigo";
    }
} 