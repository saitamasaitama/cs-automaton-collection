using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using cs_automaton_collection.Core;

namespace cs_automaton_collection
{
  public interface IAutomatonInterface
  {
  }

  public abstract class Teep<ITEM> : IAutomatonItem
    where ITEM:IAutomatonItem
  {

    public ITEM Head;
  }
  

  public abstract class Automaton<ITEM> : IAutomatonInterface
  where ITEM:IAutomatonItem
  {
    protected ITEM head;

    public bool Alive { get; private set; } = false;
    private DateTime WatchDogTimer;

    public void Kill()
    {
      //イベントを仕込もう
      Alive = false;
    }
    
    public Automaton(ITEM head, Action<ITEM> a)
    {
      this.head = head;
      this.Start(a);
    }
    
    public Automaton<ITEM> Start(Action<ITEM> a)
    {
      this.Alive = true;
      this.WatchDogTimer = DateTime.Now + TimeSpan.FromSeconds(10);
      (new Thread(new ThreadStart(
        () =>
        {
          while (Alive && DateTime.Now < WatchDogTimer)
          {
            //1ループを決める
            a(this.head);
          }
          Console.WriteLine("Thread Exit");
          Alive = false;
        }
      ))).Start();
      return this;
    }

    public void Stop()
    {
      this.Kill();
    }
  }

  /*
  public interface ITuringMachine<CON, HEAD, TAPE>
    where CON : Controller
    where HEAD : Head
    where TAPE:Tape
  {
    
    CON Controller { get; set; }
    HEAD Head { get; set; }
    TAPE Tape { get; set; }
  }

  public abstract class TuringAutomaton:ITuringMachine
  {

  }*/
}