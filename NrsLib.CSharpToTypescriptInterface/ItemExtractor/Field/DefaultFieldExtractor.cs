using System.Reflection;

namespace NrsLib.CSharpToTypescriptInterface.ItemExtractor.Field {
    class DefaultFieldExtractor : IFieldExtractor {
        public bool IsSatisfiedBy(FieldInfo fieldInfo)
        {
            return fieldInfo.IsPublic;
        }
    }
}
