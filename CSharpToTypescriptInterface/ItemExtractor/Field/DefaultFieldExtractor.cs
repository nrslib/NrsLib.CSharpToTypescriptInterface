using System.Reflection;

namespace CSharpToTypescriptInterface.ItemExtractor.Field {
    class DefaultFieldExtractor : IFieldExtractor {
        public bool IsSatisfiedBy(FieldInfo fieldInfo)
        {
            return fieldInfo.IsPublic;
        }
    }
}
