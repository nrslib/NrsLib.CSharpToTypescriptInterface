using System;

namespace CSharpToTypescriptInterface.TypeSelectors {
    public interface ITypeExtractor
    {
        bool IsSatisfiedBy(Type t);
    }
}
