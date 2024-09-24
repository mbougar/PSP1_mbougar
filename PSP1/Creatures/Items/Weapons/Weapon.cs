namespace PSP1.Creatures.Items.Weapons;

public abstract class Weapon : IItem
{
    public string Name { get; set; }
    private int Damage { get; set; }

    public Weapon(string name, int damage)
    {
        Name = name;
        Damage = damage;
    }

    public void ApplyItemBuff(Character character)
    {
        character.BaseDamage += Damage;
    }
    
    public void CancelItemBuff(Character character)
    {
        character.BaseDamage -= Damage;
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