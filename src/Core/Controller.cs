namespace cs_automaton_collection.Core
{
  
  
  public abstract class Controller<DATA,POINTER>
  //where POINTER:Tape<DATA,POINTER>
  {
    public POINTER KeyPointer;
    public Tape<DATA, POINTER> tape;
    
    //内部状態を持つ

    public void Update()
    {
      var data = tape[KeyPointer];
      
      
    }

    protected abstract void Parse(DATA d);
  }

  public class BrainFuck : Controller<byte, int>
  {
    protected override void Parse(byte d)
    {
      /**
    > ポインタをインクリメントする。ポインタをptrとすると、C言語の「ptr++;」に相当する。
    < ポインタをデクリメントする。C言語の「ptr--;」に相当。
    + ポインタが指す値をインクリメントする。C言語の「(*ptr)++;」に相当。
    - ポインタが指す値をデクリメントする。C言語の「(*ptr)--;」に相当。
    . ポインタが指す値を出力に書き出す。C言語の「putchar(*ptr);」に相当。
    , 入力から1バイト読み込んで、ポインタが指す先に代入する。C言語の「*ptr=getchar();」に相当。
    [ ポインタが指す値が0なら、対応する ] の直後にジャンプする。C言語の「while(*ptr){」に相当。
    ] ポインタが指す値が0でないなら、対応する [ （の直後[注釈 1]）にジャンプする。C言語の「}」に相当[注釈 2]。
       */
    }
  }
}