using System;

namespace CSharpToTypescriptInterface.TypeAdjuster {
    public interface ITypeAdjuster
    {
        string ToTypescriptType(Type type);
    }
}
