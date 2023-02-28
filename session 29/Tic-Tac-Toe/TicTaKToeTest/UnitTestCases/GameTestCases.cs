using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toe.Models;

namespace TicTaKToeTest.UnitTestCases
{
    [TestClass]
    public class GameTestCases
    {
        [TestMethod]
        public void Constructor_WhenGameIsCreated_CurruntPlayerShouldBePlayer0()
        {
            Player p1 = new Player("santosh", MarkType.X);
            Player p2 = new Player("patro", MarkType.O);
            Player[] players = { p1, p2 };
            Board board = new Board();
            ResultAnalyzer analyzer = new ResultAnalyzer(board);
            Game game = new Game(board,analyzer,players);

            Assert.AreEqual(players[0],game.CurruntPlayer);

        }

        [TestMethod]
        public void Constructor_WhenGameIsCreated_StatusWillBeNoResult()
        {
            Player p1 = new Player("santosh", MarkType.X);
            Player p2 = new Player("patro", MarkType.O);
            Player[] players = { p1, p2 };
            Board board = new Board();
            ResultAnalyzer analyzer = new ResultAnalyzer(board);
            Game game = new Game(board, analyzer, players);

            Assert.AreEqual(game.Status,ResultType.NoResult);

        }

        [TestMethod]
        public void Play_OnceCurruntPlayerShouldChangeToPlayer1()
        {
            Player p1 = new Player("santosh", MarkType.X);
            Player p2 = new Player("patro", MarkType.O);
            Player[] players = { p1, p2 };
            Board board = new Board();
            ResultAnalyzer analyzer = new ResultAnalyzer(board);
            Game game = new Game(board, analyzer, players);
            game.Play(0);
            Assert.AreEqual(players[0], game.CurruntPlayer);

        }

        [TestMethod]
        public void Play_WhenPlayIsCalledTwiceThenCurruntPlayerBecomePlayer0()
        {
            Player p1 = new Player("santosh", MarkType.X);
            Player p2 = new Player("patro", MarkType.O);
            Player[] players = { p1, p2 };
            Board board = new Board();
            ResultAnalyzer analyzer = new ResultAnalyzer(board);
            Game game = new Game(board, analyzer, players);
            game.Play(0);
            game.Play(1);
            Assert.AreEqual(players[0], game.CurruntPlayer);

        }
        [TestMethod]
        public void Play_AfterPlayCheckBoardIsUpdated()
        {
            Player p1 = new Player("santosh", MarkType.X);
            Player p2 = new Player("patro", MarkType.O);
            Player[] players = { p1, p2 };
            Board board = new Board();
            ResultAnalyzer analyzer = new ResultAnalyzer(board);
            Game game = new Game(board, analyzer, players);
            MarkType curruntPlayerMark = game.CurruntPlayer.Mark;
            game.Play(7);
            //game.Play(1);
            Assert.IsTrue(board.Cells[7].MarkType==curruntPlayerMark);

        }

    }
}
