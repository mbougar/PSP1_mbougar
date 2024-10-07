using PSP1.Creatures.Items.Generators;
using PSP1.Creatures.Items.Perks;

namespace PSP1.Creatures.Items.Protections;

public class Shield(ItemPerkDelegate? applyPerk = null, ItemPerkDelegate? cancelPerk = null)
    : Protection(ItemNameGenerator.GenerateItemName("Protection", "Shield"), 10, applyPerk, cancelPerk);