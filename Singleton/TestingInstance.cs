using System;

namespace Singleton
{
    public class TestingInstance
    {
        private static object _threadLock = new object();

        private static TestingInstance _instance;
       

        public static TestingInstance Instance
        {
            get
            {
                lock (_threadLock)
                {
                    if (_instance == null)
                    {
                        _instance = new TestingInstance();
                    }
                    return _instance;
                }
            }
        }

        private TestingInstance()
        {            
        }

        public string GetDescription()
        {
            return "Forever alone!";
        }

        public void Test()
        {
            Console.WriteLine($"I am forever alone");
        }
    }
}
