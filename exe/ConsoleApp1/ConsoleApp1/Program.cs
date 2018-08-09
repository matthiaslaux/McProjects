using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      string sMsg = "Hello World!";
      if (args.Length > 0)
      {
        sMsg = args[0];
      }
      Console.WriteLine("User said: " + sMsg);
      Console.ReadLine();
    }
  }
}
