namespace PSP1.Creatures.Items.Protections;

public abstract class Protection : IItem
{
    public string Name { get; set; }
    public int Armor { get; set; }

    public Protection(string name, int armor)
    {
        Name = name;
        Armor = armor;
    }

    public abstract void Apply(Character character);
    public string ReturnName()
    {
        return Name;
    }
}