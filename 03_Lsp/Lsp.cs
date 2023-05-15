namespace Lsp.Ko;

public class Dragon
{
    public virtual void Attack()
    {
        Console.WriteLine("This dragon attacks!!!!");
    }
}

public class FireDragon : Dragon
{
    public override void Attack()
    {
        Console.WriteLine("This dragon attacks with fire!!!!");
    }
}