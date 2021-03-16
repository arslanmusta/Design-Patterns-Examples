using System;
using TemplateMethodPattern.Audit;
using TemplateMethodPattern.Converter;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--AuditTest---");
            AuditTester.Test();
            Console.WriteLine("\n\n--ConverterTest---");
            ConverterTester.Test();
        }
    }
}
