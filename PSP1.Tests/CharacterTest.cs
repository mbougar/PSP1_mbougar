using PSP1.Creatures;
using PSP1.Creatures.Items.Protections;
using PSP1.Creatures.Items.Weapons;
using JetBrains.Annotations;

namespace PSP1.Tests;

[TestSubject(typeof(Character))]
public class CharacterTest: IDisposable
{
    
    // test constants
    private const string TestName = "TestName";
    private const int TestHp = 100;
    private const int TestDamage = 10;
    private const int TestArmor = 10;

    // test variables
    private Character _character;
    private int _testItems;
    private readonly List<Character> _characters = new List<Character>(); // just for dispose example
    
    public CharacterTest()
    {
        // test constructor, arrange data for every test.
        // every test method generates a new CharacterTest object.
        _character = new Character(TestName, TestHp, TestDamage, TestArmor);
        _characters.Add(_character);
        _character.AddItem(new Axe());
        _character.AddItem(new Sword());
        _character.AddItem(new Helmet());
        _character.AddItem(new Shield());
        _testItems = _character.ListItems().Count;
    }

    public void Dispose()
    {
        _characters.Clear();
    }
    
    [Fact]
    public void CharactersTest()
    {
        // test character list
        Assert.Single(_characters);
    }
    
    [Fact]
    public void NameTest()
    {
        // test character name
        Assert.Equal(TestName, _character.Name);
    }
    
    [Fact]
    public void HpTest()
    {
        // test maxhp
        Assert.Equal(TestHp, _character.MaxHitPoints);
        _character = new Character(TestName, TestHp, TestDamage, TestArmor);
        Assert.Equal(TestHp, _character.MaxHitPoints);
    }
    
    [Fact]
    public void InventoryTest()
    {
        // test inventory
        Assert.Equal(_testItems, _character.ListItems().Count);
        Assert.Equal(_character.BaseDamage, _character.Attack());
        Assert.Equal(_character.BaseArmor, _character.Defense());
        var newItem = new Axe();
        _character.AddItem(newItem);
        Assert.Equal(_character.BaseDamage, _character.Attack());
        _character.RemoveItem(newItem);
        Assert.Equal(4, _character.ListItems().Count);
    }
    
    [Fact]
    public void HealthTest()
    {
        // test heal/receive damage
        _character.ReceiveDamage(30); //Como tiene 25 de armadura realizar 40 de daño le quitara 5 de vida
        Assert.Equal(95, _character.CurrentHitPoints);
        _character.Heal(10);
        Assert.Equal(100, _character.CurrentHitPoints);
    }
}