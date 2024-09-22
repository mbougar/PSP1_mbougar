namespace PSP1.Creatures.Items;

public interface IItem
{
    void Apply(Character character);

    string ReturnName();
}