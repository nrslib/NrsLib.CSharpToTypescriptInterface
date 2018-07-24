using System;
using NrsLib.CSharpToTypescriptInterface.TypeSelectors;

namespace Sample {
    class MyExtractor : ITypeExtractor {
        public bool IsSatisfiedBy(Type t)
        {
            return t.Namespace?.StartsWith("TestDll.TestNameSpace") ?? false;
        }
    }
}
