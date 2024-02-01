using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Collectable : Displayable {
    public void AddMe(List<Collectable> list)
    {
        list.Add(this);
        Display();
    }

    Collectable(string description, CollectionBoard board) {
        Description = description;
        Board = board;
    }

}