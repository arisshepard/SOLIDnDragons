namespace Lsp.Ok;

public interface IDragon
{
    void Attack();
}

public class FireDragon : IDragon
{
    public void Attack()
    {
        Console.WriteLine("This dragon attacks with fire!!!!");
    }
}

public class VenomDragon : IDragon
{
    public void Attack()
    {
        Console.WriteLine("This dragon attacks with venom!!!!");
    }
}

public class DragonController
{
    public List<IDragon> dragons = new List<IDragon>(){
        new FireDragon(),
        new VenomDragon(),
        new FireDragon()
    };

    public void UnleashDragons()
    {
        foreach (var dragon in dragons)
        {
            dragon.Attack();
        }
    }
}
