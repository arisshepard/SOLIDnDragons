namespace DependencyInversion.Ko;

// Player depends on Dragon
public class Player{
    private Dragon _dragon;

    public Player()
    {
        _dragon = new Dragon();
    }

    public void FightDragon(){
        // Fighting the dragon
    }

}

public class Dragon{

}