using System;

namespace NrsLib.CSharpToTypescriptInterface.TypeAdjuster.Spec {
    public class NumberSpec : ITypeSpec {
        public bool IsSatisfiedBy(Type t)
        {
            return t == typeof(Int16)
                   || t == typeof(Int32)
                   || t == typeof(Int64)
                   || t == typeof(int);
        }
    }
}
