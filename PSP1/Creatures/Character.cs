using PSP1.Creatures.Items;

namespace PSP1.Creatures;

public class Character
{
    public string Name { get; set; }
    public int CurrentHitPoints { get; set; }
    public int MaxHitPoints { get; set; }
    public int BaseDamage { get; set; }
    public int BaseArmor { get; set; }
    private List<IItem> _inventory;

    public Character(string name, int maxHitPoints, int baseDamage, int baseArmor)
    {
        Name = name;
        MaxHitPoints = maxHitPoints;
        CurrentHitPoints = maxHitPoints;
        BaseDamage = baseDamage;
        BaseArmor = baseArmor;
        _inventory = new List<IItem>();
    }

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
        int effectiveDamage = damage - BaseArmor;
        if (effectiveDamage > 0)
        {
            CurrentHitPoints -= effectiveDamage;
        }
    }

    public void AddItem(IItem item)
    {
        _inventory.Add(item);
        item.Apply(this);
    }

    public List<IItem> ListItems()
    {
        return _inventory;
    }
}