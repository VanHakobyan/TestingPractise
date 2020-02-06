using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FileManagerLib.Test
{
    [TestClass]
    public class FileManagerTest
    {
        [TestMethod]
        public void FindFile_Log_True()
        {
            var fileManager = new FileManager(new StubFileDataObject());
            var findLogFile = fileManager.FindLogFile("log.log");
            Assert.IsTrue(findLogFile);
        }
    }
}
