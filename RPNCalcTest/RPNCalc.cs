using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPNCalcTest
{
    public class RPNCalc
    {
    private int numinput;

    public int AddTwoNumber(string s0 )
    {
      Stack<int> stackone = new Stack<int>();
     // string s0 = Console.ReadLine();
      for (int i = 0; i < s0.Length; i++)
      {
        if (!s0[i].Equals("+") && !s0[i].Equals("-") && !s0[i].Equals("*") && !s0[i].Equals("%"))
        {        
            numinput = Convert.ToInt32(s0[i]);
            stackone.Push(numinput);
        }
        else if(s0[i].Equals("+"))
        {
          int store1 = stackone.Pop();
          int store2 = stackone.Pop();
          stackone.Push(store2 + store1);
        }
        else if (s0[i].Equals("-"))
        { 
            int store1 = stackone.Pop();
            int store2 = stackone.Pop();
            stackone.Push(store2 - store1);
         }
        else if (s0[i].Equals("*"))
        {
          int store1 = stackone.Pop();
          int store2 = stackone.Pop();
          stackone.Push(store2 * store1);
        }
        else if (s0[i].Equals("/"))
        {
          int store1 = stackone.Pop();
          int store2 = stackone.Pop();
          stackone.Push(store2 / store1);
        }
      }
      return stackone.Pop();
    }
    static void Main(string[] args)
    {
      RPNCalcexp obj = new RPNCalcexp();
      obj.TestCase1();     
    }
    }
}
