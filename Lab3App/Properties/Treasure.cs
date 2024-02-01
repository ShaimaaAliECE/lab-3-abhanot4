using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Treasure : Collectable {


    public override void AddMe(List<Collectable> list)
    {
        base.AddMe(list);
        Board.UpdateTotalScore(this.Score);
    }
}