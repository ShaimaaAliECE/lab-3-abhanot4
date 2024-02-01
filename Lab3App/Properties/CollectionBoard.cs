using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CollectionBoard
    {
        public int TotalScore { get; private set; }
        public int TotalValue { get; private set; }

        public void UpdateTotalScore(int score)
        {
            TotalScore += score;
            Console.WriteLine("Total Score is updated to: " + TotalScore);
        }

        public void UpdateTotalValue(int value)
        {
            TotalValue += value;
            Console.WriteLine("Total Value is updated to: " + TotalValue);
        }
    }