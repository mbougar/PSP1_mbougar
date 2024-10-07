
using PSP1.Creatures;
using PSP1.Creatures.Items;
using PSP1.Creatures.Items.Perks;
using PSP1.Creatures.Items.Protections;
using PSP1.Creatures.Items.Weapons;

namespace PSP1
{
    internal static class Program
    {
        private static void Main()
        {
            var character = new Character("Pedro", 100, 10, 0);
            
            Weapon sword = new Sword();
            Weapon axe = new Axe(Perks.PerkStrengthApply, Perks.PerkStrengthCancel);
            Protection shield = new Shield();
            Protection helmet = new Helmet(Perks.PerkSummonMinionApply);

            character.AddItem(sword);
            character.AddItem(axe);
            character.AddItem(shield);
            character.AddItem(helmet);

            Console.WriteLine($"Nuestro héroe se llama {character.Name}, y estos son los objetos de su inventario:");

            var objetos = character.ListItems();
            
            foreach (var objeto in objetos)
            {
                Console.WriteLine($" - {objeto}");
            }

            Console.WriteLine($"\nStats: Daño({character.BaseDamage}) Armadura({character.BaseArmor})");
            
            Console.WriteLine("\nInventario después de quitarle su hacha y su escudo:");
            
            character.RemoveItem(axe);
            character.RemoveItem(shield);
            
            var objetosAfter = character.ListItems();
            
            foreach (var objeto in objetosAfter)
            {
                Console.WriteLine($" - {objeto}");
            }
            
            Console.WriteLine($"\nStats: Daño({character.BaseDamage}) Armadura({character.BaseArmor})");
            
            Console.WriteLine($"\nEstos son sus minions:");
            
            foreach (var minion in character.Minions)
            {
                Console.WriteLine($" - {minion}");
            }

            Console.ReadKey();
        }
    }
}