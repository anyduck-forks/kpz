namespace Lab2.Task5.Builders;
public interface ICharacterBuilder
{
    void Reset();
    ICharacterBuilder SetName(string name);
    ICharacterBuilder SetHeight(int height);
    ICharacterBuilder SetBuild(string build);
    ICharacterBuilder SetHairColor(string hairColor);
    ICharacterBuilder SetEyeColor(string eyeColor);
    ICharacterBuilder SetClothing(string clothing);
    ICharacterBuilder AddInventory(string inventory);
    Character Build();
}