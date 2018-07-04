using System;

namespace CSharpToTypescriptInterface.TypeAdjuster.Spec {
    public class StringSpec : ITypeSpec {
        public bool IsSatisfiedBy(Type type)
        {
            return type == typeof(String)
                   || type == typeof(string);
        }
    }
}
