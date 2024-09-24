namespace PSP1.Creatures.Items.Protections;

public abstract class Protection : IItem
{
    public string Name { get; set; }
    private int Armor { get; set; }

    public Protection(string name, int armor)
    {
        Name = name;
        Armor = armor;
    }

    public void ApplyItemBuff(Character character)
    {
        character.BaseArmor += Armor;
    }
    
    public void CancelItemBuff(Character character)
    {
        character.BaseArmor -= Armor;
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