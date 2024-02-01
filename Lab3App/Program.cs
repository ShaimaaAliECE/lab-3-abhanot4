using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab3App
{
    public class Program
    {
        public static void Main(string[] args)
{
    CollectionBoard board = new CollectionBoard();

    List<Collectable> possibleCollectiable = new List<Collectable>();
    possibleCollectiable.Add(new Coin("Nickel", 20, 5, board));
    possibleCollectiable.Add(new Coin("Dime", 40, 10, board));
    possibleCollectiable.Add(new Coin("Toony", 50, 100, board));

    for (int i = 1; i <= 5; i++)
    {
        possibleCollectiable.Add(new Diamond("Diamond" + i, 100, board));
    }

    possibleCollectiable.Add(new Axe("OnlyAxe", board));
    possibleCollectiable.Add(new MagicWand("OnlyMagicWand", board));

    List<Collectable> collected = new List<Collectable>();

    foreach (Collectable collectable in possibleCollectiable)
    {
        Console.WriteLine(collectable.Description + " Collected, Congrats!!!!");
        collectable.AddMe(collected);
        if (collectable is Tool tool)
        {
            tool.DoAction();
            
        }
    }

    Console.WriteLine("========================================");
    Console.WriteLine("==== All the Collected items ===========");
    Console.WriteLine("========================================");
    foreach (Collectable collectable in collected)
    {
        collectable.Display();
    }
}

        }
    }