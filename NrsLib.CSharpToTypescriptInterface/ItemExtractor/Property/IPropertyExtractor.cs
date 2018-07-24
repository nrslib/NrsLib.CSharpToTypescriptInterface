using System.Reflection;

namespace NrsLib.CSharpToTypescriptInterface.ItemExtractor.Property {
    public interface IPropertyExtractor
    {
        bool IsSatisfiedBy(PropertyInfo propertyInfo);
    }
}
