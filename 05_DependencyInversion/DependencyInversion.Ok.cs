namespace DependencyInversion.Ok;

public class Player
{
    private readonly IDragon _dragon;

    public Player(IDragon dragon)
    {
        _dragon = dragon;
    }

    public void FightDragon()
    {
        _dragon.BreathFire();
        _dragon.ClawAttack();
        // I counter-attack!!!
    }

}

public interface IDragon
{
    void BreathFire();
    void ClawAttack();
}

public class Dragon : IDragon
{
    public void BreathFire()
    {
        // I breathe fire
    }

    public void ClawAttack()
    {
        // I split you in two with my claws
    }
}