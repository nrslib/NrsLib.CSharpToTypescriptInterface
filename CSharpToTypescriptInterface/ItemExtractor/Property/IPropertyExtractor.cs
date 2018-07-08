using System.Reflection;

namespace CSharpToTypescriptInterface.ItemExtractor.Property {
    public interface IPropertyExtractor
    {
        bool IsSatisfiedBy(PropertyInfo propertyInfo);
    }
}
