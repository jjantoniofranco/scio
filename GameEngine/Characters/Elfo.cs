using GameEngine.Abstractions;

namespace GameEngine.Characters;

public class Elfo : GameAvatar
{
    public Elfo(IWeapon item) : base(item, "Legolas")
    {
    }
}