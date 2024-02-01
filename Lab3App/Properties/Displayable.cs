using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface Displayable
{
    void Display();
}

public abstract class Collectable : Displayable
{
    public string Description { get; protected set; }
    public CollectionBoard Board { get; set; }

    protected Collectable(string description, CollectionBoard board)
    {
        Description = description;
        Board = board;
    }

    public virtual void AddMe(List<Collectable> list)
    {
        list.Add(this);
        Display();
    }

    public abstract void Display();
}