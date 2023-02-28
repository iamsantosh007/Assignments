using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toe.Models;

namespace TicTaKToeTest.UnitTestCases
{
    [TestClass]
    public class CellTestCase
    {
        [TestMethod]
        public void Constructor_Should_CreateWithEmptyMark()
        {
            Cell cell = new Cell();
            Assert.IsTrue(cell.MarkType==MarkType.Empty);
        }

        [TestMethod]
        public void Constructor_Should_CreateWithX_And_O_Mark()
        {
            Cell cell = new Cell(MarkType.X);
            Cell cell2 = new Cell(MarkType.O);
            Assert.IsTrue(cell.MarkType==MarkType.X);
            Assert.IsTrue(cell2.MarkType==MarkType.O);
        }

        [TestMethod]
        public void IsAlreadyMarked_CheckIfCellIsMarked()
        {
            Cell cell = new Cell(MarkType.X);
            Assert.IsTrue(cell.IsAlreadyMarked());
        }

        [TestMethod]
        [ExpectedException(typeof(CellAlreadyMarkedException))]
        public void ShouldThrowException_When_AgainTry_To_Mark()
        {
            Cell cell = new Cell();
            cell.MarkType = MarkType.X;
            cell.MarkType = MarkType.O;
            Assert.IsTrue(cell.MarkType == MarkType.Empty);
        }
    }
}
