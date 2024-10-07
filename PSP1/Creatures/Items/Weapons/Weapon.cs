using PSP1.Creatures.Items.Perks;

namespace PSP1.Creatures.Items.Weapons;

public abstract class Weapon(string name, int damage, ItemPerkDelegate? applyPerk = null, ItemPerkDelegate? cancelPerk = null) : IItem
{
    private string Name { get; init; } = name;
    private int Damage { get; set; } = damage;

    public void ApplyItemBuff(Character character)
    {
        character.BaseDamage += Damage;
        applyPerk?.Invoke(character);
    }
    
    public void CancelItemBuff(Character character)
    {
        character.BaseDamage -= Damage;
        cancelPerk?.Invoke(character);
    }

    public int GetDamage()
    {
        return Damage;
    }

    public override string ToString()
    {
        return $"{Name} | Damage: {Damage}";
    }
}