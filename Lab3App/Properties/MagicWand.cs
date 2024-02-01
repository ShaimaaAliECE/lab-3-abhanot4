using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MagicWand : Tool {

    public MagicWand(string description, CollectionBoard board) : base(description, board) {}
    
    public override void Display() {
        Console.WriteLine($"MagicWand {Description} is displayed");
    }

    public override void DoAction() {
        Console.WriteLine("MagicWand is Used");
    }
}