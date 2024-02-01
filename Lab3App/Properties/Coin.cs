using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Coin : Treasure
    {
        public int Value { get; private set; }

        public Coin(string description, int score, int value, CollectionBoard board) : base(description, score, board)
        {
            Value = value;
        }

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            Board.UpdateTotalValue(Value);
        }

        public override void Display()
        {
            Console.WriteLine("Coin " + Description + " is displayed");
        }
    }