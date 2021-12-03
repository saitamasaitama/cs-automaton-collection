using System;
using System.Collections.Generic;
using System.IO;

namespace cs_automaton_collection
{
  public enum BrainFuckCommand
  {
    INC_POINTER,
    DEC_POINTER,
    VAL_INC,
    VAL_DEC,
    PRINT,
    GET,
    JUMP_NEXT,
    JUMP_PREV
  }

  public abstract class Machine<COMMAND>
  where COMMAND:Enum
  {
    public abstract void Run(MachineCode<Machine<COMMAND>, COMMAND> code);
  }

  public abstract class MachineCode<T,COMMAND> : List<COMMAND>
  where T:Machine<COMMAND>
  where COMMAND: Enum
  {
    public abstract List<COMMAND> Compile2Commands(string textSource);
    public abstract byte[] ToBytes(List<COMMAND> textSource);
    public abstract List<COMMAND> FromBytes(byte[] bytes);
    
    
  }


  public class BrainFuckCode : MachineCode<BrainFuckMachine, BrainFuckCommand>
  {
    public override List<BrainFuckCommand> Compile2Commands(string textSource)
    {
      throw new NotImplementedException();
    }

    public override byte[] ToBytes(List<BrainFuckCommand> textSource)
    {
      throw new NotImplementedException();
    }

    public override List<BrainFuckCommand> FromBytes(byte[] bytes)
    {
      throw new NotImplementedException();
    }
  }
  
  public class BrainFuckMachine:Machine<BrainFuckCommand>
  {

    public StreamReader sr = new StreamReader("");

    public override void Run(MachineCode<Machine<BrainFuckCommand>, BrainFuckCommand> code)
    {
      
      throw new NotImplementedException();
    }
  }
}