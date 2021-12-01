using System.Reflection;

namespace cs_automaton_collection.Core
{
  
  public abstract class Head<DATA>
  {
    private Tape<DATA,Pointer> tape;

    public Head()
    {
      
    }

    private void Parse(DATA d)
    {
      
    }

    public Head<DATA> Read()
    {
      //DATA data=tape.
      //自身の状態を変化させる
      
      return this;
    }
  }
}