using System;

namespace CSharpToTypescriptInterface.TypeAdjuster.Spec {
    public interface ITypeSpec
    {
        bool IsSatisfiedBy(Type t);
    }
}
