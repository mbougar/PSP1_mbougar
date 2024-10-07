using PSP1.Creatures.Items.Generators;
using PSP1.Creatures.Items.Perks;

namespace PSP1.Creatures.Items.Protections;

public class Helmet(ItemPerkDelegate? applyPerk = null, ItemPerkDelegate? cancelPerk = null)
    : Protection(ItemNameGenerator.GenerateItemName("Protection", "Helmet"), 5, applyPerk, cancelPerk);