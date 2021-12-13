using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using cs_automaton_collection.CellAutomaton.D1;

namespace cs_automaton_collection
{
  public class Arg
  {
    
  }
  public class ArgParser
  {
    public ArgParser()
    {
      
    }

    public static List<Arg> Parse(string[] args)
    {
      var result = new List<Arg>();
      for (int i = 0; i < args.Length; i++)
      {
        Console.WriteLine($"[{i}]{args[i]}");
      }

      return result;
    }
  }
  
  class Program
  {
    static void Main(string[] args)
    {
      var peek = new Automaton.D1Cell()
      {
        
      };

      var automaton= new Automaton.CellAutoMaton(
        peek,
        a =>
      {
        Console.WriteLine("cellAutoMaton");
      });
      
      while (automaton.Alive)
      {
        Thread.Sleep(0);
      }　
      
      Console.WriteLine("Program Complete");
      　
    }
  }
}