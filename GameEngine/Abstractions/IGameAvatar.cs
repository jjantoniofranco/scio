namespace GameEngine.Abstractions;

public interface IGameAvatar
{
    IWeapon Weapon { get; set; }
    string Name { get; set; }

    string Attack();
}

public abstract class GameAvatar : IGameAvatar
{
    public IWeapon Weapon { get; set; }
    public string Name { get; set; }

    protected GameAvatar(IWeapon item, string name)
    {
        Weapon = item;
        Name = name;
    }
    public virtual string Attack()
    {
        return $"{Name} {Weapon.Use()}";
    }
}
