using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Tool : Collectable {
    
    public Tool(string description, CollectionBoard board) : base(description, board) {
    }

    public override void AddMe(List<Collectable> list) {
        base.AddMe(list);
    }

}