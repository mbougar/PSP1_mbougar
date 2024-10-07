using PSP1.Creatures.Items.Generators;
using PSP1.Creatures.Items.Perks;

namespace PSP1.Creatures.Items.Weapons;

public class Sword(ItemPerkDelegate? applyPerk = null, ItemPerkDelegate? cancelPerk = null)
    : Weapon(ItemNameGenerator.GenerateItemName("Weapon", "Sword"), 12, applyPerk, cancelPerk)
{
    
}