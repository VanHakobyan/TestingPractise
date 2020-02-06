using System.Collections.Generic;

namespace FileManagerLib
{
    class StubFileDataObject : IDataAccessObject
    {
        public List<string> GetFiles()
        {
            return new List<string> { "log.log", "data.log", "test.log" };
        }
    }
}
