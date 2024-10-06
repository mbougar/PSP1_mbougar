using PSP1.Creatures.Items.Generators;

namespace PSP1.Creatures.Items.Weapons;

public class Sword : Weapon
{
    public Sword() : base("Sword", 12)
    {
        this.Name = ItemNameGenerator.GenerateItemName(this);
    }
}