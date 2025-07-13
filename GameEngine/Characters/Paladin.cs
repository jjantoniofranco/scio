using GameEngine.Abstractions;

namespace GameEngine.Characters;

public class Paladin : GameAvatar
{
    public Paladin(IWeapon item) : base(item, "Conan")
    {
    }
}