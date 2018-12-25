using UnitTesting.Interfaces;

namespace UnitTesting.Testing
{
    public class FakeFileReader : IFileReader
    {
        public string Read(string path)
        {
            return string.Empty;
        }
    }
}