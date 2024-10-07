using PSP1.Creatures.Items.Protections;
using PSP1.Creatures.Items.Weapons;

namespace PSP1.Creatures.Items.Generators;

public static class ItemNameGenerator
{
    private static readonly Random Random = new Random();

    private static readonly string[] WeaponPrefixes = ["Flaming", "Ancient", "Cursed", "Blessed", "Dark", "Glorious", "Frozen", "Sharp", "Mystic"
    ];
    private static readonly string[] WeaponSuffixes = ["of Power", "of the Phoenix", "of Destruction", "of the Wolf", "of the Dragon", "of Fury", "of Thunder", "of Shadows"
    ];

    private static readonly string[] ArmorPrefixes = ["Sturdy", "Mystical", "Enchanted", "Heavy", "Holy", "Infernal", "Glorious", "Shadowed", "Iron"
    ];
    private static readonly string[] ArmorSuffixes = ["of Protection", "of Endurance", "of the Bear", "of the Eagle", "of the Lion", "of Speed", "of Vitality", "of Defense"
    ];

    public static string GenerateItemName(string type, string itemName)
    {
        string prefix = "", suffix = "";

        switch (type)
        {
            case "Weapon":
                prefix = WeaponPrefixes[Random.Next(WeaponPrefixes.Length)];
                suffix = WeaponSuffixes[Random.Next(WeaponSuffixes.Length)];
                break;
            case "Protection":
                prefix = ArmorPrefixes[Random.Next(ArmorPrefixes.Length)];
                suffix = ArmorSuffixes[Random.Next(ArmorSuffixes.Length)];
                break;
        }

        return $"{prefix} {itemName} {suffix}";
    }
}