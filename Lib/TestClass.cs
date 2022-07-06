using System;
using System.Security.Cryptography;

namespace Lib
{
    public class TestClass
    {
        private readonly RandomNumberGenerator generator;
        public TestClass()
        {
            generator = RandomNumberGenerator.Create();
        }
        public string Text => "TestText";
        public int GetInt()
        {
            byte[] bytes = new byte[4];
            generator.GetBytes(bytes);
            return BitConverter.ToInt32(bytes, 0);
        }
    }
}
