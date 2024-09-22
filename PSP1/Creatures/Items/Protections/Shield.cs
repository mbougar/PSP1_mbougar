using PSP1.Creatures.Items.Generators;

namespace PSP1.Creatures.Items.Protections;

public class Shield : Protection
{
    public Shield() : base("Shield", 10)
    {
        this.Name = ItemNameGenerator.GenerateItemName(this);
    }

    public override void Apply(Character character)
    {
        character.BaseArmor += Armor;
    }
}