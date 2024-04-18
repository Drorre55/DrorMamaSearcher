using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace MamaSearcher
{
    internal class Searcher : IMamaSearcher
    {
        private Dictionary<string, Action<int, string>> _patternToAction = new Dictionary<string, Action<int, string>>();

        public void Subscribe(string pattern, Action<int, string> actionToPerform)
        {
            _patternToAction.Add(pattern, actionToPerform);
        }
        
        public void PerformSearch(string content)
        {
            foreach (string pattern in _patternToAction.Keys)
            {
                int zeroIndex = content.IndexOf(pattern);
                if (zeroIndex != -1)
                {
                    _patternToAction[pattern].Invoke(zeroIndex, pattern);
                }
            }
        }
    }
}
