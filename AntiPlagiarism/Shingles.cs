using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;


namespace AntiPlagiarism
{
    class Shingles
    {
        static HashSet<string> stopWords = new HashSet<string>
        { 
            "это", "как", "так", "и", "в", "над", "к", "до", "не", 
            "на", "но", "за", "то", "с", "ли", "а", "во", "от", "со", 
            "для", "о",  "же", "ну", "вы", "бы", "что", "кто", "он", "она" 
        };

        public static HashSet<int> GetShingleHashes(string text, int shingleLen = 3)
        {
            var res = new HashSet<int>();

            var words = GetWordHashes(text).ToArray();

            if (words.Length < shingleLen)
            {
                res.Add(XOR(words, 0, words.Length));
            }
            else
            {
                for (int i = 0; i < words.Length - shingleLen + 1; i++)
                    res.Add(XOR(words, i, i + shingleLen));
            }

            return res;
        }

        public static float Compare(HashSet<int> signature1, HashSet<int> signature2)
        {

            var same = 0;
            foreach (var hash in signature1)
                if (signature2.Contains(hash))
                    same++;

            return 1f * same / (signature1.Count + signature2.Count - same);
        }

        static IEnumerable<int> GetWordHashes(string text)
        {
            return Regex.Matches(text, @"\w+").OfType<Match>()
                .Select(m => m.Value.ToLower())
                .Where(s => !stopWords.Contains(s))
                .Select(s => s.GetHashCode());
        }

        static int XOR(IList<int> vals, int from, int to)
        {
            var res = 0;
            to = Math.Min(vals.Count, to);
            for (int i = from; i < to; i++)
                res ^= vals[i];

            return res;
        }
    }
}
