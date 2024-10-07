using PSP1.Creatures.Items;

namespace PSP1.Creatures;

public class Character(string name, int maxHitPoints, int baseDamage, int baseArmor)
{
    public string Name { get; set; } = name;
    public int CurrentHitPoints { get; private set; } = maxHitPoints;
    public int MaxHitPoints { get; set; } = maxHitPoints;
    public int BaseDamage { get; set; } = baseDamage;
    public int BaseArmor { get; set; } = baseArmor;
    private readonly List<IItem> _inventory = [];
    public List<Minion> Minions { get; set; } = [];

    public int Attack()
    {
        return BaseDamage;
    }

    public int Defense()
    {
        return BaseArmor;
    }

    public void Heal(int points)
    {
        CurrentHitPoints += points;
        if (CurrentHitPoints > MaxHitPoints)
        {
            CurrentHitPoints = MaxHitPoints;
        }
    }

    public void ReceiveDamage(int damage)
    {
        var effectiveDamage = damage - BaseArmor;
        if (effectiveDamage > 0)
        {
            CurrentHitPoints -= effectiveDamage;
        }
    }

    public void AddItem(IItem item)
    {
        _inventory.Add(item);
        item.ApplyItemBuff(this);
    }
    
    public void RemoveItem(IItem item)
    {
        _inventory.Remove(item);
        item.CancelItemBuff(this);
    }

    public List<IItem> ListItems()
    {
        return _inventory;
    }
    
    public void AddMinion(Minion minion)
    {
        Minions.Add(minion);
    }
    
    public void RemoveMinion(Minion minion)
    {
        Minions.Remove(minion);
    }
}