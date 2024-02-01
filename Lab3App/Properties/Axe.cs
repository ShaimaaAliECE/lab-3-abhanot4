using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Axe : Tool {

    public Axe(String description, CollectionBoard board) : base(description, board) {
    }

    public void override Display() {
        Console.WriteLine($"Axe {Description} is displayed");
    }

    public void doAction(){
        Console.WriteLine("Axe is Used");
    }
}