using System;

namespace SingletonPattern.Easy
{
    public static class EasyTester
    {
        public static void Test()
        {
            var object1 = God.Instance;
            var object2 = God.Instance;

            object1.Value = 666;

            Console.WriteLine($"Object1 Value: {object1.Value}, Object2 Value: {object2.Value}");
        }
    }
}