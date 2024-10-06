namespace PSP1.Creatures.Items;

public interface IItem
{
    void ApplyItemBuff(Character character);
    
    void CancelItemBuff(Character character);
}