using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Treasure : Collectable {


    public override void AddMe(List<Collectable> list)
    {
        base.AddMe(list);
        Board.UpdateTotalScore(Score);
    }

    public int Score { get; protected set; }

    protected Treasure(string description, int score, CollectionBoard board) : base(description, board)
    {
        Score = score;
    }
}