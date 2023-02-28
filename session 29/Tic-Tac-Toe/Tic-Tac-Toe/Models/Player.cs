using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.Models
{
    public class Player
    {
        private string _name;
        private MarkType _mark;

        public Player(string name,MarkType mark) 
        { 
                _name= name;
                _mark= mark;    
        }
        public Player()
        {

        }

        public string Name { get { return _name; } set { _name = value; } }
        public MarkType Mark { get { return _mark;} set { _mark = value; } }


    }
}
