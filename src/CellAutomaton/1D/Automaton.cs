using System;
using System.Collections.Generic;

namespace cs_automaton_collection.CellAutomaton.D1
{
  public class Automaton
  {
    public interface ICell : AnyCell<ICell>
    {
      ICell Left { get; }
      ICell Right { get; }
      int Index { get; }
    }

    public class CellAutoMaton : CellAutomatonAny<ICell>
    {
      public CellAutoMaton(ICell head,Action<ICell> a, int size = 100) : base(head,a)
      {
      }

    }

    public class D1Cell : ICell
    {
      public List<ICell> NextAll()
      {
        return new List<ICell>()
        {
          Left, Right
        };
      }

      public ICell Left { get; private set; }
      public ICell Right { get; private set; }
      public int Index { get; }
    }
  }
}