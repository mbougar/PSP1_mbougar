using PSP1.Creatures.Items.Protections;
using PSP1.Creatures.Items.Weapons;

namespace PSP1.Creatures.Items.Generators;

public static class ItemNameGenerator
{
    private static Random _random = new Random();

    private static string[] _weaponPrefixes = { "Flaming", "Ancient", "Cursed", "Blessed", "Dark", "Glorious", "Frozen", "Sharp", "Mystic" };
    private static string[] _weaponSuffixes = { "of Power", "of the Phoenix", "of Destruction", "of the Wolf", "of the Dragon", "of Fury", "of Thunder", "of Shadows" };

    private static string[] _armorPrefixes = { "Sturdy", "Mystical", "Enchanted", "Heavy", "Holy", "Infernal", "Glorious", "Shadowed", "Iron" };
    private static string[] _armorSuffixes = { "of Protection", "of Endurance", "of the Bear", "of the Eagle", "of the Lion", "of Speed", "of Vitality", "of Defense" };

    public static string GenerateItemName(IItem item)
    {
        string prefix = "", typeName = "", suffix = "";

        if (item is Weapon)
        {
            prefix = _weaponPrefixes[_random.Next(_weaponPrefixes.Length)];
            typeName = item.GetType().Name;
            suffix = _weaponSuffixes[_random.Next(_weaponSuffixes.Length)];
        }
        else if (item is Protection)
        {
            prefix = _armorPrefixes[_random.Next(_armorPrefixes.Length)];
            typeName = item.GetType().Name;
            suffix = _armorSuffixes[_random.Next(_armorSuffixes.Length)];
        }

        return $"{prefix} {typeName} {suffix}";
    }
}