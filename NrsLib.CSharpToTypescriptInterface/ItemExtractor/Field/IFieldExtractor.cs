using System.Reflection;

namespace NrsLib.CSharpToTypescriptInterface.ItemExtractor.Field {
    public interface IFieldExtractor
    {
        bool IsSatisfiedBy(FieldInfo fieldInfo);
    }
}
