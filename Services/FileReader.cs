using System.IO;
using UnitTesting.Interfaces;

namespace UnitTesting.Services
{
    public class FileReader : IFileReader
    {
        public string Read(string path)
        {
            return File.ReadAllText(path);
        }
    }
}