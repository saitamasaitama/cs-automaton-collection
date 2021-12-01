using System;
using System.Collections.Generic;

namespace cs_automaton_collection.CellAutomaton
{
  public class CellAutomaton
  {
    
  }
  public interface AnyCell<T>:IAutomatonItem
    where T:AnyCell<T>
  {
    List<T> NextAll();
  }

  
  public abstract class CellAutomatonAny<CELL> : Automaton<CELL>
    where CELL:AnyCell<CELL>
  {
    public CellAutomatonAny(CELL item, Action<CELL> a) : base(item,a)
    {
    }
  }
}