using System;

namespace BuilderPattern.Code
{
    public static class CodeTester
    {
        public static void Test()
        {
            var cb = new CodeBuilder("Person")
                .AddField("Name", "string")
                .AddField("Age", "int");

            Console.WriteLine(cb);
        }
    }
}