using System;
using System.Threading;
using cs_automaton_collection.CellAutomaton.D1;

namespace cs_automaton_collection
{
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