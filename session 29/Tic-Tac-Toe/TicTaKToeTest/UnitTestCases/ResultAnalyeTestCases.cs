using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toe.Models;

namespace TicTaKToeTest.UnitTestCases
{
    [TestClass]
    public class ResultAnalyeTestCases
    {
        [TestMethod]
        public void Analyze_shouldResultNoResultForEmptyBoard()
        {
            Board board=new Board();
            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);
            ResultType result = resultAnalyzer.Analyzer();
            Assert.IsTrue(result==ResultType.NoResult);

        }

        [TestMethod]
        public void ShouldWinWhenDiagonalMathForXorO()
        {
            Board board=new Board();
            ResultAnalyzer resultAnalyzer=new ResultAnalyzer(board);
            resultAnalyzer.Board.MakeCell(0,MarkType.X);
            resultAnalyzer.Board.MakeCell(4, MarkType.X);
            resultAnalyzer.Board.MakeCell(8, MarkType.X);
            ResultType resultType= resultAnalyzer.Analyzer();
            Assert.IsTrue(resultType==ResultType.Win);
        }

        [TestMethod]
        public void ShouldWinWhenVerticalMatchForXorO()
        {
            Board board = new Board();
            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);
            resultAnalyzer.Board.MakeCell(0, MarkType.X);
            resultAnalyzer.Board.MakeCell(3, MarkType.X);
            resultAnalyzer.Board.MakeCell(6, MarkType.X);
            ResultType resultType = resultAnalyzer.Analyzer();
            Assert.IsTrue(resultType == ResultType.Win);
        }
        [TestMethod]
        public void ShouldWinWhenHorizontalMathForXorO()
        {
            Board board = new Board();
            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);
            resultAnalyzer.Board.MakeCell(0, MarkType.X);
            resultAnalyzer.Board.MakeCell(1, MarkType.X);
            resultAnalyzer.Board.MakeCell(2, MarkType.X);
            ResultType resultType = resultAnalyzer.Analyzer();
            Assert.IsTrue(resultType == ResultType.Win);
        }

        [TestMethod]
        public void ShouldResultDeclaredAsDrawWhenNoPlaceRemainingForMark()
        {
            Board board = new Board();
            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);
            resultAnalyzer.Board.MakeCell(0, MarkType.X);
            resultAnalyzer.Board.MakeCell(1, MarkType.O);
            resultAnalyzer.Board.MakeCell(2, MarkType.X);
            resultAnalyzer.Board.MakeCell(3, MarkType.X);
            resultAnalyzer.Board.MakeCell(4, MarkType.X);
            resultAnalyzer.Board.MakeCell(5, MarkType.O);
            resultAnalyzer.Board.MakeCell(6, MarkType.O);
            resultAnalyzer.Board.MakeCell(7, MarkType.X);
            resultAnalyzer.Board.MakeCell(8, MarkType.O);
            ResultType resultType = resultAnalyzer.Analyzer();
            Assert.IsTrue(resultType == ResultType.Draw);
        }
    }
}
