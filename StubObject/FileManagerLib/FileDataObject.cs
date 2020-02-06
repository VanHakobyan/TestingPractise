using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileManagerLib
{
    public class FileDataObject : IDataAccessObject
    {
        public List<string> GetFiles()
        {
            return new DirectoryInfo(Directory.GetCurrentDirectory()).GetFiles().Select(x => x.Name).ToList();
        }
    }
}
