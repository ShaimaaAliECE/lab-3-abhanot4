using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Tool : Collectable {
    
    protected Tool(string description, CollectionBoard board) : base(description, board) {
    }

    public abstract override void DoAction();


}