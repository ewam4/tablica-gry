using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablicaWynikowGry
{
    class Game : ISubject
    {
        private List<IObserver> observers;
        private Dictionary<string, int> scores;

        public Game()
        {
            observers = new List<IObserver>();
            scores = new Dictionary<string, int>();
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(scores);
            }
        }

        public void UpdateScore(string player, int score)
        {
            scores[player] = score;
            NotifyObservers();
        }
    }
}
