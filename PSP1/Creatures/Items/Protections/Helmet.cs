using PSP1.Creatures.Items.Generators;

namespace PSP1.Creatures.Items.Protections;

public class Helmet : Protection
{
    public Helmet() : base("Helmet", 5)
    {
        this.Name = ItemNameGenerator.GenerateItemName(this);
    }

    public override void Apply(Character character)
    {
        character.BaseArmor += Armor;
    }
}