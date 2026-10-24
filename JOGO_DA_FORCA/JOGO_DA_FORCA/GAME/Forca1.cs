using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME
{
    class Forca
    {
        public string[] Palavras { get; set; }
        public string[] Dicas { get; set; }
        public int Pos { get; set; }

        public Forca(string[] Palavras, string[] Dicas)
        {
            this.Palavras = Palavras;
            this.Dicas = Dicas;
            this.Pos = 0;
        }
        public void sortear()
        {
            Random sorteio = new Random();
            this.Pos = sorteio.Next(0, Palavras.Count());
        }
    }
}