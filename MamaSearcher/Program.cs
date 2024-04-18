namespace MamaSearcher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Searcher searcher = new Searcher();
            searcher.Subscribe("test", PrintResult);
            searcher.PerformSearch("Hello, World!testgarbage");
        }

        static void PrintResult(int index, string pattern)
        {
            string text = $"{index}: {pattern}";
            Console.WriteLine(text);
        }
    }
}
