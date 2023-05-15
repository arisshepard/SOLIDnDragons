namespace InterfaceSegregation.Ok;

public interface IFireBreather
{
    void BreathFire();

    // Other things
}

public interface IIceBreather
{
    void BreatheIce();

    // Other things
}

public class FireDragon : IFireBreather
{
    public void BreathFire()
    {
        // I am a fire dragon and I breathe fire!
    }
}