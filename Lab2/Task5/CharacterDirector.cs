using Lab2.Task5.Builders;

namespace Lab2.Task5;


public class CharacterDirector
{
    public Character ConstructL(ICharacterBuilder builder)
    {
        return builder
            .SetName("Detective L")
            .SetHeight(179)
            .SetBuild("Weak")
            .SetHairColor("Brown")
            .SetEyeColor("Brown")
            .SetClothing("Rugs")
            .AddInventory("Sugar Cubes")
            .Build();
    }

    public Character ConstructYagami(ICharacterBuilder builder)
    {
        return builder
            .SetName("Light Yagami")
            .SetHeight(180)
            .SetBuild("Weak")
            .SetHairColor("Black")
            .SetEyeColor("Black")
            .SetClothing("Suit")
            .AddInventory("Death Note")
            .Build();
    }
}