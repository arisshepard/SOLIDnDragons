namespace OpenClose.Ok;

public interface IWeapon
{
    void Use();
}

public class Sword : IWeapon
{
    public void Use()
    {
        // Using a sword
    }
}

public class Axe : IWeapon
{
    public void Use()
    {
        // Using an axe
    }
}

public class Character
{
    public void Attack(IWeapon weapon)
    {
        weapon.Use();
    }
}
