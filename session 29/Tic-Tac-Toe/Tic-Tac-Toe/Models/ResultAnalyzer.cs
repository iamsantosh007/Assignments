using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Tic_Tac_Toe.Models
{
    public class ResultAnalyzer
    {
        private Board _board;

        public ResultAnalyzer(Board board)
        {
            _board = board;
        }

        public Board Board { get { return _board; } }

        public ResultType Analyzer()
        {
            if (_board.IsEmpty())
                return ResultType.NoResult;
            if(_board.VerticalMatch()||_board.HorizontalMatch()||_board.DiagonalMatch())
                return ResultType.Win;
            if(_board.NoFieldRemaining())
                return ResultType.Draw;
            return ResultType.NoResult;
        }
    }
}
