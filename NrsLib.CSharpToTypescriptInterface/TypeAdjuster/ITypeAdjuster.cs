using System;

namespace NrsLib.CSharpToTypescriptInterface.TypeAdjuster {
    public interface ITypeAdjuster
    {
        string ToTypescriptType(Type type);
    }
}
