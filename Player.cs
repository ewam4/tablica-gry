using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablicaWynikowGry
{
    class Player : IObserver
    {
        private string name;
        private Dictionary<string, int> scores;

        public Player(string name)
        {
            this.name = name;
            scores = new Dictionary<string, int>();
        }

        public void Update(Dictionary<string, int> scores)
        {
            this.scores = new Dictionary<string, int>(scores);
            DisplayScores();
        }

        public void DisplayScores()
        {
            Console.WriteLine($"Wyniki gracza {name}:");
            foreach (var entry in scores)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
    }
}
