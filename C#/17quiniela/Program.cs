using System;

namespace _17quiniela {
    class Program {
        static void Main (string[] args) {
            char[] possibleResults = { '1', 'X', '2' };
            string[] teams = { "rMadrid", "rayoVallecano", "atlMadrid", "getafeCD", "alcorcon", "fuenlabrada" }, teamsMirrored = new string[6];

            for (int i = 0; i < teamsMirrored.Length; i++) {
                string teamOne = "", teamTwo = "";
                Random randomizer = new Random ();

                int counter = 0, counter2 = 0;
                int defPosition = randomizer.Next (0, teams.Length);
                teamOne = teams[defPosition];

                for (int j = 0; j < teams.Length; j++) {
                    if (j != defPosition) {
                        teamsMirrored[counter] = teams[j];
                        counter++;
                    }
                }
                teams = teamsMirrored;

                int defPosition2 = randomizer.Next (0, teams.Length);
                teamTwo = teams[defPosition2];

                for (int j = 0; j < teams.Length; j++) {
                    if (j != defPosition2) {
                        teamsMirrored[counter2] = teams[j];
                        counter2++;
                    }
                }

                int randomResult = randomizer.Next (0, possibleResults.Length);
                char result = possibleResults[randomResult];
                Console.WriteLine ("Partido #", i + 1 + ": ");
                Console.WriteLine (teamOne + " " + result + " " + teamTwo + "\n");
            }
        }
    }
}