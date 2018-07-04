using System;
using System.IO;
using CSharpToTypescriptInterface;

namespace Sample {
    class Program {
        static void Main(string[] args)
        {
            var targetDllFullPath = Path.Combine(Environment.CurrentDirectory, "ClassFileGenerator.dll");
            var converter = new Converter(targetDllFullPath);
            var outputs = converter.Convert(OutputText);
            foreach (var output in outputs)
            {
                Console.WriteLine("=================================");
                Console.WriteLine(output);
            }
            Console.ReadKey();
        }

        private static string OutputText(Type type, string content)
        {
            return string.Join(Environment.NewLine, 
                $"Type: {type.Name}",
                $"----------------------------------",
                content,
                $"----------------------------------");
        }
    }
}
