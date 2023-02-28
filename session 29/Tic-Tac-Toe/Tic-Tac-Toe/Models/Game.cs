using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.Models
{
    public class Game
    {
        private Board _board;

        private ResultAnalyzer _analyzer;

        private Player[] _players;

        private Player _curruntPlayer;

        private ResultType _status;

        public Game(Board board,ResultAnalyzer resultAnalyzer, Player[] player)
        {
            _board = board;
            _analyzer = resultAnalyzer;
            _players=player;
            _curruntPlayer = _players[0];
        }


        public void Play(int cellPosition)
        {
            _board.MakeCell(cellPosition,_curruntPlayer.Mark);
            _status = _analyzer.Analyzer();
            if (_curruntPlayer == _players[0])
            {
                _curruntPlayer = _players[1];

            }
            else
            {
                _curruntPlayer = _players[0];
            }

           
        }

        public ResultType Status
        {
            get { return _status; }
        }

        public Player CurruntPlayer { get { return _curruntPlayer; } }
    }
}
