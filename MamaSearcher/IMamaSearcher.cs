using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MamaSearcher
{
    public interface IMamaSearcher
    {
        void Subscribe(string pattern, Action<int, string> actionToPerform);
        void PerformSearch(string content);
    }
}
