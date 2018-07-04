using System;

namespace CSharpToTypescriptInterface.TypeSelectors {
    class EveryExtractor : ITypeExtractor {
        public bool IsSatisfiedBy(Type t)
        {
            return t.Name != "<>c";
        }
    }
}
