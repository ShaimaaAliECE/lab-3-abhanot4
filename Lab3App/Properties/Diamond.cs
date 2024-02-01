using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Diamond : Treasure
    {
        public Diamond(string description, int score, CollectionBoard board) : base(description, score, board) { }

        public override void Display()
        {
            Console.WriteLine("Diamond" + Description + " is displayed");
        }

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
        }
    }
