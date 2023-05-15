namespace SingleResponsibility.Ko;

public class Character
{
    public string Name { get; set; }
    public string Race { get; set; }
    public string Class { get; set; }

    // This souldn't be here because is part of the combat logic not the character
    public void Attack(Character anotherCharacter)
    {
        Console.WriteLine($"Attacking {anotherCharacter.Name}");
    }
}