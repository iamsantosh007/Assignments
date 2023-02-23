using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame.Models
{
    public class Player
    {
        private string _name;
        private InputsForPlay _inputPlay;

        public Player(string name, InputsForPlay inputPlay)
        {
            _name = name;
            _inputPlay = inputPlay;
        }

        public string Name { get { return _name; } set { _name = value; } }
        //public InputsForPlay InputPlay { get { return _inputPlay; }}

        public  string InputType()
        {
            if (_inputPlay == InputsForPlay.X)
            {
                return "x";
            }
            if(_inputPlay==InputsForPlay.O)
            {
                return "o";
            }
            return null; 
        }
    }
}
