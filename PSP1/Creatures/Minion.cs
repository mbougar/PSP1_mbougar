namespace PSP1.Creatures;

public class Minion(int maxHitPoints, int baseDamage, int baseArmor, Character owner)
{
    private int CurrentHitPoints { get; set; } = maxHitPoints;
    private int MaxHitPoints { get; set; } = maxHitPoints;
    private int BaseDamage { get; set; } = baseDamage;
    private int BaseArmor { get; set; } = baseArmor;

    private Character Owner { get; set; } = owner;

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
        if (effectiveDamage <= 0) return;
        CurrentHitPoints -= effectiveDamage;
        if (CurrentHitPoints <= 0)
        {
            Owner.RemoveMinion(this);
        }
    }

    public override string ToString()
    {
        return $"[Minion] Owner: {Owner.Name}, CurrentHitPoints: {CurrentHitPoints}, MaxHitPoints: {MaxHitPoints}";
    }
}