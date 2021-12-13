using System.Collections.Generic;

namespace cs_automaton_collection
{
  public enum BrainFuckCommand
  {
    INC_POINTER,
    DEC_POINTER,
    VAL_INC,
    VAL_DEC,
    PRINT,
    READ,
    JUMP_NEXT,
    JUMP_PREV
  }
  public class BrainFuckMachine
  {


    public static List<BrainFuckCommand> Parse(string sources)
    {
      var list = new List<BrainFuckCommand>();


      return list;
    }

  }
}