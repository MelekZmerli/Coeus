using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn{
  class Program{
    static void Main(String[] args){
      int pesos = Convert.ToInt32(Console.ReadLine()), dollars = Convert.ToInt32(Console.ReadLine());
      pesos = pesos*2/100;
      if(pesos < dollars)
        Console.Write("Pesos");
      else 
        Console.Write("Dollars");
    }
  }
}
