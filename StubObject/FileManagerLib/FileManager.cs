using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


[assembly: InternalsVisibleTo("FileManagerLib.Test")]
namespace FileManagerLib
{
    
    public class FileManager
    {
        private IDataAccessObject dataAccessObject;

        public FileManager(){}

        public FileManager(IDataAccessObject dataAccessObject)
        {
            this.dataAccessObject = dataAccessObject;
        }

        public bool FindLogFile(string name)
        {
            var files = dataAccessObject.GetFiles();
            return files.Any(x => x.Contains(name));
        }
    }
}
