namespace SingleResponsibility.Ok;

public class Character
{
    public string Name { get; set; }
    public string Race { get; set; }
    public string Class { get; set; }
}

public class Combat{
    public void Attack(Character characterOne, Character characterTwo){
        // Combat logic
    }
}