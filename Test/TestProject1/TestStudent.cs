using StudentServiceLib;

namespace TestProject1
{
    [TestClass]
    public class TestStudent
    {
        [TestMethod]
        public void AssignAScoreGreaterThan10_ShouldThrow_SystemException()
        {
            Student student = new Student();
            bool exceptionOccured = false;
            try
            {
                student.Score = 14;
            }
            catch(SystemException e)
            {
                exceptionOccured = true;
            }
            Assert.IsTrue(exceptionOccured);
        }

        [TestMethod]
        public void AssignBScoreGreaterThan10_ShouldThrow_SystemException()
        {
            Student student = new Student();
            bool exceptionOccured = false;
            try
            {
                student.Score = 7;
            }
            catch (SystemException e)
            {
                exceptionOccured = true;
            }
            Assert.IsTrue(exceptionOccured);
        }

        [TestMethod]
        public void AssignCScoreGreaterThan10_ShouldThrow_SystemException()
        {
            Student student = new Student();
            bool exceptionOccured = false;
            try
            {
                student.Score = 9;
            }
            catch (SystemException e)
            {
                exceptionOccured = true;
            }
            Assert.IsTrue(exceptionOccured);
        }

        [TestMethod]
        public void WhenScoreIs8_TheLetterShouldBe_A()
        {
            Student s = new Student();
            s.Score = 9;

            char letter = s.getLetterScore();
            Assert.AreEqual('A', letter);
        }

        [TestMethod]
        public void WhenScoreIs7_TheLetterShouldBe_B()
        {
            Student s = new Student();
            s.Score = 7;

            char letter = s.getLetterScore();
            Assert.AreEqual('B', letter);
        }

        [TestMethod]
        public void WhenScoreIs5_TheLetterShouldBe_B()
        {
            Student s = new Student();
            s.Score = 5;

            char letter = s.getLetterScore();
            Assert.AreEqual('C', letter);
        }

        [TestMethod]
        public void WhenScoreIs4_TheLetterShouldBe_C()
        {
            Student s = new Student();
            s.Score = 4;

            char letter = s.getLetterScore();
            Assert.AreEqual('D', letter);
        }
    }
}