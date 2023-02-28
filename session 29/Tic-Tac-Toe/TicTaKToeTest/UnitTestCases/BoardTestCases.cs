using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toe.Models;

namespace TicTaKToeTest.UnitTestCases
{
    [TestClass]
    public class BoardTestCases
    {
        [TestMethod]
        public void Constructor_BoardShould_Have9_EmptyCells()
        {
            Board board = new Board();
            Assert.IsTrue(board.Cells.Length==9);
            for(int i=0;i<board.Cells.Length;i++)
            {
                Assert.IsTrue(board.Cells[i].MarkType==MarkType.Empty);
            }
        }

        [TestMethod]
        public void MakeCell_SpecificCellInBoardMustMarkWithXorO()
        {
            Board board = new Board();
            board.MakeCell(8,MarkType.X);
            Assert.IsTrue(board.Cells[8].MarkType==MarkType.X);
        }
    }
}
