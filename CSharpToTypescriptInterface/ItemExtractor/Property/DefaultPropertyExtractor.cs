using System.Reflection;

namespace CSharpToTypescriptInterface.ItemExtractor.Property {
    class DefaultPropertyExtractor : IPropertyExtractor {
        public bool IsSatisfiedBy(PropertyInfo propertyInfo)
        {
            return propertyInfo.GetMethod.IsPublic;
        }
    }
}
