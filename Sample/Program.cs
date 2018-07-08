using System;
using System.IO;
using CSharpToTypescriptInterface;
using CSharpToTypescriptInterface.TypeAdjuster;

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
            var targetDllFullPath = Path.Combine(Environment.CurrentDirectory, "ClassFileGenerator.dll");
            var converter = new Converter(targetDllFullPath);
            var outputs = converter.Convert(OutputText);
            foreach (var output in outputs) {
                Console.WriteLine("=================================");
                Console.WriteLine(output);
            }
        }

        private static void UsingMyAdjuster()
        {
            var targetDllFullPath = Path.Combine(Environment.CurrentDirectory, "ClassFileGenerator.dll");
            var converter = new Converter(targetDllFullPath)
            {
                TypeAdjuster = new DefaultTypeAdjuster(),
            };
            var outputs = converter.Convert(OutputText);
            foreach (var output in outputs) {
                Console.WriteLine("=================================");
                Console.WriteLine(output);
            }
        }

        private static void UsingMyExtractor()
        {
            var targetDllFullPath = Path.Combine(Environment.CurrentDirectory, "ClassFileGenerator.dll");
            var converter = new Converter(targetDllFullPath) {
                TypeExtractor = new MyExtractor()
            };
            var outputs = converter.Convert(OutputText);
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
