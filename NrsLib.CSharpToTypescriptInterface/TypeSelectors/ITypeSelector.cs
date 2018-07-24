using System;

namespace NrsLib.CSharpToTypescriptInterface.TypeSelectors {
    public interface ITypeExtractor
    {
        bool IsSatisfiedBy(Type t);
    }
}
