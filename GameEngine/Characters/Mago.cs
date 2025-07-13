using GameEngine.Abstractions;

namespace GameEngine.Characters;

public class Mago : GameAvatar
{
    public Mago(IWeapon item) : base(item, "Merlin")
    {
    }
} 