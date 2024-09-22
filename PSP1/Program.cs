
using PSP1.Creatures;
using PSP1.Creatures.Items;
using PSP1.Creatures.Items.Protections;
using PSP1.Creatures.Items.Weapons;

namespace PSP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character character = new Character("Pedro", 100, 10, 0);
            
            Weapon sword = new Sword();
            Weapon axe = new Axe();
            Protection shield = new Shield();
            Protection helmet = new Helmet();

            character.AddItem(sword);
            character.AddItem(axe);
            character.AddItem(shield);
            character.AddItem(helmet);

            Console.WriteLine($"Nuestro héroe se llama {character.Name}, y estos son los objetos de su inventario:");

            List<IItem> objetos = character.ListItems();
            
            foreach (var objeto in objetos)
            {
                Console.WriteLine($" - {objeto.ReturnName()}");
            }

            Console.ReadKey();
        }
    }
}