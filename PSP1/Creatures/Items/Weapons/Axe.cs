using PSP1.Creatures.Items.Generators;
using PSP1.Creatures.Items.Perks;

namespace PSP1.Creatures.Items.Weapons;

public class Axe(ItemPerkDelegate? applyPerk = null, ItemPerkDelegate? cancelPerk = null)
    : Weapon(ItemNameGenerator.GenerateItemName("Weapon", "Axe"), 20, applyPerk, cancelPerk);
