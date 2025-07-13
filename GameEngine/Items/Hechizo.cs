using GameEngine.Abstractions;

namespace GameEngine.Items;

public class Hechizo : IWeapon
{
    public string Use()
    {
        return "ha convertido en mono al enemigo";
    }
} 