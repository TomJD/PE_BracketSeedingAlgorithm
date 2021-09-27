using System;
using System.Collections.Generic;

namespace PE_BracketSeedingAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] participants = new int[] { 1, 2, 3, 4, 5, 6, 7, 8/*, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 */};

            var participantsCount = participants.Length;

            var rounds = Math.Ceiling(Math.Log(participantsCount) / Math.Log(2));
            var bracketSize = Math.Pow(2, rounds);
            var byes = bracketSize - participantsCount;


            Console.WriteLine("Checked in players " + participantsCount + "!");
            Console.WriteLine("Creating " + rounds + " rounds!");
            Console.WriteLine("Bracket Size " + bracketSize);
            Console.WriteLine("Byes " + byes);

            //int[] matches = new int[] { 1, 2 };
            List<Tuple<int, int>> matches = new List<Tuple<int, int>>();

            matches.Add(Tuple.Create(1, 2));


            for (var round = 1; round < rounds; round++)
            {
                List<Tuple<int, int>> roundMatches = new List<Tuple<int, int>>();
                var sum = Math.Pow(2, round + 1) + 1;

                for (int i = 0; i < matches.Count; i++)
                {
                    var home = changeIntoBye(matches[i].Item1, participantsCount);
                    //Console.WriteLine(home + " " + matches[i].Item1);
                    var away = changeIntoBye((int)(sum - matches[i].Item1), participantsCount);
                    //Console.WriteLine(away + " " + (sum - matches[i].Item1));

                    roundMatches.Add(Tuple.Create(home, away));

                    home = changeIntoBye((int)(sum - matches[i].Item2), participantsCount);
                    away = changeIntoBye(matches[i].Item2, participantsCount);

                    roundMatches.Add(Tuple.Create(home, away));
                }

                matches = roundMatches;

                Console.WriteLine("--------------------------RESULTS----------------------");
                Console.WriteLine("Round " + (round + 1));
                foreach (var match in matches)
                {
                    Console.WriteLine("{0} vs {1}", match.Item1, match.Item2);
                }
            }

            matches.Add(Tuple.Create(-1, -1));
            Console.WriteLine("Final");

        }
        static int changeIntoBye(int seed, int participantsCount)
        {
            return seed <= participantsCount ? seed : -1;
        }
    }
}
