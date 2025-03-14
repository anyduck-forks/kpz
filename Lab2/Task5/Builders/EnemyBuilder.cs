namespace Lab2.Task5.Builders;

public class EnemyBuilder : ICharacterBuilder
{
    private Character _character = new Character();

    public EnemyBuilder()
    {
        Reset();
    }

    public void Reset() {
        _character = new Character();
        _character.Alignment = "Evil";
    }

    public ICharacterBuilder SetName(string name)
    {
        _character.Name = name;
        return this;
    }

    public ICharacterBuilder SetHeight(int height)
    {
        _character.Height = height;
        return this;
    }

    public ICharacterBuilder SetBuild(string build)
    {
        _character.Build = build;
        return this;
    }

    public ICharacterBuilder SetHairColor(string hairColor)
    {
        _character.HairColor = hairColor;
        return this;
    }

    public ICharacterBuilder SetEyeColor(string eyeColor)
    {
        _character.EyeColor = eyeColor;
        return this;
    }

    public ICharacterBuilder SetClothing(string clothing)
    {
        _character.Clothing = clothing;
        return this;
    }

    public ICharacterBuilder AddInventory(string inventory)
    {
        _character.Inventory.Add(inventory);
        return this;
    }

    public Character Build()
    {
        return _character;
    }
}