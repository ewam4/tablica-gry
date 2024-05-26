using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablicaWynikowGry
{
    interface IObserver
    {
        void Update(Dictionary<string, int> scores);
    }
}
