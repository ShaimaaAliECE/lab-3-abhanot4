using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Lab3App")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("Lab3App")]
[assembly: AssemblyCopyright("Copyright ©  2024")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("f8d03a7a-bfdf-4cdb-8840-acc9ea70e485")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
/*using System;
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
            // Create a collection board
            CollectionBoard board = new CollectionBoard();

            List<Collectable> possibleCollectiable = new List<Collectable>();
            // Three coins 
            possibleCollectiable.Add(new Coin("Nickel", score:20, value:5));
            possibleCollectiable.Add(new Coin("Dime", score:40, value:10));
            possibleCollectiable.Add(new Coin("Toony", score: 50, value: 100));

            // Five Diamonds with descriptions Diamond1, Diamond2, ... etc.
            for (int i = 1;i <= 5; i++)
            {
                possibleCollectiable.Add(new Diamond("Diamond"+ i, score: 100));
            }

            // One Axe
            possibleCollectiable.Add(new Axe("OnlyAxe"));

            // One MagicWand
            possibleCollectiable.Add(new MagicWand("OnlyMagicWand"));

            // Associate the CollectionBoard object to all the possible Collectiables
            // using a foreach loop
            foreach (Collectable collectable in  possibleCollectiable)
            {
                collectable.Board = board;
            }

            // Create an empty list to start collecting 
            List<Collectable> collected = new List<Collectable>();

            //Collect the items one-by-one in a foreach loop
            foreach (Collectable collectable in possibleCollectiable)
            { 
                collectable.AddMe(collected);
            }

            Console.WriteLine("========================================");
            Console.WriteLine("==== All the Collected items ===========");
            Console.WriteLine("========================================");
            //Display all what was collected in a for each loop
            foreach (Collectable collectable in possibleCollectiable)
            {
                collectable.Display();
            }
        }
    }
}
public class Axe : Tool {

    public Axe(string description, CollectionBoard board) : base(description, board) {
    }
	public Axe(string description) : this(description, null) {
    }

    public override void Display() {
        Console.WriteLine("Axe " + Description + " is displayed");
    }

    public override void DoAction(){
        Console.WriteLine("Axe is Used");
    }
}public class Coin : Treasure {

    public int Value { get; private set; }

    public Coin(string description, int score, int value) : this(description, score, value, null) {
    }

    public Coin(string description, int score, int value, CollectionBoard board) : base(description, score, board) {
        Value = value;
    }
    public override void Display() {
       
    }
    public override void AddMe(List<Collectable> list) {

        base.AddMe(list);
        Board.UpdateTotalValue(Value);
        Console.WriteLine(Description + " Collected, Congrats!!!!");
        Console.WriteLine("Total Value is updated to: " + Board.TotalValue); 
        Console.WriteLine("Total Score is updated to: " + Board.TotalScore); 
    }

}public abstract class Collectable : Displayable {

    public string Description { get; protected set; }
    public CollectionBoard Board { get; set; }

    public virtual void AddMe(List<Collectable> list)
    {
    }

    protected Collectable(string description, CollectionBoard board) {
        Description = description;
        Board = board;
    }

    public abstract void Display();

}public class CollectionBoard {

    public int TotalScore { get; private set; }
    public int TotalValue { get; private set; }

    public void UpdateTotalScore(int score)
    {
        TotalScore += score;
    }

    public void UpdateTotalValue(int value)
    {
        TotalValue += value;
    }
}public class Diamond : Treasure {

    public Diamond(string description, int score) : this(description, score, null) {
    }

    public Diamond(string description, int score, CollectionBoard board) : base(description, score, board) {
    }
    public override void Display()
    {
        Console.WriteLine("Diamond" + Description +" is displayed");
    }
	public override void AddMe(List<Collectable> list) {
        base.AddMe(list);}


}public interface Displayable
{
    void Display();
}public class MagicWand : Tool {

    public MagicWand(string description, CollectionBoard board) : base(description, board) {}
    
    public MagicWand(string description) : this(description, null) {
    }
	
	public override void Display() {
        Console.WriteLine("MagicWand " + Description + " is displayed");
    }

    public override void DoAction() {
        Console.WriteLine("MagicWand is Used");
    }
}public abstract class Tool : Collectable {
    
    protected Tool(string description, CollectionBoard board) : base(description, board) {
    }

    public abstract void DoAction();


}public abstract class Treasure : Collectable {


    public override void AddMe(List<Collectable> list)
    {
        base.AddMe(list);
        Board.UpdateTotalScore(Score);
        Console.WriteLine(Description + " Collected, Congrats!!!!");
        Console.WriteLine("Total Score is updated to: " + Board.TotalScore);}
    public int Score { get; protected set; }

    protected Treasure(string description, int score, CollectionBoard board) : base(description, board)
    {
        Score = score;
    }
}*/
