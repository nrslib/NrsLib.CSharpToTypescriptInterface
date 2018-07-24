using System;

namespace NrsLib.CSharpToTypescriptInterface.TypeAdjuster.Spec {
    public interface ITypeSpec
    {
        bool IsSatisfiedBy(Type t);
    }
}
