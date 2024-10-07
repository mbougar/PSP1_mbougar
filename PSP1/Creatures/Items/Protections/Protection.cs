using PSP1.Creatures.Items.Perks;

namespace PSP1.Creatures.Items.Protections;

public abstract class Protection(string name, int armor, ItemPerkDelegate? applyPerk = null, ItemPerkDelegate? cancelPerk = null) : IItem
{
    protected string Name { get; init; } = name;
    private int Armor { get; set; } = armor;

    public void ApplyItemBuff(Character character)
    {
        character.BaseArmor += Armor;
        applyPerk?.Invoke(character);
    }
    
    public void CancelItemBuff(Character character)
    {
        character.BaseArmor -= Armor;
        cancelPerk?.Invoke(character);
    }

    public int GetArmor()
    {
        return Armor;
    }

    public override string ToString()
    {
        return $"{Name} | Armor: {Armor}";
    }
}