namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter word: ");

            string f1 = Console.ReadLine();
            string f2 = Console.ReadLine();

            string f = f1 + " " + f2;

            int count6 = 0;

            for (int i = 0; i < f.Length - 1; i++)
            {
                if (f.Substring(i, 2) == "da")
                {
                    count6++;
                }
            }

            Console.WriteLine("Combination line: " + f);
            Console.WriteLine("Number of times, when appears 'da', equals: " + count6);
        }
    }
}
////////////////////////////////////////////////////////////////////////////////////////////////

namespace task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give the word: ");

            string g = Console.ReadLine();
            string[] words7 = g.Split(' ');
            string longestWord = "";

            foreach (string word in words7)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }

            g = longestWord + " " + g.Replace(longestWord, "");

            Console.WriteLine("Updated string: " + g);

        }
    }
}
/////////////////////////////////////////////////////////////////////////////////////////////////
task8

Console.WriteLine("Enter a word for task 8: ");

string h = Console.ReadLine();
int count8 = 0;

for (int i = 0; i < h.Length; i += 2)
{
if (h[i] == 'y')
{
count8++;
}
}
////////////////////////////////////////////////////////////////////////////////////////////////////


namespace task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word for task 9(Changes everything 't' on 'T'): ");

            string q = Console.ReadLine();
            string upgQ = q.Replace('t', 'T');

            Console.WriteLine("Updated string:" + upgQ);
        }
    }
}
//////////////////////////////////////////////////////////////////////////////////////////////////////


namespace task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word for task10: ");

            string k = Console.ReadLine();

            int kk1 = 0;
            int kk2 = 0;

            for (int i = 0; i < k.Length; i++)
            {
                if (k[i] == k[0])
                {
                    kk1++;
                }
                if (k[i] == k[k.Length - 1])
                {
                    kk2++;
                }
            }

            if (kk1 > kk2)
            {
                Console.WriteLine("");
            }
            else if (kk1 < kk2)
            {
                Console.WriteLine("The last letter is more common");
            }
            else
            {
                Console.WriteLine("Both the first and last letters occur equally often");
            }
        }
    }
}
//////////////////////////////////////////////////////////////////////////////////////////////////




































