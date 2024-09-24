using PSP1.Creatures.Items.Generators;

namespace PSP1.Creatures.Items.Weapons;

public class Axe : Weapon
{
    public Axe() : base("Axe", 20)
    {
        this.Name = ItemNameGenerator.GenerateItemName(this);
    }
}
