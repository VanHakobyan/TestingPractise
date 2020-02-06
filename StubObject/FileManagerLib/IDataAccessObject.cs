using System.Collections.Generic;

namespace FileManagerLib
{
    public interface IDataAccessObject
    {
        List<string> GetFiles();
    }
}