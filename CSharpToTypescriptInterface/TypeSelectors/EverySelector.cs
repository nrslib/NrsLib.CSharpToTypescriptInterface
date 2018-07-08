using System;

namespace CSharpToTypescriptInterface.TypeSelectors {
    public class EveryExtractor : ITypeExtractor {
        public bool IsSatisfiedBy(Type t)
        {
            return true;
        }
    }
}
