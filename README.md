# SOLIDnDragons

## Index of contents

<a name="Index"></a>

- [Introduction](#Introduction)
- [One Responsibility to Rule Them All: SRP](#SRP)
- [Unleashing the Power of Extensibility: OCP](#OCP)
- [The Unbreakable code: LSP](#LSP)
- [Forging Interfaces of Power: ISP](#ISP)
- [Breaking the Chains of Dependency: DIP](#DIP)
- [The Adventure Continues...](#Conclusion)

## Introduction 🧙‍♀️👨‍💻🏰

<a name="Introduction"></a>

Welcome, adventurers and developers alike! 🎉 If you're looking to embark on a quest to write maintainable, extensible code in .NET, then this guide is for you. As you traverse the enchanted forests of software development, you'll encounter many obstacles that can hinder your progress. But fear not, for SOLID principles are here to guide you on your journey! 💪🏼💡

SOLID principles are like the enchanted artifacts of software development 🗡️🛡️ - they can help you write clean, maintainable code that is easy to modify and extend. In this guide, we'll explore each of the five SOLID principles and show you how to apply them to your projects. From the humble beginnings of your codebase to the epic battles against legacy code, SOLID principles will be your trusty companions.

So grab your spellbook 📚, sharpen your wits 🧠, and let's embark on a quest to master the art of SOLID principles! 🌟👨‍🏫👩‍🎓

## 1️⃣ One Responsibility to Rule Them All

<a name="SRP"></a>

In the realm of software development, there exists a powerful principle that can help you write clean, maintainable code: the **Single Responsibility Principle (SRP)**. This principle asserts that each class should have only one reason to change, meaning that it should have only one responsibility. 🧐📝

#### Breaking the SRP 💔

Picture this: you're exploring a world of adventure and danger, where mighty warriors engage in epic battles with ferocious monsters. In your code, you have a `Character` class that represents a warrior, and it has a method called `Attack` that takes another `Character` as its parameter. However, the `Attack` method doesn't just represent the act of attacking - it contains the entire combat logic. This is a violation of the SRP, as the `Character` class has two responsibilities: representing a warrior and implementing combat logic. 😱🗡️

```csharp
public class Character{
    public string Name { get; set; }
    public string Race { get; set; }
    public string Class { get; set; }

    // This should not be here - it's part of the combat logic, not the character
    public void Attack(Character anotherCharacter){
        Console.WriteLine($"Attacking {anotherCharacter.Name}");
        // The rest of the combat logic...
    }
}
```

#### Refactored code following the SRP 💪

In order to follow the SRP, we need to separate the `Character` class into two distinct classes: one for representing a warrior, and another for implementing combat logic. This way, if we need to modify the way the `Character` is represented or the way the combat logic works, we only need to modify the corresponding class. 🤓🗡️

```csharp
public class Character
{
    public string Name { get; set; }
    public string Race { get; set; }
    public string Class { get; set; }
}

public class Combat
{
    public void Attack(Character characterOne, Character characterTwo)
    {
        // Combat logic...
    }
}
``` 

With this refactoring, our code adheres to the SRP, making it easier to maintain and extend. 🙌🎉

## 2️⃣ Unleashing the Power of Extensibility

<a name="OCP"></a>

Behold the **Open/Closed Principle (OCP)** 🌟, the fundamental principle that unlocks the power of extensibility in software design. This principle declares that software entities should be open for extension but closed for modification, transforming your code from rigid to flexible and maintainable 🤖💻. With the OCP, you can add new features without having to modify existing code, making your software design skills soar to new heights 🚀. Are you ready to unleash the power of extensibility and embrace the OCP? 🤔👀

#### Breaking the OCP 💔

Alas, the OCP is not always embraced, and software code can suffer the consequences 😔. Behold the `Character` class, which can use different types of weapons to attack enemies. The current implementation uses a switch statement to determine the type of weapon being used. As new weapon types are added to the game, the `Character` class will need to be modified, violating the OCP.

```csharp
public class Character
{
    public void UseWeapon(string weapon)
    {
        switch (weapon)
        {
            case "Sword":
                // Using a sword
                break;
            case "Axe":
                // Using an axe
                break;
            // Other types
            default:
                break;
        }
    }
}
```

#### Refactored code following the OCP 💪

Fear not, for the OCP provides a path to redemption. To adhere to the OCP, we define an interface `IWeapon` that represents a weapon's behavior and have each type of weapon implement it. The `Character` class can then take an instance of `IWeapon` as a parameter for its `Attack` method, which is now open for extension as new weapon types are added to the game. 🔧🛠️

```csharp
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
```

With this refactoring, we have made the code more extensible and maintainable, allowing for seamless expansion as new weapon types are added to the game. So let us embrace the power of extensibility, and may the OCP guide us to greater heights! 🚀💻

## 3️⃣ The Unbreakable code

<a name="LSP"></a>

In the realm of code development, there dwells a mighty concept that can assist you in crafting code that is effortless to uphold and expand: the **Liskov Substitution Principle (LSP)**. This principle proclaims that instances of a superclass should be substitutable with instances of its subclasses without disrupting the application. 🧐📝

#### Breaking the LSP 💔

Imagine: you're a brave adventurer seeking the ultimate treasure: a mythical dragon's hoard. You have a `Dragon` class that represents a fearsome beast, and it has a method called `Attack` that prints out a message. However, you want to add a `FireDragon` subclass that has a different implementation of the `Attack` method, which now includes a fire attack. So far so good, right? 

Unfortunately, due to poor design, the `FireDragon` subclass violates the LSP. When you try to replace the `Dragon` object with a `FireDragon` object, the application breaks.  😱🗡️

```csharp
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
```

#### Refactored code following the LSP 💪

In order to follow the LSP, we need to use an interface or an abstract class to define the common behavior for the `Dragon` and `FireDragon` classes. This way, we can ensure that the `FireDragon` class can be used interchangeably with the `Dragon` class without breaking the application. 🤓🗡️

```csharp
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
```

With this refactoring, our code adheres to the LSP, making it easier to add new types of dragons and ensuring that the application will not break when we replace objects of the `Dragon` class with objects of its subclasses. 🙌🎉

## 4️⃣ Forging Interfaces of Power

<a name="ISP"></a>

Within the domain of software engineering, a formidable principle emerges to aid in the creation of robust and adaptable code: the **Interface Segregation Principle (ISP)**. This principle dictates that interfaces should be designed with utmost care, ensuring that they contain only relevant methods for the implementing class, thereby promoting cohesion and maintainability. 🧐📝

#### Breaking the ISP 💔

Imagine a world of mythical creatures, where dragons roam free and knights quest for glory. In your code, you have an interface called `IDragon` that defines two methods: `BreathFire` and `BreatheIce`. However, not all dragons are capable of both types of breath. In fact, some dragons can only breathe fire! By forcing all dragons to implement both methods, you are violating the ISP, as the interface is not cohesive and contains methods that are not relevant to all implementing classes. 😱🐲

```csharp
public interface IDragon
{
    void BreathFire();
    void BreatheIce();
}

public class FireDragon : IDragon
{
    public void BreatheIce()
    {
        // This method is not relevant to this type of dragon, but it's required by the interface
        throw new NotSupportedException("This dragon can't breathe ice!");
    }

    public void BreathFire()
    {
        // I am a fire dragon and I breathe fire!
    }
}
```

#### Refactored code following the ISP 💪

To follow the ISP, we need to split the `IDragon` interface into two separate interfaces: one for dragons that breathe fire, and another for dragons that breathe ice. This way, each interface will only contain methods that are relevant to the implementing classes. 🤓🔥❄️

```csharp
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
```

By adhering to the ISP, our interfaces are now more cohesive and less prone to change, making our code more adaptable and maintainable. 🙌🎉

## 5️⃣ Breaking the Chains of Dependency

<a name="DIP"></a>

In the land of software design, there exists a noble principle that can help you write flexible, maintainable code: the **Dependency Inversion Principle (DIP)**. This principle asserts that high-level modules should not depend on low-level modules; rather, both should depend on abstractions. Furthermore, abstractions should not depend on details; rather, details should depend on abstractions. 🛡️🏰

#### Breaking the DIP 💔

Imagine a brave knight on a quest to slay a ferocious dragon. In your code, you have a `Player` class that represents the knight, and it has a method called `FightDragon` that contains all the logic for the knight to battle the dragon. However, the `Player` class directly depends on the `Dragon` class, violating the DIP. This means that any changes made to the `Dragon` class would directly affect the `Player` class, making it inflexible and difficult to maintain. 😨🐉

```csharp
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
```

#### Refactored code following the DIP 💪

To respect the DIP, we need to invert the dependency between the `Player` class and the `Dragon` class. We can do this by creating an interface for the `Dragon` class and having the `Player` class depend on the interface instead of the implementation. This way, if we ever need to change the implementation of the `Dragon` class, the `Player` class won't be affected, making it much easier to maintain and extend. 🤗🐉

```csharp
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
```

With this refactoring, our code respects the DIP, making it more flexible and easier to maintain. 🙌🎉

## The Adventure Continues...

<a name="Conclusion"></a>

Congratulations, fellow adventurer! 🌟 You have made it to the end of this journey through the principles of SOLID software design. 👏

Remember, SOLID is not just a set of rules to follow blindly, but a set of guiding principles to help you make better design decisions. As you embark on your next coding quest, keep these principles in mind and apply them as needed. 🗡️

May your code always be SOLID, and may your adventures be filled with endless possibilities and glory! 👑🔥💻