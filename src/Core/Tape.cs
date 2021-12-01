using System.Collections.Generic;

namespace cs_automaton_collection.Core
{
  public interface ITape<DATA>
  {
    
  }

  public interface ISequence<DATA>:ITape<DATA>
  {
    DATA Next { get; }
    DATA Prev { get; }
  }
  
  public abstract class Tape<DATA,pointer>:Dictionary<pointer,DATA>
  {
    protected Tape()
    {
    }

    public DATA Read(pointer p)
    {
      return this[p];
    }

    public void Write(pointer p, DATA d)
    {
      this[p] = d;
    }
  }

  public class SequenceTape<DATA> : Tape<DATA,int>
  {
    
  }
}