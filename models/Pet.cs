using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplosFundamentos.models.pet
{
    public class Pet
    {
        public string Raca { get; set; }
        public int Idade { get; set; }
  
    public void Apresentar()
        {
            Console.WriteLine($"Eu sou da Raça {Raca} e tenho {Idade} anos.");
        }
      }
}