namespace PSP1.Creatures.Items.Perks;

public delegate void ItemPerkDelegate(Character character);

public class Perks
{
    public static void PerkStrengthApply(Character character)
    {
        character.BaseDamage += 10;
    }
    
    public static void PerkStrengthCancel(Character character)
    {
        character.BaseDamage -= 10;
    }
    
    public static void PerkDefenseApply(Character character)
    {
        character.BaseArmor += 5;
    }
    
    public static void PerkDefenseCancel(Character character)
    {
        character.BaseArmor -= 5;
    }
    
    public static void PerkHealthApply(Character character)
    {
        character.MaxHitPoints += 20;
    }
    
    public static void PerkHealthCancel(Character character)
    {
        character.MaxHitPoints -= 20;
    }
    
    public static void PerkSummonMinionApply(Character character)
    {
        var minion = new Minion(20, 10, 10, character);
        character.AddMinion(minion);
    }
}