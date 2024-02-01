using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MagicWand : Tool {

    public MagicWand(String description, CollectionBoard board) : base(description, board) {}
    
    public void override Display() {
        Console.WriteLine($"MagicWand {Description} is displayed");
    }

    public void DoAction() {
        Console.WriteLine("MagiceWand is Used");
    }
}