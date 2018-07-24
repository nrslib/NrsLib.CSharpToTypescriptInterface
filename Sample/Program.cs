using System;
using System.IO;
using NrsLib.CSharpToTypescriptInterface;

namespace Sample {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>> UsingDefault <<<<<<<<<<<<<<<<<<<<");
            UsingDefault();
            Console.WriteLine();
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>> UsingMyAdjuster <<<<<<<<<<<<<<<<<<<<");
            UsingMyAdjuster();
            Console.WriteLine();
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>> UsingMyExtractor <<<<<<<<<<<<<<<<<<<<");
            UsingMyExtractor();
            Console.ReadKey();
        }

        private static void UsingDefault()
        {
            var targetDllFullPath = Path.Combine(Environment.CurrentDirectory, "TestDll.dll");
            var converter = new Converter();
            var outputs = converter.Convert(targetDllFullPath, OutputText);
            foreach (var output in outputs) {
                Console.WriteLine("=================================");
                Console.WriteLine(output);
            }
        }

        private static void UsingMyAdjuster()
        {
            var targetDllFullPath = Path.Combine(Environment.CurrentDirectory, "TestDll.dll");
            var converter = new Converter
            {
                TypeAdjuster = new MyAdjuster(),
            };
            var outputs = converter.Convert(targetDllFullPath, OutputText);
            foreach (var output in outputs) {
                Console.WriteLine("=================================");
                Console.WriteLine(output);
            }
        }

        private static void UsingMyExtractor()
        {
            var targetDllFullPath = Path.Combine(Environment.CurrentDirectory, "TestDll.dll");
            var converter = new Converter() {
                TypeExtractor = new MyExtractor()
            };
            var outputs = converter.Convert(targetDllFullPath, OutputText);
            foreach (var output in outputs) {
                Console.WriteLine("=================================");
                Console.WriteLine(output);
            }
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
