using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QueenAttack
{
    [TestClass]
    public class QueenAttackTest
    {
        [TestMethod]
        public void Queen_CannotMoveThere_False()
        {
            Queen testQueen = new Queen(4,4);
            Assert.AreEqual (false, testQueen.CanMove(5,6));
        }
        [TestMethod]
        public void Queen_CanMoveForward_True()
        {
            Queen testQueen = new Queen(4,4);
            Assert.AreEqual (true, testQueen.CanMove(4,8));
        }
        [TestMethod]
        public void Queen_CanMoveBackward_True()
        {
            Queen testQueen = new Queen(4,4);
            Assert.AreEqual (true, testQueen.CanMove(4,1));
        }
        [TestMethod]
        public void Queen_CanMoveLeft_True()
        {
            Queen testQueen = new Queen(4,4);
            Assert.AreEqual (true, testQueen.CanMove(1,4));
        }
        [TestMethod]
        public void Queen_CanMoveRight_True()
        {
            Queen testQueen = new Queen(4,4);
            Assert.AreEqual (true, testQueen.CanMove(8,4));
        }
        [TestMethod]
        public void Queen_CanMoveFrontRight_True()
        {
            Queen testQueen = new Queen(4,4);
            Assert.AreEqual (true, testQueen.CanMove(8,8));
        }
        [TestMethod]
        public void Queen_CanMoveBackRight_True()
        {
            Queen testQueen = new Queen(4,4);
            Assert.AreEqual (true, testQueen.CanMove(7,1));
        }
        [TestMethod]
        public void Queen_CanMoveBackLeft_True()
        {
            Queen testQueen = new Queen(4,4);
            Assert.AreEqual (true, testQueen.CanMove(1,1));
        }
        [TestMethod]
        public void Queen_CanMoveFrontLeft_True()
        {
            Queen testQueen = new Queen(4,4);
            Assert.AreEqual (true, testQueen.CanMove(1,7));
        }
    }
}