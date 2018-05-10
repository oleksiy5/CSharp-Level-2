using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Level_2.Subject.Indexers
{
    class ExerciseIndexares
    {
        public void Test()
        {
            var game = new FamousGame();
            for (int i = 1; i <= game.Count; i++)
                Console.WriteLine(game[i]);
        }
    }

    class FamousGame
    {
        private string[] _games;

        public FamousGame()
        {
            _games = new string[3];
            _games[0] = "Mario bros";
            _games[1] = "Mortal kombat";
            _games[2] = "Street fighter";
        }

        public int Count
        {
            get { return _games.Length; }
        }

        public string this[int index]
        {
            get { return _games[index - 1]; }
            set { _games[index - 1] = value; }
        }
    }


}
