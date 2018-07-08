using System.Reflection;

namespace CSharpToTypescriptInterface.ItemExtractor.Field {
    public interface IFieldExtractor
    {
        bool IsSatisfiedBy(FieldInfo fieldInfo);
    }
}
